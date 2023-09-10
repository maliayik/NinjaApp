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


        public void UpdateUserBalance(int userId, decimal additionalBalance)
        {

            AppUser user = _userRepository.GetAppUserById(userId);

            if (user != null)
            {
                decimal currentBalance = user.Balance;

                if (additionalBalance >= 0)
                {
                    // Bakiye artırma işlemi
                    decimal newBalance = currentBalance + additionalBalance;
                    user.Balance = newBalance;

                    _userRepository.UpdateUserBalance(userId, newBalance);
                }
                else if (currentBalance >= Math.Abs(additionalBalance))
                {
                    // Bakiye azaltma işlemi
                    decimal newBalance = currentBalance - Math.Abs(additionalBalance);
                    user.Balance = newBalance;

                    _userRepository.UpdateUserBalance(userId, newBalance);

                    //AppUser user = _userRepository.GetAppUserById(userId);

                    //if (user != null)
                    //{
                    //    decimal currentBalance = user.Balance;
                    //    decimal newBalance = currentBalance + additionalBalance;

                    //    user.Balance = newBalance;
                    //    _userRepository.UpdateUserBalance(userId, newBalance);
                    //}
                }
            }
        }
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
                            Toplam = receipt.Total,
                            UserId = receipt.UserId
                        };

                        receiptDto.ToplamTutar = $"{receiptDto.Toplam}TL";
                        receiptDtos.Add(receiptDto);
                    }

                    return receiptDtos;
                }

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
