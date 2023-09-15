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

        /// <summary>
        /// Ürünün stok miktarını günceller.
        /// </summary>   
        public void IncreaseProductStock(string productName, int newStock)
        {

            Product product = new Product();
            product.ProductName = productName;

            if (product != null)
            {
                product.Stock += newStock;
                _productRepository.IncreaseProductStock(product.ProductName, product.Stock);

            }
        }

        /// <summary>
        /// Ürünlerin listesini DTO nesneleri olarak alır.
        /// </summary>  
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

        public void DecreaseProductStock(string productName, int newStock)
        {
            Product product = new Product();
            product.ProductName = productName;

            if (product != null)
            {
                product.Stock += newStock;
                _productRepository.IncreaseProductStock(product.ProductName, product.Stock);

            }
        }
    }
}
