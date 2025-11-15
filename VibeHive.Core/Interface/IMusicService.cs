using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VibeHive.Core.Models;

namespace VibeHive.Core.Interface
{
    public interface IMusicService
    {
        Music AddMusic(Music music);
        IEnumerable<Music> GetAllMusic();  
        bool DeleteMusic(int id);
    }
}
