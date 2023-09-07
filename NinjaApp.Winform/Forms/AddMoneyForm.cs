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
    public partial class AddMoneyForm : Form
    {
        private readonly IUserService _userService;

        public event EventHandler MoneyAdded;

        //değişecek giriş yapan kullanıcıya göre bu form açılacak.
        int userId = 1;
        public AddMoneyForm()
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            _userService = dependencyContainer.GetUserServiceInstance();

        }

        private void AddMoneyForm_Load(object sender, EventArgs e)
        {


        }


        /// <summary>
        /// Bu metot kullanıcının girmiş oldugu yeni bakiye değerini eklemek için tasarlandı.
        /// </summary>      
        private void btnAddedMoney_Click(object sender, EventArgs e) 
        {
           
            if(!string.IsNullOrEmpty(txtAmound.Text))
            {
                decimal amount = decimal.Parse(txtAmound.Text); 

                _userService.UpdateUserBalance(userId, amount);

                MessageBox.Show (this, "Bakiye güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MoneyAdded?.Invoke(this, EventArgs.Empty);
                this.Close();
            }

            else
            {
                MessageBox.Show("Lütfen bakiye giriniz..");
            }
           
        }
    }
}
