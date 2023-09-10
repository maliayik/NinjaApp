using NinjaApp.Business;
using NinjaApp.Business.Services;
using NinjaApp.DTOs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NinjaApp.Winform.Forms
{
    public partial class LoginForm : Form
    {
        private UserLoginDto _user;
        private AdminDto _admin;
        private readonly IUserLoginService _userLoginService;
        private readonly IAdminLoginService _adminLoginService;

        public LoginForm()
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            _userLoginService = dependencyContainer.GetUserLoginServiceInstance();
            _adminLoginService = dependencyContainer.GetAdminLoginServiceInstance();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPass.Text;

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                // Kullanıcıyı giriş yapmaya çalışın
                _user = _userLoginService.GetUserLogin(userName, password);
                _admin = _adminLoginService.GetAdminLogin(userName, password);

                if (_user != null)
                {

                    ShoppingForm form = new ShoppingForm(_user);
                    form.Show();
                    this.Hide();
                }
                else if (_admin != null)
                {
                    // Admin girişi doğruysa
                    AdminForm adminForm = new AdminForm(_admin);
                    adminForm.Show();
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
