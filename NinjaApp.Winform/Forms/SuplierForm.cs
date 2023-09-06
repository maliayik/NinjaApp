namespace NinjaApp.Winform.Forms
{
    public partial class SuplierForm : Form
    {
        private string selectedProductName;

        public SuplierForm(string productName)
        {
            InitializeComponent();
            selectedProductName = productName;
            var adminForm = new AdminForm();
            adminForm.StockBelowThreshold += HandleStockBelowThreshold;
        }

        private void HandleStockBelowThreshold(string productName, int stockAmount)
        {
            string message = $"{productName} ürününün stok miktarı {stockAmount} oldu.";
            MessageBox.Show(message, "Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
