using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VibeHive.Common.DTOs
{
    public class AddSongDto
    {
        public string Title { get; set; } = "";
        public string Artist { get; set; } = "";
        public string Genre { get; set; } = "";
        public int Duration { get; set; }
    }
}
