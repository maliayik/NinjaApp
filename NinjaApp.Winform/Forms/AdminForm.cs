using NinjaApp.Business;
using NinjaApp.Business.Services;
using NinjaApp.DTOs;
using System.Data;

namespace NinjaApp.Winform.Forms
{
    public partial class AdminForm : Form
    {
        private readonly IProductService _productService;
        private readonly IStockService _stockService;
        private readonly IPriceEditService _priceEditService;
        private readonly IChartService _chartService;

        private AdminDto _loggedInAdmin;


        /// <summary>
        /// Mesaj eventini yakalamak için yazılmıs action.
        /// </summary>
        public event Action<string, int> StockBelowThreshold;


        public AdminForm(AdminDto loggedInAdmin)
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            _productService = dependencyContainer.GetProductServiceInstance();
            _stockService = dependencyContainer.GetStockServiceInstance();
            _priceEditService = dependencyContainer.GetPriceEditServiceInstance();
            _chartService = dependencyContainer.GetChartServiceInstance();
            _loggedInAdmin = loggedInAdmin;
        }


        /// <summary>
        /// Bu metot DataGridView tablomuzdaki çift tıklama aksiyonunu yakalıyarak belirlenen sayfaya yönlendirmeyi sağlar.
        /// </summary>
        private void DataGridViewDoubleClickHandler()
        {
            dataGridView1.CellDoubleClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string selectedProductName = dataGridView1.Rows[e.RowIndex].Cells["Ürünler"].Value.ToString();
                    //SuplierForm suplierForm = new SuplierForm(selectedProductName);
                    // suplierForm.Show();
                }
            };
        }



        /// <summary>
        /// Bu metot Stok tablosundaki satırların hücrelerindeki değerlerin belirtilen değer aralığına göre renk almasını sağlar.
        /// </summary>

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Sadece stok sütununu kontrol etmek istiyorsak sütun numarasını belirleyin
            int stokSutunIndex = 1; // Örnek olarak 2. sütunu kontrol ediyoruz (sıfırdan başladığına dikkat edin)

            // Sadece belirli bir sütunu kontrol edelim
            if (e.ColumnIndex == stokSutunIndex && e.RowIndex >= 0)
            {
                int stokMiktari;
                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out stokMiktari))
                {
                    if (stokMiktari < 100) // Değiştirmeniz gereken alt sınırı belirtin
                    {
                        e.CellStyle.BackColor = Color.Red; // Stok azaldığında hücre rengini kırmızı yapabilirsiniz
                        e.CellStyle.ForeColor = Color.White; // Opsiyonel: metin rengini beyaz yapabilirsiniz
                    }
                    else if (stokMiktari <= 200)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                    }
                }
                else
                {
                    MessageBox.Show($"stoğunuz bitmiştir kalan stok = {stokMiktari} ");
                }




            }
        }

        /// <summary>
        /// Bu metot Fiyat günceleme tablosundaki seçilen değerleri güncelemeye yarar.
        /// </summary>     
        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                selectedRow.Selected = true;


                string ProductName = selectedRow.Cells["Ürünler"].Value.ToString();
                decimal Price = Convert.ToDecimal(selectedRow.Cells["Fiyat"].Value);

                txtSelectedPrice.Text = Price.ToString();
                txtSelectedProduct.Text = ProductName;
            }
        }


        /// <summary>
        /// Bu metot Fiyat güncellemesi işlemlerini gerçekleştirir.
        /// </summary>
        public void PriceEdit()
        {
            var stockData = _priceEditService.GetPriceEditDtos();
            stockData = stockData.OrderBy(item => item.Ürünler).ToList();
            dataGridView2.DataSource = stockData;
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.CellClick += DataGridViewCellClick;
        }



        /// <summary>
        /// Bu metot mevcut stok tablosunu gösterir ve yeni stoklar eklememize olanak tanır.
        /// </summary>
        public void Stock()
        {
            var stockData = _stockService.GetStockListDto();
            stockData = stockData.OrderBy(item => item.Stok).ToList();
            dataGridView1.DataSource = stockData;
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            DataGridViewDoubleClickHandler();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int stockAmount = Convert.ToInt32(row.Cells["Stok"].Value);
                string productName = row.Cells["Ürünler"].Value.ToString();

                if (stockAmount < 200)
                {
                    // Stok 200'ün altındaysa bildirim gönder
                    StockBelowThreshold?.Invoke(productName, stockAmount);
                }
            }
        }




        private void AdminForm_Load(object sender, EventArgs e)
        {
            lblAdmin.Text = _loggedInAdmin.Fullname;

            Stock();
            PriceEdit();

            comboBox1.Items.Add(3);
            comboBox1.Items.Add(6);
            comboBox1.Items.Add(9);
            comboBox1.SelectedIndex = 0;



        }


        /// <summary>
        /// Bu metod PriceEdit tablosunun ubdate price işlemini gerçekleştirmeye yarar.
        /// </summary>

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                decimal newPrice;
                if (decimal.TryParse(txtSelectedPrice.Text, out newPrice))
                {
                    int productId = (int)selectedRow.Cells["Id"].Value;

                    // Yalnızca fiyatı güncelle
                    _priceEditService.UpdatePriceEditDtos(new PriceEditDto
                    {
                        Id = productId,
                        Fiyat = newPrice
                    });

                    PriceEdit();
                    Stock();
                }
            }
        }


        /// <summary>
        /// Bu event chartımızdaki verileri seçilen değere göre listelemeye yarar.
        /// </summary>

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItem = Convert.ToInt32(comboBox1.SelectedItem);

            List<ChartDto> chartData = _chartService.GetChart(selectedItem);

            chart1.Series.Clear();
            chart1.Series.Add("PieSeries");
            chart1.Series["PieSeries"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (var data in chartData)
            {
                chart1.Series["PieSeries"].Points.AddXY(data.ProductName, data.SaleCount);
            }

        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
