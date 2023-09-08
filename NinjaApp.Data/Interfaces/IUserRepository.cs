using NinjaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Data.Interfaces
{
    public interface IUserRepository
    {
        AppUser GetUserLogin(string userName, string password);
        AppUser GetAppUserById(int id);

        void UpdateUserBalance(int userId,decimal balance);

        void UpdateUserPassword(int userId,string password);
               

    }
}
