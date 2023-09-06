﻿using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;

namespace NinjaApp.Business.Managers
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductManager()
        {
            _productRepository = new DataServiceRegistration().GetProductRepositoryInstance();
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
