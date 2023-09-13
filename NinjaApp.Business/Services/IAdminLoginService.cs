using NinjaApp.DTOs;

namespace NinjaApp.Business.Services
{
    public interface IAdminLoginService
    {
        AdminDto GetAdminLogin(string userName, string password);
    }
}
