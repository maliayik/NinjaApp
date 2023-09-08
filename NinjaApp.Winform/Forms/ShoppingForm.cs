using NinjaApp.Business;
using NinjaApp.Business.Services;
using NinjaApp.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NinjaApp.Winform.Forms
{
    public partial class ShoppingForm : Form
    {
        private readonly IShoppingService _shoppingService;
        private List<ShoppingDto> _shoppingData;

        public ShoppingForm()
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            _shoppingService = dependencyContainer.GetShoppingServiceInstance();
            cmbCategories.SelectedIndexChanged += new EventHandler(cmbCategories_SelectedIndexChanged);
        }


        private void ShoppingForm_Load(object sender, EventArgs e)
        {
            _shoppingData = _shoppingService.GetShoppingProductWithDto();

            // Form yüklendiğinde ComboBox'ı kategorilerle doldur
            FillCategoryComboBox();

            // Tüm ürünleri DataGridView'e yükle
            UpdateDataGridView(_shoppingData);
        }

        /// <summary>
        /// ComboBox'ı temizler ve kategorileri ComboBox'a ekler.
        /// </summary>
        private void FillCategoryComboBox()
        {
            cmbCategories.Items.Clear();
            cmbCategories.Items.AddRange(_shoppingData.Select(c => c.Kategori).Distinct().ToArray());
        }

        /// <summary>
        /// ComboBox'tan bir kategori seçildiğinde çağrılan bu metot, seçilen kategoriye göre ürünleri listeler.
        /// </summary>   
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategories.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                LoadProductsByCategory(selectedCategory);
            }
        }

        /// <summary>
        ///  Seçilen kategoriye göre ürünleri listeleyen bu metot, DataGridView'i günceller.
        /// </summary>     
        private void LoadProductsByCategory(string category)
        {
            var shoppingData = _shoppingData.Where(item => item.Kategori == category).ToList();
            UpdateDataGridView(shoppingData);
        }

        /// <summary>
        /// Bu metot datagridview tablomuzun istenilen özellikte listelenmesine yarar.
        /// </summary>        
        private void UpdateDataGridView(List<ShoppingDto> shoppingData)
        {
            shoppingData = shoppingData.OrderBy(item => item.Ürünler).ToList();
            dataGridView1.DataSource = shoppingData;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }
    }
}
