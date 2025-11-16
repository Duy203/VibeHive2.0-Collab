using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VibeHive.Core.Models;

namespace VibeHive.Core.Interface
{
    public interface IPlaylistService
    {
        Playlist CreatePlaylist(string name, int userid, bool isCollab);

        IEnumerable<Playlist> GetAllPlaylists();

        Playlist AddSong(int playlistid, Song song);
        Playlist InviteCollaborator(int playlistid, int userid);
        Song VoteSong (int playlistid, int songid);
        IEnumerable<Song> GetRankings(int playlistid);
    }
}
