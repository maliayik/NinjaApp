using NinjaApp.DTOs;

namespace NinjaApp.Business.Services
{
    public interface IProductService
    {
        public List<ProductListDto> GetProductListDto();

        void UpdateProductStock(string productName, int newStock);

    }
}
