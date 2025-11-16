using VibeHive.Core.Commands;
using VibeHive.Core.Interface;
using VibeHive.Core.Models;
namespace PlaylistBuilder.API.Service
{
    public class PlaylistService : IPlaylistService
    {
        private readonly List<Playlist> _playlists = new();
        private int _playlistIdCounter = 1;
        private int _SongIdCounter = 1;

        public Playlist CreatePlaylist (string name, int userId , bool isCollab)
        {
            var playlist = new Playlist
            {
                Id = _playlistIdCounter++,
                Name = name,
                CreatedBy = userId,
                IsCollab = isCollab
            };

            _playlists.Add(playlist);
            return playlist;
        }

        public IEnumerable<Playlist> GetAllPlaylists()
        {
            return _playlists;
        }

        public Playlist AddSong(int playlistId, Song song)
        {
            var playlist = _playlists.FirstOrDefault(p => p.Id == playlistId);
            if (playlist == null)
            {
                throw new Exception("Playlist not found");
            }
            song.Id = _SongIdCounter++;
            var command = new AddSongCommand(playlist, song);
            command.Execute();
            return playlist;
        }

        public Playlist InviteCollaborator(int playlistId, int userId)
        {
            var playlist = _playlists.FirstOrDefault(p => p.Id == playlistId);
            if (playlist == null)
            {
                throw new Exception("Playlist not found");
            }
            playlist.Collaborators.Add(userId);
            return playlist;
        }

        public Song VoteSong (int playlistid, int songid)
        {
            var playlist = _playlists.FirstOrDefault(p => p.Id == playlistid);
            var song = playlist?.Songs.FirstOrDefault(s => s.Id == songid);
            if(song == null)
            {
                throw new Exception("Song not found in the specified playlist");
            }

            var command = new VoteSongCommand(song);
            command.Execute();
            return song;
        }

        public IEnumerable<Song> GetRankings (int playlistid)
        {
            var playlist = _playlists.FirstOrDefault(p => p.Id == playlistid);
            if (playlist == null)
            {
                throw new Exception("Playlist not found");
            }
            return playlist.Songs.OrderByDescending(s => s.Votes);
        }
    }
}
