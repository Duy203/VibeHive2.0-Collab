using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VibeHive.Core.Models;

namespace VibeHive.Core.Commands
{
    public class VoteSongCommand : ICommand
    {
        private readonly Song _song;
        public VoteSongCommand (Song song)
        {
            _song = song;
        }

        public void Execute()
        {
            _song.Votes++;
        }
    }
}
