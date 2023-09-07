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

namespace NinjaApp.Winform.Forms
{
    public partial class UserForm : Form
    {
        private readonly IUserService _userService;
        private AddMoneyForm addMoneyForm;
        private ChangePasswordForm changePasswordForm;


        //değişecek giriş yapan kullanıcıya göre bu form açılacak.
        int userId = 1;
        public UserForm()
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            _userService = dependencyContainer.GetUserServiceInstance();

            addMoneyForm = new AddMoneyForm();
            addMoneyForm.MoneyAdded += AddMoneyForm_MoneyAdded;

            changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ChangePassword += ChangePasswordForm_ChangePassword;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            Orders();
            GetBalance();

        }


        /// <summary>
        /// Bu metot kullanıcının bakiyesini görüntülemek için.
        /// </summary>
        public void GetBalance()
        {
            UserDto user = _userService.GetUsersById(userId);

            if (user != null)
            {
                txtUserLogin.Text = user.Username;
                txtBalance.Text = (user.Balance).ToString() + "TL";
            }

        }

        /// <summary>
        /// Bu metot kullanıcıgın geçmiş siparişlerini görüntülemesi için.
        /// </summary>
        public void Orders()
        {
            var ordersData = _userService.GetReceiptByUserId(userId);
            ordersData = ordersData.OrderBy(item => item.Tarih).ToList();
            dataGridView1.DataSource = ordersData;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["UserId"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            addMoneyForm.Show();
        }


        /// <summary>
        /// Bu metot Addmoney formu kapatıldıgında bakiyemizin güncellenmesi için.
        /// </summary>

        private void AddMoneyForm_MoneyAdded(object sender, EventArgs e)
        {

            GetBalance();
        }


        /// <summary>
        /// güncellenmesi gerekiyor bu form şifre değiştirildiginde login forma yönlendirecek.
        /// </summary>

        private void ChangePasswordForm_ChangePassword(object sender, EventArgs e)
        {

            Application.OpenForms.Cast<Form>().ToList().ForEach(form => form.Close());

            // Yeni bir LoginForm aç
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }


        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            changePasswordForm.Show();
        }
    }
}
