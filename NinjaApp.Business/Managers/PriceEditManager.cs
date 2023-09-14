using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;

namespace NinjaApp.Business.Managers
{
    public class PriceEditManager : IPriceEditService
    {
        private readonly IProductRepository _productRepository;

        public PriceEditManager()
        {
            _productRepository = new DataServiceRegistration().GetProductRepositoryInstance();
        }

        /// <summary>
        /// Bu metot, ürünlerin fiyatlarını düzenlemek için kullanılacak verileri DTO nesneleri olarak alır.
        /// </summary>    
        public List<PriceEditDto> GetPriceEditDtos()
        {
            var dtoList = new List<PriceEditDto>();

            var list = _productRepository.GetProducts();

            foreach (var product in list)
            {
                var dto = new PriceEditDto();

                dto.Id = product.Id;
                dto.Ürünler = product.ProductName;
                dto.Birim = product.Unit;
                dto.Fiyat = product.Price;

                dtoList.Add(dto);
            }

            return dtoList;
        }

        /// <summary>
        ///  Bu metot, seçilen bir ürünün fiyatını güncellemek için kullanılır.
        /// </summary>     
        public void UpdatePriceEdit(PriceEditDto priceEditDto)
        {
            int productId = priceEditDto.Id;
            decimal newPrice = priceEditDto.Fiyat;

            _productRepository.UpdateProductPrice(productId, newPrice);
        }
    }
}
