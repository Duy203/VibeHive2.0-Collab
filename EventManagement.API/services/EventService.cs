using VibeHive.Core.Interface;
using VibeHive.Core.Models;
namespace EventManagement.API.services
{
    public class EventService : IEventService
    {
        private readonly List<Event> _events = new();
        private int _idCounter = 1;

        public Event CreateEvent(Event ev)
        {
            ev.Id = _idCounter++;
            _events.Add(ev);
            return ev;
        }

        public IEnumerable<Event> GetAll()
        {
            return _events;
        }

        public Event GetById(int id)
        {
            return _events.FirstOrDefault(e => e.Id == id);
        }

        public bool Delete(int id)
        {
            var ev = GetById(id);
            if (ev == null) return false;

            _events.Remove(ev);
            return true;
        }
    }
}
