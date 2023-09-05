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
