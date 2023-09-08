using NinjaApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Business.Services
{
    public interface IShoppingService
    {
        List<ShoppingDto> GetShoppingProductWithDto();
        List<ShoppingDto> GetShoppingProductByCategoryWithDto(string categoryName);
    }
}
