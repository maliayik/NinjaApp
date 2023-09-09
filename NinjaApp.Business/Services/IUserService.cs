using NinjaApp.DTOs;

namespace NinjaApp.Business.Services
{
    public interface IUserService
    {
        UserDto GetUsersById(int id);
        List<ReceiptDto> GetReceiptByUserId(int userId);
        void UpdateUserBalance(int userId, decimal additionalBalance);
        void UpdateUserPassword(int userId, string password);
    }
}
