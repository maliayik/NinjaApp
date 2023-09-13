using NinjaApp.DTOs;

namespace NinjaApp.Business.Services
{
    public interface IInboxService
    {
        List<InboxDto> GetListAll();
        void AddMessage(string message);
    }
}
