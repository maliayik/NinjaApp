using NinjaApp.Entities;

namespace NinjaApp.Data.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        void UpdateProduct(int productId, decimal newPrice);
    }
}
