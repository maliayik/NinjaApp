using NinjaApp.DTOs;

namespace NinjaApp.Business.Services
{
    public interface IUserLoginService
    {
        UserLoginDto GetUserLogin(string userName, string password);
    }
}
