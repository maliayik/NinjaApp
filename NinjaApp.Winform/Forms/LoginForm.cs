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
    public partial class LoginForm : Form
    {

        private readonly IUserLoginService _userLoginService;

        public LoginForm()
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            _userLoginService = dependencyContainer.GetUserLoginServiceInstance();
        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPass.Text;
            string adminName = txtUserName.Text;
            string adminPassword = txtPass.Text;


            // Kullanıcı adı ve şifre alanlarını kontrol edin
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                // Kullanıcıyı giriş yapmaya çalışın
                var user = _userLoginService.GetUserLogin(userName, password);

                if (user != null)
                {
                    // Kullanıcı adı ve şifre doğruysa
                    NavigationForm form = new NavigationForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanlarını doldurun.");
            }
        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
