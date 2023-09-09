using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;

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
                    Password = UserLogin.Password,
                    Fullname = UserLogin.Fullname,
                    Balance= UserLogin.Balance,
                };

                return userLoginDto;

            }

            return null;
        }
    }
}

