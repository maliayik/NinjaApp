using NinjaApp.Entities;

namespace NinjaApp.Data.Interfaces
{
    public interface IReceiptRepository
    {
        List<Receipt> GetTopSellingReceipts(int count);
        List<Receipt> GetReceiptByUserId(int userId);
    }
}
