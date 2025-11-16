using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VibeHive.Core.Models;

namespace VibeHive.Core.Interface
{
    public interface IEventService
    {
        Event CreateEvent(Event ev);
        IEnumerable<Event> GetAll();
        Event GetById(int id);
        bool Delete(int id);
    }
}
