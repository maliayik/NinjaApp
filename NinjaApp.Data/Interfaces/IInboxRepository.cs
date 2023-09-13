using NinjaApp.Entities;

namespace NinjaApp.Data.Interfaces
{
    public interface IInboxRepository
    {
        List<InBox> GetListAll();
        void AddMessage(string message);
    }
}
