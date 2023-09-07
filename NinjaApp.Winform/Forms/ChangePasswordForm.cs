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
    public partial class ChangePasswordForm : Form
    {
        private readonly IUserService _userService;
        public event EventHandler ChangePassword;

        //değişecek giriş yapan kullanıcıya göre bu form açılacak.
        int userId = 1;

        public ChangePasswordForm()
        {
            InitializeComponent();
            var dependencyCotainer = new BusinessServiceRegistration();
            _userService = dependencyCotainer.GetUserServiceInstance();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            if (!string.IsNullOrEmpty(newPassword) && newPassword == confirmPassword)
            {
                
                // userId değişkenini kullanmak isterseniz, burada userId'i alabilirsiniz.

                // Şifre güncelleme işlemini yapmak için _userService.UpdateUserPassword metodu kullanılır.
                _userService.UpdateUserPassword(userId, newPassword);

                // Şifre güncellendiğinde ChangePassword olayını tetikleyebilirsiniz.
                

                // Kullanıcıya bilgi ver
                MessageBox.Show(this, "Şifre güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangePassword?.Invoke(this, EventArgs.Empty);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor veya alanlar boş bırakıldı.");
            }
        }
    }
}
