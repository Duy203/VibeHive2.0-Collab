using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VibeHive.Core.Models;


namespace VibeHive.Core.Commands
{
    public class AddSongCommand : ICommand
    {
        private readonly Playlist _playlist;
        private readonly Song _song;

        public AddSongCommand (Playlist playlist, Song song)
        {
            _playlist = playlist;
            _song = song;
        }

        public void Execute()
        {
            _playlist.Songs.Add(_song);
        }
    }
}
