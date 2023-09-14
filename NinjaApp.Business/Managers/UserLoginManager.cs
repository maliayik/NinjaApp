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

        /// <summary>
        /// Kullanıcı adı ve şifre ile kullanıcı giriş bilgilerini kontrol eder ve doğruysa kullanıcıyı DTO nesnesi olarak döndürür.
        /// </summary>   
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
                    Balance = UserLogin.Balance,
                };

                return userLoginDto;

            }

            return null;
        }

        /// <summary>
        /// Tüm kullanıcıların bilgilerini DTO nesneleri olarak alır.
        /// </summary>     
        public List<UserDto> GetUsers()
        {
            var dtoList = new List<UserDto>();
            var list = _userRepository.GetAllUsers();

            foreach (var user in list)
            {
                var dto = new UserDto();

                dto.Id = user.Id;
                dto.Username = user.Username;
                dto.Fullname = user.Fullname;
                dto.Balance = user.Balance;

                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}

