using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VibeHive.Common.DTOs
{
    public class MusicDto
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
    }
}
