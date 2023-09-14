using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.Entities;

namespace NinjaApp.Business.Managers
{
    public class RegisterManager : IRegisterService
    {
        private readonly IUserRepository _userRepository;
        public RegisterManager()
        {
            _userRepository = new DataServiceRegistration().GetUserRepositoryInstance();

        }
        /// <summary>
        /// Yeni bir kullanıcı oluşturmayı sağlar.
        /// </summary>
        public void CreateUser(AppUser user)
        {
            _userRepository.CreateUser(user);
        }
    }
}
