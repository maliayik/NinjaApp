using NinjaApp.Business;
using NinjaApp.Business.Services;
using NinjaApp.DTOs;

namespace NinjaApp.Winform.Forms
{
    public partial class SuplierForm : Form
    {
        private string selectedProductName;
        private readonly ISuplierService _suplierService;
        private readonly IProductService _productService;
        private readonly IInboxService _inboxService;

        private AdminDto loggedInAdmin;
        string AdminFullname;

        public SuplierForm(string productName, AdminDto loggedInAdmin)
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            _suplierService = dependencyContainer.GetSuplierServiceInstance();
            _productService = dependencyContainer.GetProductServiceInstance();
            _inboxService = dependencyContainer.GetInboxServiceInstance();
            var adminForm = new AdminForm(loggedInAdmin);

            selectedProductName = productName;

            this.loggedInAdmin = loggedInAdmin;


        }



        private void SuplierForm_Load(object sender, EventArgs e)
        {

            Inbox();
            InitializeDataGridView();
            InitializeComboBox();
        }

        /// <summary>
        /// Kategori seçimini başlatmak için ComboBox'ı doldurur.
        /// </summary>
        private void InitializeComboBox()
        {
            // ComboBox'a kategorileri ekleyin
            cmbSelectedCategory.Items.Add("Kırmızı Et");
            cmbSelectedCategory.Items.Add("Manav");
            cmbSelectedCategory.Items.Add("Bakliyat");

            // ComboBox'ın varsayılan seçeneğini ayarlayın (örneğin, ilk kategoriyi seçin)
            cmbSelectedCategory.SelectedIndex = 0;
        }

        /// <summary>
        /// DataGridView'i ürünlerin listelendiği bir arayüz olarak başlatır.
        /// </summary>
        private void InitializeDataGridView()
        {
            // DataGridView sütunlarını tanımlayın
            suplierGridView.Columns.Add("Ürünler", "Ürünler");
            suplierGridView.Columns.Add("Kategori", "Kategori");
            suplierGridView.Columns.Add("Birim", "Birim");
            suplierGridView.Columns.Add("Fiyat", "Fiyat");
            suplierGridView.Columns.Add("Stok", "Stok");

            suplierGridView.Columns["Kategori"].Visible = false;
            suplierGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(suplierGridView_CellFormatting);
            suplierGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            suplierGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            suplierGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            suplierGridView.CellClick += new DataGridViewCellEventHandler(suplierGridView_CellClick);

        }


        /// <summary>
        /// DataGridView'den ürün seçildiğinde ilgili verileri kullanıcı arayüzüne yükler.
        /// </summary>  
        private void suplierGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır tıklanmış mı kontrol edin
            {
                // Seçilen satırın ürün, stok ve fiyat bilgilerini alın
                string selectedProduct = suplierGridView.Rows[e.RowIndex].Cells["Ürünler"].Value.ToString();
                string stockInfo = suplierGridView.Rows[e.RowIndex].Cells["Stok"].Value.ToString();
                string priceInfo = suplierGridView.Rows[e.RowIndex].Cells["Fiyat"].Value.ToString()+"TL";

                // Değerleri ilgili kontrollere aktarın
                txtSelectedProduct.Text = selectedProduct;
                txtUnit.Text = stockInfo;
                lblTotal.Text = priceInfo;
            }
        }

        /// <summary>
        /// DataGridView'deki fiyat ve stok sütunlarını biçimlendirir.
        /// </summary>    
        private void suplierGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Fiyat sütunu için işlem yapın (örneğin, 3. sütun)
            if (e.ColumnIndex == 3) // 3. sütun (sıfırdan başladığına dikkat edin)
            {
                if (e.Value != null)
                {
                    decimal price = (decimal)e.Value;
                    e.Value = price.ToString("") + "TL"; // Fiyatı formatlayın ve "TL" ekleyin
                    e.FormattingApplied = true; // Düzgün biçimlendiğini işaretleyin
                }
            }

            // Stok sütunu için işlem yapın (örneğin, 4. sütun)
            if (e.ColumnIndex == 2) // 4. sütun (sıfırdan başladığına dikkat edin)
            {
                if (e.Value != null)
                {
                    int stock = (int)e.Value;
                    e.Value = stock.ToString() + "kg"; // Stoku formatlayın ve "kg" ekleyin
                    e.FormattingApplied = true; // Düzgün biçimlendiğini işaretleyin
                }
            }
        }

        /// <summary>
        /// Kategori seçimi değiştirildiğinde ürünleri kategoriye göre listeleyen bir işlem yapar.
        /// </summary>
        private void cmbSelectedCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbSelectedCategory.SelectedItem.ToString();

            // SuplierService'i kullanarak verileri alın
            List<SupliersDto> supliers = _suplierService.GetSupliersByCategory(selectedCategory);

            // SuplierDataGridView'i temizleyin
            suplierGridView.Rows.Clear();

            // Verileri DataGridView'e yükleyin
            foreach (var suplier in supliers)
            {
                suplierGridView.Rows.Add(
                    suplier.Ürünler,
                    suplier.Kategori,
                    suplier.Birim,
                    suplier.Fiyat,
                    suplier.Stok
                );
            }
        }


        /// <summary>
        /// Ürün satın alma işlemi yapar ve stok miktarını günceller.
        /// </summary>   
        private void btnBuy_Click(object sender, EventArgs e)
        {

            string productName = txtSelectedProduct.Text;
            int purchasedStock;

            if (!string.IsNullOrEmpty(productName))
            {
                if (int.TryParse(txtUnit.Text, out purchasedStock))
                {
                    // DataGridView'den seçilen ürünün stok miktarını alın
                    int currentStock = Convert.ToInt32(suplierGridView.CurrentRow.Cells["Stok"].Value);

                    if (purchasedStock <= currentStock)
                    {
                        _productService.IncreaseProductStock(productName, purchasedStock);

                        MessageBox.Show("Ürün stok miktarı güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdi miktarı mevcut stok miktarından fazla olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        /// <summary>
        /// Kullanıcıya gelen mesajları görüntüler.
        /// </summary>
        public void Inbox()
        {
            var inboxData = _inboxService.GetListAll();
            messageDataGridView.DataSource = inboxData;
            messageDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            messageDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            messageDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageDataGridView.Columns["Id"].Visible = false;
            messageDataGridView.Columns["Description"].HeaderText = "Mesajlar";
        }


        /// <summary>
        /// Tedarikçi formunu kapatır ve admin formunu gösterir.
        /// </summary>    
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm adminForm = new AdminForm(loggedInAdmin);
            adminForm.Show();
        }
    }
}
