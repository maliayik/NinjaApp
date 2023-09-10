using NinjaApp.Business;
using NinjaApp.Business.Services;
using NinjaApp.DTOs;

namespace NinjaApp.Winform.Forms
{
    public partial class AddMoneyForm : Form
    {
        private readonly IUserService _userService;

        public event EventHandler MoneyAdded;
        private UserLoginDto loggedInUser;


        int userId;
        public AddMoneyForm(UserLoginDto loggedInUser)
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            _userService = dependencyContainer.GetUserServiceInstance();


            if (loggedInUser != null)
            {
                userId = loggedInUser.Id;
            }

        }

        private void AddMoneyForm_Load(object sender, EventArgs e)
        {


        }


        /// <summary>
        /// Bu metot kullanıcının girmiş oldugu yeni bakiye değerini eklemek için tasarlandı.
        /// </summary>      
        private void btnAddedMoney_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmound.Text) && decimal.TryParse(txtAmound.Text, out decimal amount))
            {
                _userService.UpdateUserBalance(userId, amount);
                MessageBox.Show(this, "Bakiye güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MoneyAdded?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir bakiye giriniz.");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }        
    }
}
