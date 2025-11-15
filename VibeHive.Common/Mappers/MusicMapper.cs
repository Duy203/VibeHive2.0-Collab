using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VibeHive.Common.DTOs;
using VibeHive.Core.Models;


namespace VibeHive.Common.Mappers
{
    public static class MusicMapper
    {
        public static Music ToModel(this MusicDto dto)
        {
            return new Music
            {
                Title = dto.Title,
                Artist = dto.Artist,
                Genre = dto.Genre,
                Year = dto.Year,
                IsAvailable = true
            };
        }
    }
}
