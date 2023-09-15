using NinjaApp.Entities;

namespace NinjaApp.Data.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        void UpdateProductPrice(int productId, decimal newPrice);
        List<Product> GetProductsByCategory(string categoryName);

        void IncreaseProductStock(string productName, int newStock);
        void DecreaseProductStock(string productName, int newStock);
    }
}
