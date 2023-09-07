using NinjaApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
