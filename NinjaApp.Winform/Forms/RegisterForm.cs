using NinjaApp.Business;
using NinjaApp.Business.Services;
using NinjaApp.DTOs;
using NinjaApp.Entities;
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
    public partial class RegisterForm : Form
    {
        private readonly IRegisterService _registerService;
        private readonly IUserLoginService _userLoginService;
        public RegisterForm()
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            _registerService = dependencyContainer.GetRegisterServiceInstance();
            _userLoginService = dependencyContainer.GetUserLoginServiceInstance();
        }

        /// <summary>
        /// Kullanıcı adının benzersiz olup olmadığını kontrol etmek için kullanılıyor.
        /// </summary>  
        private bool IsUsernameAlreadyTaken(IEnumerable<UserDto> users, string username)
        {
            return users.Any(user => user.Username == username);
        }


        /// <summary>
        /// Kullanıcının kayıt olma işlemi gerçekleştirildiğinde çalışan ve yeni kullanıcıyı oluşturan ana işlevi içeriyor.
        /// </summary>   
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string fullname = txtFullname.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var users = _userLoginService.GetUsers();

            if (IsUsernameAlreadyTaken(users, username))
            {
                MessageBox.Show("Kullanıcı adı zaten kayıtlı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AppUser newUser = new AppUser
            {
                Username = username,
                Fullname = fullname,
                Password = password,
            };

            _registerService.CreateUser(newUser);

            MessageBox.Show("Kullanıcı kaydı başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtPassword.Clear();
            txtFullname.Clear();
            txtUsername.Clear();

            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        /// <summary>
        ///  Kayıt formunu kapatıp giriş formunu açmak için kullanılıyor.
        /// </summary>     
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
