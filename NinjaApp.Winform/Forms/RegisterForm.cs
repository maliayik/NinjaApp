using NinjaApp.Business;
using NinjaApp.Business.Services;
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
        public RegisterForm()
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            _registerService = dependencyContainer.GetRegisterServiceInstance();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string fullname = txtFullname.Text;
            string password = txtPassword.Text;

            // Gerekli alanların boş olup olmadığını kontrol edin
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcı kaydını oluşturmak için RegisterService'i kullanın
            AppUser newUser = new AppUser
            {
                Username = username,
                Fullname = fullname,
                Password = password,
                // Diğer gerekli bilgileri buraya ekleyin
            };

            // Kullanıcı kaydını yapmak için RegisterService'i kullanın
            _registerService.CreateUser(newUser);

            MessageBox.Show("Kullanıcı kaydı başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Kayıt işlemi tamamlandığında formu temizleyin
            txtPassword.Clear();
            txtFullname.Clear();
            txtUsername.Clear();

            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
