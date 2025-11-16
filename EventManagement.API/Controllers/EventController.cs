using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VibeHive.Common.DTOs;
using VibeHive.Core.Interface;
using VibeHive.Core.Models;

namespace EventManagement.API.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _service;

        public EventController(IEventService service)
        {
            _service = service;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(EventDto dto)
        {
            var ev = new Event
            {
                Title = dto.Title,
                Description = dto.Description,
                Date = dto.Date,
                TicketsAvailable = dto.TicketsAvailable
            };

            return Ok(_service.CreateEvent(ev));
        }

        [HttpGet]
        public IActionResult All()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetById(id));
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool ok = _service.Delete(id);
            return ok ? Ok("Deleted") : NotFound();
        }
    }
}
