using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.Data.Repositories;
using NinjaApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Business.Managers
{
    public class AdminLoginManager : IAdminLoginService
    {
        private readonly IAdminRepository _adminRepository;


        public AdminLoginManager()
        {
            _adminRepository=new DataServiceRegistration().GetAdminRepositoryInstance();
        }

        public AdminDto GetAdminLogin(string userName, string password)
        {
            var adminLogin = _adminRepository.GetAdminLogin(userName, password);

            if (adminLogin != null)
            {
                var adminLoginDto = new AdminDto
                {
                    Id = adminLogin.Id,
                    Username = adminLogin.Username,
                    Password = adminLogin.Password,
                    Fullname= adminLogin.Fullname,
                    
                };

                return adminLoginDto;

            }

            return null;
        }
    }
}
