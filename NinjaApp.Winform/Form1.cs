using Microsoft.Data.Sqlite;
using NinjaApp.Business;
using NinjaApp.Business.Interfaces;
using NinjaApp.Data.Helpers;
using NinjaApp.Entities;
using System.Data;

namespace NinjaApp.Winform
{
    public partial class Form1 : Form
    {
        private readonly ITestService _testService;

        public Form1()
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            _testService = dependencyContainer.GetTestServiceInstance();
        }


        /// <summary>
        /// test i�in yaz�lm�st�r bu formda herhangi bir kodlama yapmay�n�z �rnek datay� bu sek�lde text box i�inde g�sterebilirsiniz.
        /// </summary>
        private void LoadProduct()
        {
            var productList = _testService.GetTestListDtos();
            cmbTest.DataSource = null;
            cmbTest.DataSource = productList;
            cmbTest.DisplayMember = "Product";
            cmbTest.ValueMember = "Id";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }



}
