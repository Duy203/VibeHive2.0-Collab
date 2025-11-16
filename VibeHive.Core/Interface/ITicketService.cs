using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VibeHive.Core.Models;

namespace VibeHive.Core.Interface
{
    public interface ITicketService
    {
        Ticket PurchaseTicket(int userId, int eventId);
        IEnumerable<Ticket> GetTicketsByUser(int userId);
    }
}
