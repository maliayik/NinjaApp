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
    public class UserLoginManager : IUserLoginService
    {
        private readonly IUserRepository _userRepository;

        public UserLoginManager()
        {
            _userRepository = new DataServiceRegistration().GetUserRepositoryInstance();
        }

        public UserLoginDto GetUserLogin(string userName, string password)
        {
            var UserLogin = _userRepository.GetUserLogin(userName, password);

            if (UserLogin != null)
            {
                var userLoginDto = new UserLoginDto
                {
                    Id = UserLogin.Id,
                    UserName = UserLogin.Username,
                    Password = UserLogin.Password
                };

                return userLoginDto;

            }

            return null;
        }
    }
}

