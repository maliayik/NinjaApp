﻿using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;
using NinjaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Business.Managers
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IReceiptRepository _receiptRepository;

        public UserManager()
        {
            _userRepository = new DataServiceRegistration().GetUserRepositoryInstance();
            _receiptRepository=new DataServiceRegistration().GetReceiptRepositoryInstance();
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
                    FisNo = receipt.ReceiptNo,
                    Total = receipt.Total,
                    UserId = receipt.UserId
                };
               
                receiptDto.ToplamTutar=$"{receiptDto.Total}TL";
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

        public void UpdateUserPassword(int userId, string password)
        {
            AppUser user = _userRepository.GetAppUserById(userId);

            if (user != null)
            {
                user.Id = userId;
                user.Password = password;
                
                _userRepository.UpdateUserPassword(userId,password);
            }
        }
    }
}
