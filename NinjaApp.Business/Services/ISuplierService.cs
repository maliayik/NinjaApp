using NinjaApp.DTOs;

namespace NinjaApp.Business.Services
{
    public interface ISuplierService
    {
        List<SupliersDto> GetSupliersByCategory(string categoryName);
    }
}
