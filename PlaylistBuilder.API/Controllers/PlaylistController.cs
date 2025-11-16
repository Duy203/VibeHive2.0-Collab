using Microsoft.AspNetCore.Mvc;
using VibeHive.Core.Interface;
using VibeHive.Common.DTOs;
using VibeHive.Core.Models;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
namespace PlaylistBuilder.API.Controllers
{
    [ApiController]
    [Route("api/playlists")]
    public class PlaylistController : ControllerBase
    {
        private readonly IPlaylistService _service;
        public PlaylistController(IPlaylistService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreatePlaylistDto dto)
        {
            var playlist = _service.CreatePlaylist(dto.Name, dto.CreateBy, dto.IsCollab);
            return Ok(playlist);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var playlists = _service.GetAllPlaylists();
            return Ok(playlists);
        }

        [HttpPut("{id}/add")]
        public IActionResult AddSong(int id, [FromBody] AddSongDto dto)
        {
            var song = new Song
            {
                Title = dto.Title,
                Artist = dto.Artist,
                Genre = dto.Genre,
                Duration = dto.Duration
            };

            var updated = _service.AddSong(id, song);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpPut("{id}/invite")]
        public IActionResult Invite(int id, [FromBody] InviteDto dto)
        {
            var updated = _service.InviteCollaborator(id, dto.UserId);
            return Ok(updated);
        }

        [HttpPost("{id}/vote")]
        public IActionResult Vote(int id, [FromBody] VoteDto dto)
        {
            var song = _service.VoteSong(id, dto.SongId);
            if (song == null) return NotFound(); return Ok(song);
        }

        [HttpGet("{id}/rankings")]
        public IActionResult Rankings(int id)
        {
            var list = _service.GetRankings(id);
            return Ok(list);
        }
    }
}
