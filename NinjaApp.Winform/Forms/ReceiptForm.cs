using NinjaApp.DTOs;

namespace NinjaApp.Winform.Forms
{
    public partial class ReceiptForm : Form
    {
        private List<ReceiptDto> _receiptDataList;

        public ReceiptForm(List<ReceiptDto> receiptDataList)
        {
            InitializeComponent();
            _receiptDataList = receiptDataList;
            DataGridViewInstance();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            foreach (var receiptData in _receiptDataList)
            {
                dataGridView1.Rows.Add(
                   receiptData.Ürünler,
                   receiptData.Birim,
                   receiptData.Tarih,
                   receiptData.Toplam,
                   receiptData.UserId
                );
            }


        }

        /// <summary>
        /// DataGridView öğesini oluşturur ve satın alma bilgilerini düzenlemek için sütunlar ekler.
        /// </summary>
        public void DataGridViewInstance()
        {
            dataGridView1.Columns.Add("Ürünler", "Ürünler");
            dataGridView1.Columns.Add("Miktar", "Miktar");
            dataGridView1.Columns.Add("Tarih", "Tarih");
            dataGridView1.Columns.Add("Toplam", "Toplam");
            dataGridView1.Columns.Add("Kullanıcı No", "Kullanıcı No");

            dataGridView1.Columns["Kullanıcı No"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        /// <summary>
        /// Formu kapatır ve makbuz penceresini kapatır.
        /// </summary>   
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
