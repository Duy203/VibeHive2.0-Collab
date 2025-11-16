using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VibeHive.Common.DTOs
{
    public class CreatePlaylistDto
    {
        public string Name { get; set; } = "";
        public int CreateBy { get; set; }
        public bool IsCollab { get; set; }
    }
}
