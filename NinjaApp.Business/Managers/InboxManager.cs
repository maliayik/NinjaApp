using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;

namespace NinjaApp.Business.Managers
{
    public class InboxManager : IInboxService
    {
        private readonly IInboxRepository _inboxRepository;

        public InboxManager()
        {
            _inboxRepository = new DataServiceRegistration().GetInboxRepositoryInstance();
        }

        /// <summary>
        /// Bu metot ınbox tablosuna yeni mesaj eklemeye yarar.
        /// </summary>       
        public void AddMessage(string message)
        {
            _inboxRepository.AddMessage(message);
        }

        /// <summary>
        /// Bu metot, gelen kutusundaki mesajların DTO temsilini oluşturarak ve bu mesajları bir liste halinde döndürerek iletişim verilerini sağlar.
        /// </summary>    
        public List<InboxDto> GetListAll()
        {
            var inboxDto = new List<InboxDto>();
            var messages = _inboxRepository.GetListAll();

            foreach (var message in messages)
            {
                var dto = new InboxDto();

                dto.Id = message.Id;
                dto.Description = message.Description;
                inboxDto.Add(dto);
            }
            return inboxDto;
        }
    }
}
