using NinjaApp.Business;
using NinjaApp.Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinjaApp.Winform.Forms
{
    public partial class AdminForm : Form
    {
        private readonly IProductService _productService;
        private readonly IStockService _stockService;

        public event Action<string, int> StockBelowThreshold;


        public AdminForm()
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            _productService = dependencyContainer.GetProductServiceInstance();
            _stockService = dependencyContainer.GetStockServiceInstance();

        }


        private void DataGridViewDoubleClickHandler()
        {
            dataGridView1.CellDoubleClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string selectedProductName = dataGridView1.Rows[e.RowIndex].Cells["Ürünler"].Value.ToString();
                    SuplierForm suplierForm = new SuplierForm(selectedProductName);
                    suplierForm.Show();
                }
            };
        }


        public void Chart()
        {
            List<string> sliceNames = new List<string> { "Kırmızı Et", "Bakliyat", "Şarküteri" };
            List<double> sliceValues = new List<double> { 30.0, 45.0, 25.0 };

            chart1.Series.Clear();
            chart1.Series.Add("PieSeries");
            chart1.Series["PieSeries"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            for (int i = 0; i < sliceNames.Count; i++)
            {
                chart1.Series["PieSeries"].Points.AddXY(sliceNames[i], sliceValues[i]);
            }
        }


        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Sadece stok sütununu kontrol etmek istiyorsak sütun numarasını belirleyin
            int stokSutunIndex = 1; // Örnek olarak 2. sütunu kontrol ediyoruz (sıfırdan başladığına dikkat edin)

            // Sadece belirli bir sütunu kontrol edelim
            if (e.ColumnIndex == stokSutunIndex && e.RowIndex >= 0)
            {
                // DataGridView hücresinin değerini alın
                int stokMiktari = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);


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
        }


        

        private void SendNotificationToSuppliers(string productName, int stockAmount)
        {
            // Supliers formundaki mesaj gridview tablosuna mesaj ekleme kodunu burada yazın.
            // Mesaj içeriği "ürünAdi + sayısı azaldı" olacak şekilde ayarlanmalıdır.
            // İlgili satırları ekleyebilirsiniz.
        }

        public void Stock()
        {
            dataGridView1.DataSource = null;
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
            dataGridView1.DataSource = null;
            Stock();
            Chart();
        }

       
    }
}
