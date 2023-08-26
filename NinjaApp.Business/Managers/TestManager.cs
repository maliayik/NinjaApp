using NinjaApp.Business.Interfaces;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;
using NinjaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Business.Managers
{
    public class TestManager : ITestService
    {
        private readonly ITestRepository testRepository;

        public TestManager()
        {
            testRepository = new DataServiceRegistration().GetTestRepositoryInstance();
        }
               
             

        public List<TestListDto> GetTestListDtos()
        {
            var dtoList = new List<TestListDto>();

            var list = testRepository.GetProducts();

            foreach(var product in list)
            {
                var dto = new TestListDto();

                dto.Id= product.Id;
                dto.Product = product.ProductName;

                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}
