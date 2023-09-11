using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.Data.Repositories;
using NinjaApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Business.Managers
{
    public class SuplierManager : ISuplierService
    {

        private readonly ISuplierRepository _suplierRepository;

        public SuplierManager()
        {
            _suplierRepository=new DataServiceRegistration().GetSuplierRepositoryInstance();
        }

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
                    dto.CategoryId=suplier.CategoryId;

                    dtoList.Add(dto);
                }
            }

            return dtoList;

        }
    }
}
