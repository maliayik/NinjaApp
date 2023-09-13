﻿using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;

namespace NinjaApp.Business.Managers
{
    public class AdminLoginManager : IAdminLoginService
    {
        private readonly IAdminRepository _adminRepository;


        public AdminLoginManager()
        {
            _adminRepository = new DataServiceRegistration().GetAdminRepositoryInstance();
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
                    Fullname = adminLogin.Fullname,

                };

                return adminLoginDto;

            }

            return null;
        }
    }
}
