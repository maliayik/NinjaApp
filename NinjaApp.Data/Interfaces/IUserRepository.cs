using NinjaApp.Entities;

namespace NinjaApp.Data.Interfaces
{
    public interface IUserRepository
    {
        AppUser GetUserLogin(string userName, string password);
        AppUser GetAppUserById(int id);

        void UpdateUserBalance(int userId, decimal balance);

        void UpdateUserPassword(int userId, string password);


    }
}
