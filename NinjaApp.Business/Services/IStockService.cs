using NinjaApp.DTOs;

namespace NinjaApp.Business.Services
{
    public interface IStockService
    {
        public List<StockDto> GetStockListDto();
    }
}
