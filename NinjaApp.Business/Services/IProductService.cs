using NinjaApp.DTOs;

namespace NinjaApp.Business.Services
{
    public interface IProductService
    {
        public List<ProductListDto> GetProductListDto();

        void IncreaseProductStock(string productName, int newStock);
        void DecreaseProductStock(string productName, int newStock);

    }
}
