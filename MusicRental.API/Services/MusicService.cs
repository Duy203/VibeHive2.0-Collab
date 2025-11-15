using VibeHive.Core.Interface;
using VibeHive.Core.Models;
namespace MusicRental.API.Services
{
    public class MusicService : IMusicService
    {
        private readonly List<Music> _musicList = new();
        private int _idCounter = 1;

        public Music AddMusic(Music music)
        {
            music.Id = _idCounter++;
            _musicList.Add(music);
            return music;
        }

        public IEnumerable<Music> GetAllMusic()
        {
            return _musicList;
        }

        public bool DeleteMusic(int id)
        {
            var music = _musicList.FirstOrDefault(m => m.Id == id);
            if(music == null)
            {
                return false;
            }
            _musicList.Remove(music);
            return true;
        }
    }
}
