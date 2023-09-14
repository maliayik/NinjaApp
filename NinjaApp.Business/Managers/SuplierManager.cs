using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;

namespace NinjaApp.Business.Managers
{
    public class SuplierManager : ISuplierService
    {

        private readonly ISuplierRepository _suplierRepository;

        public SuplierManager()
        {
            _suplierRepository = new DataServiceRegistration().GetSuplierRepositoryInstance();
        }

        /// <summary>
        /// Belirli bir kategoriye ait tedarikçi ürünlerini DTO nesneleri olarak alır.
        /// </summary>   
        public List<SupliersDto> GetSupliersByCategory(string categoryName)
        {
            var dtoList = new List<SupliersDto>();

            var supliers = _suplierRepository.GetSupliersByCategory(categoryName);

            foreach (var suplier in supliers)
            {

                if (suplier.CategoryName.Equals(categoryName, StringComparison.OrdinalIgnoreCase))
                {
                    var dto = new SupliersDto();

                    dto.Ürünler = suplier.ProductName;
                    dto.Kategori = suplier.CategoryName;
                    dto.Birim = suplier.Unit;
                    dto.Fiyat = suplier.Price;
                    dto.Stok = suplier.Stock;
                    dto.CategoryId = suplier.CategoryId;

                    dtoList.Add(dto);
                }
            }

            return dtoList;

        }
    }
}
