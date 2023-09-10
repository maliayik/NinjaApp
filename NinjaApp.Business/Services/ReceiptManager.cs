using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;
using NinjaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Business.Services
{
    public class ReceiptManager : IReceiptService
    {
        private readonly IReceiptRepository _receiptRepository;

        public ReceiptManager()
        {
            _receiptRepository = new DataServiceRegistration().GetReceiptRepositoryInstance();
        }
        public void AddReceipt(ReceiptDto receiptDto)
        {
            Receipt receipt = new Receipt
            {
                ProductName = receiptDto.Ürünler,
                PurchaseDate = receiptDto.Tarih,
                Total = receiptDto.Toplam,
                UserId = receiptDto.UserId,
            };

            _receiptRepository.AddReceipt(receipt);
        }
    }
}
