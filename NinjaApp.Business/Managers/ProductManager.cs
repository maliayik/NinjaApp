using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;
using NinjaApp.Entities;

namespace NinjaApp.Business.Managers
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductManager()
        {
            _productRepository = new DataServiceRegistration().GetProductRepositoryInstance();
        }

        public void UpdateProductStock(string productName, int newStock)
        {
            // Ürünü zaten aldığınızı varsayalım, product parametresini kullanabilirsiniz
            Product product = new Product();
            product.ProductName = productName;

            if (product != null)
            {
                // Alınan stok miktarını mevcut stok miktarına ekleyin
                product.Stock += newStock;

                // Ürünün stok miktarını güncellemek için UpdateProductStock metodunu kullanın
                _productRepository.UpdateProductStock(product.ProductName, product.Stock);

            }
        }


        public List<ProductListDto> GetProductListDto()
        {
            var dtoList = new List<ProductListDto>();

            var list = _productRepository.GetProducts();

            foreach (var product in list)
            {
                var dto = new ProductListDto();

                dto.Id = product.Id;
                dto.ProductName = product.ProductName;
                dto.CategoryName = product.CategoryName;
                dto.Unit = product.Unit;
                dto.Price = product.Price;
                dto.Stock = product.Stock;

                dtoList.Add(dto);
            }

            return dtoList;
        }

      
    }
}
