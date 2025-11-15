using Microsoft.AspNetCore.Mvc;
using VibeHive.Common.DTOs;
using VibeHive.Core.Interface;
namespace MusicRental.API.Controllers
{
    public class RentalController : ControllerBase
    {
        private readonly IRentalService _service;

        public RentalController (IRentalService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult RentAlbum([FromBody] RentAlbumDto dto)
        {
            var rental = _service.RentAlbum(dto.UserId, dto.AlbumId);
            if(rental == null)
            {
                return BadRequest("Album Unavailable for Rent");
            }
            return Ok(rental);
        }

        [HttpPost("{id}/return")]
        public IActionResult ReturnAlbum(int id)
        {
           var success = _service.ReturnAlbum(id);
            if (!success)
            {
                return BadRequest("Rental not found or already returned");
            }
            return Ok(new { message = "Album Returned Successfully" });
        }

        [HttpGet]
        public IActionResult GetActive()
        {
            var rentals = _service.GetActiveRentals();
            return Ok(rentals);
        }
    }
}
