using NinjaApp.DTOs;
using NinjaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Business.Interfaces
{
    public interface ITestService
    {
        public List<TestListDto> GetTestListDtos();
    }
}
