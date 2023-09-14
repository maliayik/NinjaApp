using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;
using NinjaApp.Entities;

namespace NinjaApp.Business.Managers
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IReceiptRepository _receiptRepository;

        public UserManager()
        {
            _userRepository = new DataServiceRegistration().GetUserRepositoryInstance();
            _receiptRepository = new DataServiceRegistration().GetReceiptRepositoryInstance();
        }

        /// <summary>
        /// Kullanıcının bakiyesini ödeme sonrası günceller.
        /// </summary>        
        public void UpdateUserBalanceAfterPayment(int userId, decimal newBalance)
        {
            _userRepository.UpdateUserBalanceAfterPayment(userId, newBalance);
        }

        /// <summary>
        /// Kullanıcının bakiyesini belirtilen miktarla günceller.
        /// </summary>    
        public void UpdateUserBalance(int userId, decimal additionalBalance)
        {


            AppUser user = _userRepository.GetAppUserById(userId);

            if (user != null)
            {
                decimal currentBalance = user.Balance;
                decimal newBalance = currentBalance + additionalBalance;

                user.Balance = newBalance;
                _userRepository.UpdateUserBalance(userId, newBalance);
            }
        }

        /// <summary>
        /// Belirli bir kullanıcının satın aldığı ürünlerin alışveriş fişlerini alır ve DTO nesneleri olarak döndürür.
        /// </summary>
        public List<ReceiptDto> GetReceiptByUserId(int userId)
        {
            var user = _userRepository.GetAppUserById(userId);
            var receipts = _receiptRepository.GetReceiptByUserId(userId);

            var receiptDtos = new List<ReceiptDto>();

            foreach (var receipt in receipts)
            {
                var receiptDto = new ReceiptDto
                {
                    Id = receipt.Id,
                    Ürünler = receipt.ProductName,
                    Tarih = receipt.PurchaseDate,
                    Birim = receipt.Unit,
                    Toplam = receipt.Total,
                    UserId = receipt.UserId
                };

                receiptDto.ToplamTutar = $"{receiptDto.Toplam}TL";
                receiptDtos.Add(receiptDto);
            }

            return receiptDtos;
        }

        /// <summary>
        /// Belirli bir kullanıcının bilgilerini alır ve DTO nesnesi olarak döndürür.
        /// </summary>
        public UserDto GetUsersById(int id)
        {
            var appUseR = _userRepository.GetAppUserById(id);


            if (appUseR != null)
            {
                var userDto = new UserDto
                {
                    Id = appUseR.Id,
                    Fullname = appUseR.Fullname,
                    Username = appUseR.Username,
                    Balance = appUseR.Balance,
                    ReceiptId = appUseR.ReceiptId,
                };
                return userDto;
            }

            else
            {

                return null;
            }
        }


        /// <summary>
        /// Kullanıcının şifresini günceller.
        /// </summary>
        public void UpdateUserPassword(int userId, string password)
        {
            AppUser user = _userRepository.GetAppUserById(userId);

            if (user != null)
            {
                user.Id = userId;
                user.Password = password;

                _userRepository.UpdateUserPassword(userId, password);
            }
        }


    }
}
