using NinjaApp.Business;
using NinjaApp.Business.Services;
using NinjaApp.DTOs;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace NinjaApp.Winform.Forms
{
    public partial class ShoppingForm : Form
    {
        private readonly IShoppingService _shoppingService;
        private IUserService _userService;
        private IReceiptService _receiptService;
        private IProductService _productService;

        private List<ShoppingDto> _shoppingData;
        private UserForm userForm;

        private List<ReceiptDto> receiptDataList = new List<ReceiptDto>();
        private UserLoginDto _loggedInUser;
        private Dictionary<string, DataGridViewRow> addedProducts = new Dictionary<string, DataGridViewRow>();


        public ShoppingForm(UserLoginDto loggedInUser)
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            _shoppingService = dependencyContainer.GetShoppingServiceInstance();
            _userService = dependencyContainer.GetUserServiceInstance();
            _receiptService = dependencyContainer.GetReceiptServiceInstance();
            _productService = dependencyContainer.GetProductServiceInstance();


            cmbCategories.SelectedIndexChanged += new EventHandler(cmbCategories_SelectedIndexChanged);
            dataGridView1.DoubleClick += new EventHandler(dataGridView1_DoubleClick);
            dataGridView1.CellFormatting += DataGridView_CellFormatting;
            dataGridView2.CellFormatting += DataGridView_CellFormatting;
            dataGridView2.CellClick += dataGridView2_CellClick;
            _loggedInUser = loggedInUser;
            this.FormClosed += SuplierForm_FormClosed;
            userForm = new UserForm(loggedInUser);

        }


        private void ShoppingForm_Load(object sender, EventArgs e)
        {
            _shoppingData = _shoppingService.GetShoppingProductWithDto();

            // Form yüklendiğinde ComboBox'ı kategorilerle doldur
            FillCategoryComboBox();

            // Tüm ürünleri DataGridView'e yükle
            UpdateDataGridView(_shoppingData);

            //datagridview2 columnlarını yükler
            SetupDataGridViewColumns();

            UpdateUserInformation(_loggedInUser);

            cmbUnit.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                cmbUnit.Items.Add(i);
            }

            UpdateTotalLabel();
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
            dataGridView1.Columns["Adet"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }


        /// <summary>
        /// DataGridView1'de çift tıklanan bir ürünü DataGridView2'ye ekleyen bir metottur.
        /// </summary> 
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {

                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string productName = selectedRow.Cells["Ürünler"].Value.ToString();
                string unit = selectedRow.Cells["Birim"].Value.ToString();
                string euroPriceStr = selectedRow.Cells["Fiyat"].Value.ToString();
                string adetStr = selectedRow.Cells["Adet"].Value.ToString();

                string tlPriceStr = euroPriceStr.Replace("EUR", "TL");

                dataGridView2.Rows.Add(productName, unit, tlPriceStr, adetStr);

                SetDataGridView2Colums();
                UpdateTotalLabel();
            }
        }

        /// <summary>
        /// DataGridView sütunlarını biçimlendiren bir metottur, özellikle "Fiyat" sütununa "TL" "Birim" sütununa "kg" ekler.
        /// </summary>       
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null && e.RowIndex >= 0 && e.Value != null)
            {
                DataGridViewColumn column = dataGridView.Columns[e.ColumnIndex];

                if (column.Name == "Birim")
                {
                    // Birim sütunu ve satır indeksi uygunsa ve değer null değilse, değere "kg" ekleyin
                    string unitStr = e.Value.ToString();
                    string unitWithKg = unitStr + "kg";
                    e.Value = unitWithKg;
                    e.FormattingApplied = true;
                }
                else if (column.Name == "Fiyat")
                {
                    // Fiyat sütunu ve satır indeksi uygunsa ve değer null değilse, değere "TL" ekleyin
                    string priceStr = e.Value.ToString();
                    string tlPriceStr = priceStr + "TL";
                    e.Value = tlPriceStr;
                    e.FormattingApplied = true;
                }
            }
        }

        /// <summary>
        /// Kasa tablomuza sabit kolonları eklmeye yarar.
        /// </summary>
        private void SetupDataGridViewColumns()
        {
            SetDataGridView2Colums();

            DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn();
            productNameColumn.HeaderText = "Ürünler";
            productNameColumn.Name = "Ürünler";
            dataGridView2.Columns.Add(productNameColumn);

            DataGridViewTextBoxColumn unitColumn = new DataGridViewTextBoxColumn();
            unitColumn.HeaderText = "Birim";
            unitColumn.Name = "Birim";
            dataGridView2.Columns.Add(unitColumn);

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.HeaderText = "Fiyat";
            priceColumn.Name = "Fiyat";
            dataGridView2.Columns.Add(priceColumn);

            DataGridViewTextBoxColumn adetColumn = new DataGridViewTextBoxColumn();
            adetColumn.HeaderText = "Adet";
            adetColumn.Name = "Adet";
            dataGridView2.Columns.Add(adetColumn);


            dataGridView2.Columns["Adet"].Visible = false;
        }

        /// <summary>
        /// Bu metot, bir DataGridView kontrolünün otomatik boyutlandırma ve boyutlandırma davranışını yapılandırır.
        /// </summary>
        private void SetDataGridView2Colums()
        {
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        /// <summary>
        ///  DataGridView2'de bir hücreye tıkladığınızda çalışan bir metottur ve seçilen ürünün detaylarını gösterir.
        /// </summary>        
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Tıklanan satırı alın
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                // Ürün adını alın
                object productNameObj = selectedRow.Cells["Ürünler"].Value;
                if (productNameObj != null)
                {
                    string productName = productNameObj.ToString();

                    // Diğer hücrelerden bilgileri alabilirsiniz, ama sadece ürün adını txtSelectedProduct içine yerleştirin
                    // Örnek olarak fiyatı para birimi ile gösteriyoruz
                    decimal price;
                    if (decimal.TryParse(selectedRow.Cells["Fiyat"].Value?.ToString(), out price))
                    {
                        // Diğer bilgileri de alabilirsiniz

                        // Ürün adını txtSelectedProduct içerisine yerleştirin
                        txtSelectedProduct.Text = productName;
                    }
                }

            }
        }


        /// <summary>
        /// Ürün eklemek için "Ekle" düğmesine tıkladığınızda çalışan bir metottur.
        ///  </summary>       
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtSelectedProduct.Text))
            {
                int selectedUnit = (int)cmbUnit.SelectedItem;
                string selectedProductName = txtSelectedProduct.Text; // Seçilen ürün adını alın


                if (!addedProducts.ContainsKey(selectedProductName))
                {
                    // Eğer ürün daha önce eklenmediyse
                    int unitQuantity = selectedUnit;
                    decimal unitPrice = _shoppingData.First(item => item.Ürünler == selectedProductName).Fiyat; // Ürün fiyatını alın
                    decimal totalPrice = unitQuantity * unitPrice;

                    if (unitQuantity <= 10)
                    {
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.Cells.Add(new DataGridViewTextBoxCell { Value = selectedProductName });
                        newRow.Cells.Add(new DataGridViewTextBoxCell { Value = selectedUnit.ToString() + "" });
                        newRow.Cells.Add(new DataGridViewTextBoxCell { Value = totalPrice.ToString("") + "" });

                        dataGridView2.Rows.Add(newRow);
                        addedProducts.Add(selectedProductName, newRow);
                    }
                    else
                    {
                        // 10 birim sınırını aştığında kullanıcıya uyarı verin
                        MessageBox.Show("Birim sınırını aştınız. En fazla 10 birim ekleyebilirsiniz.");
                    }
                }
                else
                {
                    // Ürün daha önce eklenmiş, kullanıcıya uyarı verin veya başka bir işlem yapın.
                    MessageBox.Show("Bu ürünü daha önce eklediniz.");
                }

                // İşlem tamamlandığında combobox'ı temizleyin
                cmbUnit.SelectedIndex = -1;
                SetDataGridView2Colums();
                UpdateTotalLabel();
            }


        }


        /// <summary>
        /// Toplam fiyatı hesaplayan ve etiketi güncelleyen bir metottur.
        /// </summary>
        private void UpdateTotalLabel()
        {

            decimal total = GetTotalToPay();
            decimal balance = GetBalance(); // Kullanıcının güncel bakiyesini alın

            lblTotal.Text = total.ToString("") + " TL"; // Toplama "TL" ekleyin         

        }



        /// <summary>
        ///  Seçili bir ürünü kaldırmak için "Kaldır" düğmesine tıkladığınızda çalışan bir metottur.
        /// </summary>      
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
                dataGridView2.Rows.RemoveAt(selectedRowIndex);
                UpdateTotalLabel();
            }
        }


        /// <summary>
        /// Bu metot, kullanıcı bağlantısına tıklandığında çalışır ve kullanıcı formunu gösterir.
        /// </summary>    
        private void linkLabelUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm(_loggedInUser);
            userForm.Show();

        }

        /// <summary>
        /// Bu metot, form kapatıldığında çalışır ve giriş formunu yeniden gösterir.
        /// </summary>      
        private void SuplierForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }

        /// <summary>
        /// Bu metot, kullanıcı bilgilerini günceller ve kullanıcının adını ve bakiyesini gösterir.
        /// </summary>    
        public void UpdateUserInformation(UserLoginDto updatedUser)
        {
            _loggedInUser = updatedUser;
            linkLabelUser.Text = "Hoş geldiniz, " + _loggedInUser.Fullname;

            UserDto user = _userService.GetUsersById(_loggedInUser.Id);
            decimal balance = user.Balance;
            lblBalance.Text = "Bakiyeniz: " + balance.ToString("0.00") + " TL";

        }

        /// <summary>
        /// Bu metod, kullanıcının alışveriş sepetindeki ürünleri ödeme yapmak için işleme koyduğu ve ödeme dekontunu görüntülediği bir işlemi temsil eder.
        /// </summary>    
        private void btnPay_Click(object sender, EventArgs e)
        {

            if (dataGridView2.Rows != null)
            {

                decimal totalToPay = GetTotalToPay();
                decimal balance = GetBalance();



                if (balance >= totalToPay && totalToPay != 0)
                {
                    // Bakiyeyi güncelle: Yeni bakiye, eski bakiyeden toplam tutarı çıkart
                    decimal newBalance = balance - totalToPay;

                    // Kullanıcının bakiyesini güncelle
                    _userService.UpdateUserBalanceAfterPayment(_loggedInUser.Id, newBalance);

                    // Yeni bakiyeyi lblBalance içinde göster
                    lblBalance.Text = "Bakiyeniz: " + newBalance.ToString("0.00") + " TL";

                    List<ReceiptDto> receiptDataList = new List<ReceiptDto>();

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        string productName = row.Cells["Ürünler"].Value?.ToString();
                        object unitcell = row.Cells["Birim"].Value;

                        int unit;
                        decimal price;


                        if (decimal.TryParse(row.Cells["Fiyat"].Value?.ToString()?.Replace("TL", "").Trim(), out price) && unitcell != null && int.TryParse(unitcell.ToString(), out unit))

                        {
                            ReceiptDto receiptData = new ReceiptDto
                            {
                                Ürünler = productName ?? "",
                                Toplam = price,
                                Birim = unit,
                                Tarih = DateTime.Now,
                                UserId = _loggedInUser.Id
                            };

                            receiptDataList.Add(receiptData);
                        }
                    }

                    foreach (var receiptData in receiptDataList)
                    {
                        _receiptService.AddReceipt(receiptData);
                        _productService.DecreaseProductStock(receiptData.Ürünler, receiptData.Birim);

                    }

                    // Ödeme başarılı mesajını göster
                    ShowPaymentSuccessMessage();

                    // ReceiptForm'u göster ve bu formu gizle
                    ReceiptForm receiptForm = new ReceiptForm(receiptDataList);
                    receiptForm.FormClosed += (formSender, formArgs) =>
                    {
                        this.Show();
                    };
                    receiptForm.Show();

                    // Ödeme işlemi tamamlandığında alışveriş sepetini temizle
                    dataGridView2.Rows.Clear();
                    UpdateTotalLabel();
                }
                else
                {
                    MessageBox.Show("Bakiyeniz yetersiz. Ödeme işlemi gerçekleştirilemedi.");
                }

            }
            else
            {
                MessageBox.Show("Lütfen almak istediğiniz ürünü sepete ekleyiniz.");
            }
        }



        /// <summary>
        /// Sepetteki ürünlerin toplam ödeme tutarını hesaplar ve döndürür.
        /// </summary>   
        private decimal GetTotalToPay()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                object fiyatValue = row.Cells["Fiyat"].Value;
                if (fiyatValue != null)
                {
                    string priceStr = fiyatValue.ToString();
                    decimal price = decimal.Parse(priceStr.Replace("TL", "").Trim());
                    total += price;
                }
            }

            return total;
        }

        /// <summary>
        /// Kullanıcının bakiyesini alır ve döndürür.
        /// </summary>      
        private decimal GetBalance()
        {
            decimal balance = 0;

            UserDto user = _userService.GetUsersById(_loggedInUser.Id);
            balance = user.Balance;

            return balance;
        }


        /// <summary>
        /// deme işleminin başarılı olduğuna dair bir mesaj gösterir.
        /// </summary>
        private void ShowPaymentSuccessMessage()
        {
            MessageBox.Show("Satın alma işlemi başarıyla gerçekleşti. Bizi tercih ettiğiniz için teşekkür ederiz.", "Ödeme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// bu formu kapatır.
        /// </summary>

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

