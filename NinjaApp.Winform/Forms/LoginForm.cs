using NinjaApp.Business;
using NinjaApp.Business.Services;
using NinjaApp.DTOs;

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

        /// <summary>
        /// Kullanıcı adı ve şifreyle giriş yapmayı deneyen kullanıcıyı doğrular ve kullanıcı veya admin olarak uygun formu açar veya yanlış giriş bilgilerini bildirir.
        /// </summary>     
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

        /// <summary>
        /// Giriş yapma formu kapatıldığında uygulamayı tamamen kapatır.
        /// </summary> 
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Kullanıcı kaydı oluşturmak için yeni bir kayıt formu açar ve mevcut giriş formunu gizler.
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }

        /// <summary>
        /// Uygulamayı kapatma işlemi için bir etiketi tıkladığınızda uygulamayı tamamen kapatır.
        /// </summary>    >
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
