using NinjaApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Business.Services
{
    public interface ISuplierService
    {
        List<SupliersDto> GetSupliersByCategory(string categoryName);
    }
}
