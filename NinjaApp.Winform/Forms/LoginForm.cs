using NinjaApp.Business;
using NinjaApp.Business.Services;
using NinjaApp.DTOs;

namespace NinjaApp.Winform.Forms
{
    public partial class LoginForm : Form
    {
        private UserLoginDto _user;
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

            // Kullanıcı adı ve şifre alanlarını kontrol edin
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                // Kullanıcıyı giriş yapmaya çalışın
                _user = _userLoginService.GetUserLogin(userName, password);

                if (_user != null)
                {
                    // Kullanıcı adı ve şifre doğruysa
                    ShoppingForm form = new ShoppingForm(); // NavigationForm'u kullanıcı nesnesiyle oluşturun
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
