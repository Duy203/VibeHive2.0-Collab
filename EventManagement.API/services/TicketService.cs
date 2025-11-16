using VibeHive.Core.Interface;
using VibeHive.Core.Models;
namespace EventManagement.API.services
{
    public class TicketService : ITicketService
    {
        private readonly List<Ticket> _tickets = new();
        private readonly IEventService _eventService;
        private int _idCounter = 1;

        public TicketService(IEventService eventService)
        {
            _eventService = eventService;
        }

        public Ticket PurchaseTicket(int userId, int eventId)
        {
            var ev = _eventService.GetById(eventId);
            if (ev == null || ev.TicketsAvailable <= 0)
                return null;

            ev.TicketsAvailable--;

            var ticket = new Ticket
            {
                Id = _idCounter++,
                UserId = userId,
                EventId = eventId
            };

            _tickets.Add(ticket);
            return ticket;
        }

        public IEnumerable<Ticket> GetTicketsByUser(int userId)
        {
            return _tickets.Where(t => t.UserId == userId);
        }
    }
}
