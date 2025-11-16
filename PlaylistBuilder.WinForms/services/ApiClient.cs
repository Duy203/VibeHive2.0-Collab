using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VibeHive.Common.DTOs;
using VibeHive.Core.Models;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace PlaylistBuilder.WinForms.services
{
    public class  ApiClient
    {
        private readonly HttpClient _client;
        private const string BASE_URL = "https://localhost:7023";

        public ApiClient()
        {
            _client = new HttpClient();
        }

        private StringContent ToJson(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        //playlist

        public async Task<Playlist> CreatePlaylist(CreatePlaylistDto dto)
        {
            var res = await _client.PostAsync($"{BASE_URL}/api/playlists", ToJson(dto));
            string json = await res.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Playlist>(json);
        }

        public async Task<List<Playlist>> GetAllPlaylists()
        {
            var res = await _client.GetAsync($"{BASE_URL}/api/playlists");
            string json = await res.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Playlist>>(json);
        }

        public async Task<Playlist> AddSong(int playlistId, AddSongDto dto)
        {
            var res = await _client.PutAsync($"{BASE_URL}/api/playlists/{playlistId}/add", ToJson(dto));
            string json = await res.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Playlist>(json);
        }

        public async Task<Playlist> Invite (int id, InviteDto  dto)
        {
            var res = await _client.PutAsync($"{BASE_URL}/api/playlists/{id}/invite", ToJson(dto));
            string json = await res.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Playlist>(json);
        }

        public async Task<Song> Vote( int id, VoteDto dto)
        {
            var res = await _client.PostAsync($"{BASE_URL}/api/playlists/{id}/vote", ToJson(dto));
            string json = await res.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Song>(json);
        }

        public async Task<List<Song>> GetRankings (int id)
        {
            var res = await _client.GetAsync($"{BASE_URL}/api/playlists/{id}/rankings");
            string json = await res.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Song>>(json);
        }


    }


}
