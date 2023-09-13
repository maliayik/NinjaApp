using NinjaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Data.Interfaces
{
    public interface IInboxRepository
    {
        List<InBox> GetListAll();
        void AddMessage(string message);
    }
}
