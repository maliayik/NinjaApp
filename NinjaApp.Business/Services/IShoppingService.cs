using NinjaApp.DTOs;

namespace NinjaApp.Business.Services
{
    public interface IShoppingService
    {
        List<ShoppingDto> GetShoppingProductWithDto();
        List<ShoppingDto> GetShoppingProductByCategoryWithDto(string categoryName);
    }
}
