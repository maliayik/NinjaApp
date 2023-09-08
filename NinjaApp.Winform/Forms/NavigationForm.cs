using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class NavigationForm : Form
    {        
        private UserLoginDto _user;
        public NavigationForm(UserLoginDto userLoginDto)
        {
            InitializeComponent();
            _user = userLoginDto;
        }
    }
}
