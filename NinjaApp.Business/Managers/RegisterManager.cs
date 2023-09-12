using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Business.Managers
{
    public class RegisterManager : IRegisterService
    {
        private readonly IUserRepository _userRepository;
        public RegisterManager()
        {
            _userRepository=new DataServiceRegistration().GetUserRepositoryInstance();
            
        }
        public void CreateUser(AppUser user)
        { 
            _userRepository.CreateUser(user);
        }
    }
}
