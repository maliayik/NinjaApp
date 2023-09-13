using NinjaApp.Business;
using NinjaApp.Business.Services;
using NinjaApp.DTOs;

namespace NinjaApp.Winform.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private readonly IUserService _userService;
        public event EventHandler ChangePassword;
        private UserLoginDto loggedInUser;

        //değişecek giriş yapan kullanıcıya göre bu form açılacak.
        int userId;

        public ChangePasswordForm(UserLoginDto loggedInUser)
        {
            InitializeComponent();
            var dependencyCotainer = new BusinessServiceRegistration();
            _userService = dependencyCotainer.GetUserServiceInstance();

            if (loggedInUser != null)
            {
                userId = loggedInUser.Id;
            }
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Bu metot, kullanıcının şifresini değiştirmesini ve değişiklikleri uyguladığında bir bilgi iletişim kutusu göstermesini sağlar.
        /// </summary>    
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            if (!string.IsNullOrEmpty(newPassword) && newPassword == confirmPassword)
            {

                // Şifre güncelleme işlemini yapmak için _userService.UpdateUserPassword metodu kullanılır.
                _userService.UpdateUserPassword(userId, newPassword);

                // Kullanıcıya bilgi ver
                MessageBox.Show(this, "Şifre güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangePassword?.Invoke(this, EventArgs.Empty);

            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor veya alanlar boş bırakıldı.");
            }
        }
    }
}
