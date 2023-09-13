using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Business.Managers
{
    public class InboxManager : IInboxService
    {
        private readonly IInboxRepository _inboxRepository;

        public InboxManager()
        {
            _inboxRepository = new DataServiceRegistration().GetInboxRepositoryInstance();
        }

        public void AddMessage(string message)
        {
            _inboxRepository.AddMessage(message);
        }

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
