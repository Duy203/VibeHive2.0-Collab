using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VibeHive.Core.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int CreatedBy { get; set; }
        public bool IsCollab { get; set; }
        public List<Song> Songs { get; set; } = new();
        public List<int> Collaborators { get; set; } = new();

    }
}
