using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VibeHive.Core.Interface;
using VibeHive.Core.Models;

namespace EventManagement.API.Controllers
{
    [ApiController]
    [Route("api/tickets")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _tickets;

        public TicketController(ITicketService tickets)
        {
            _tickets = tickets;
        }

        [Authorize]
        [HttpPost("{eventId}")]
        public IActionResult Purchase(int eventId)
        {
            int userId = int.Parse(User.FindFirst("Id").Value);

            var ticket = _tickets.PurchaseTicket(userId, eventId);

            if (ticket == null)
                return BadRequest("Event unavailable.");

            return Ok(ticket);
        }

        [Authorize]
        [HttpGet]
        public IActionResult MyTickets()
        {
            int userId = int.Parse(User.FindFirst("Id").Value);

            return Ok(_tickets.GetTicketsByUser(userId));
        }
    }
}
