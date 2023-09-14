using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;

namespace NinjaApp.Business.Managers
{
    public class ShoppingManager : IShoppingService
    {
        private readonly IProductRepository _productRepository;

        public ShoppingManager()
        {
            _productRepository = new DataServiceRegistration().GetProductRepositoryInstance();
        }

        /// <summary>
        /// Belirli bir kategoriye ait alışveriş ürünlerini DTO nesneleri olarak alır.
        /// </summary>     
        public List<ShoppingDto> GetShoppingProductByCategoryWithDto(string categoryName)
        {
            var dtoList = new List<ShoppingDto>();

            var products = _productRepository.GetProducts();

            foreach (var product in products)
            {

                if (product.CategoryName.Equals(categoryName, StringComparison.OrdinalIgnoreCase))
                {
                    var dto = new ShoppingDto();

                    dto.Id = product.Id;
                    dto.Ürünler = product.ProductName;
                    dto.Kategori = product.CategoryName;
                    dto.Birim = product.Unit;
                    dto.Fiyat = product.Price;
                    dto.Adet = product.Stock;

                    dtoList.Add(dto);
                }
            }

            return dtoList;

        }

        /// <summary>
        ///  Tüm alışveriş ürünlerini DTO nesneleri olarak alır.
        /// </summary>    
        public List<ShoppingDto> GetShoppingProductWithDto()
        {
            var dtoList = new List<ShoppingDto>();

            var list = _productRepository.GetProducts();

            foreach (var product in list)
            {
                var dto = new ShoppingDto();

                dto.Id = product.Id;
                dto.Ürünler = product.ProductName;
                dto.Kategori = product.CategoryName;
                dto.Birim = product.Unit;
                dto.Fiyat = product.Price;
                dto.Adet = product.Stock;

                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}
