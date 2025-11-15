using Microsoft.AspNetCore.Mvc;
using VibeHive.Common.DTOs;
using VibeHive.Common.Mappers;
using VibeHive.Core.Interface;
namespace MusicRental.API.Controllers
{
    [ApiController]
    [Route("api/music")]
    public class MusicController : ControllerBase
    {
        private readonly IMusicService _service;

        public MusicController (IMusicService service)
        {
            _service = service;
        }

        //add music
        [HttpPost]
        public IActionResult AddMusic([FromBody] MusicDto dto)
        {
            var music = dto.ToModel();
            var created = _service.AddMusic(music);
            return Ok(created);
        }

        //Gett all music
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAllMusic());
        }

        //delete music
        public IActionResult Delete (int id)
        {
            bool result = _service.DeleteMusic(id);
            if (!result)
            {
                return NotFound();
            }
            return Ok(new { message = "Deleted" });
        }
    }
}
