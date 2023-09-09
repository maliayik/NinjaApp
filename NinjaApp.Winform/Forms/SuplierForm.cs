using NinjaApp.DTOs;

namespace NinjaApp.Winform.Forms
{
    public partial class SuplierForm : Form
    {
        private string selectedProductName;

        private AdminDto _logggedInAdmin;
        public SuplierForm(string productName,AdminDto loggedInAdmin)
        {
            InitializeComponent();
            selectedProductName = productName;
            var adminForm = new AdminForm(loggedInAdmin);
            adminForm.StockBelowThreshold += HandleStockBelowThreshold;
        }

        private void HandleStockBelowThreshold(string productName, int stockAmount)
        {
            string message = $"{productName} ürününün stok miktarı {stockAmount} oldu.";
            MessageBox.Show(message, "Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
