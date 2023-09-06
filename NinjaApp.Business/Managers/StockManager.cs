using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;

namespace NinjaApp.Business.Managers
{
    public class StockManager : IStockService
    {
        private readonly IProductRepository _productRepository;

        public StockManager()
        {
            _productRepository = new DataServiceRegistration().GetProductRepositoryInstance();
        }



        public List<StockDto> GetStockListDto()
        {

            var dtoList = new List<StockDto>();

            var list = _productRepository.GetProducts();

            foreach (var product in list)
            {
                var dto = new StockDto();

                dto.Ürünler = product.ProductName;
                dto.Stok = product.Stock;

                dtoList.Add(dto);
            }

            return dtoList;

        }
    }
}
