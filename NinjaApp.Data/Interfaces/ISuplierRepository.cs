using NinjaApp.Entities;

namespace NinjaApp.Data.Interfaces
{
    public interface ISuplierRepository
    {
        List<Supliers> GetSupliersByCategory(string categoryName);
    }
}
