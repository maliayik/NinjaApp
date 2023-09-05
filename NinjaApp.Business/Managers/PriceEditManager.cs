using NinjaApp.Business.Services;
using NinjaApp.Data.Interfaces;
using NinjaApp.Data;
using NinjaApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinjaApp.Entities;

namespace NinjaApp.Business.Managers
{
    public class PriceEditManager : IPriceEditService
    {
        private readonly IProductRepository _productRepository;

        public PriceEditManager()
        {
            _productRepository = new DataServiceRegistration().GetProductRepositoryInstance();
        }

        public List<PriceEditDto> GetPriceEditDtos()
        {
            var dtoList = new List<PriceEditDto>();

            var list = _productRepository.GetProducts();

            foreach (var product in list)
            {
                var dto = new PriceEditDto();

                dto.Id=product.Id;
                dto.Ürünler = product.ProductName;
                dto.Birim = product.Unit;
                dto.Fiyat = product.Price;

                dtoList.Add(dto);
            }

            return dtoList;
        }

        public void UpdatePriceEditDtos(PriceEditDto priceEditDto)
        {
            int productId = priceEditDto.Id;
            decimal newPrice = priceEditDto.Fiyat;

            _productRepository.UpdateProduct(productId,newPrice);
        }
    }
}
