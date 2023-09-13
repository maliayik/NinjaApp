using NinjaApp.Entities;

namespace NinjaApp.Data.Interfaces
{
    public interface IAdminRepository
    {
        Admin GetAdminLogin(string userName, string password);
    }
}
