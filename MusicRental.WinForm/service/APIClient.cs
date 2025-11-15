using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using VibeHive.Common.DTOs;
using VibeHive.Core.Models;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace MusicRental.Winforms.Services
{
    public class APIClient
    {
        private readonly HttpClient _client;
        private const string BASE_URL = "https://localhost:7067";

        public APIClient()
        {
            _client = new HttpClient();
        }

        private StringContent ToJSON(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        //music Endpoint
        public async Task<Music> AddMusic(MusicDto dto)
        {
            var response = await _client.PostAsync($"{BASE_URL}/api/music", ToJSON(dto));
            string result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Music>(result);
        }

        public async Task<List<Music>> GetAllMusic()
        {
            var response = await _client.GetAsync($"{BASE_URL}/api/music");
            string result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Music>>(result);
        }

        public async Task<Boolean> DelMusic(int id)
        {
            var response = await _client.DeleteAsync($"{BASE_URL}/api/music/{id}");
            return response.IsSuccessStatusCode;
        }

        //retal endpooint
        public async Task<Rental> RentAlbum(RentAlbumDto dto)
        {
            var response = await _client.PostAsync($"{BASE_URL}/api/rentals", ToJSON(dto));
            if (!response.IsSuccessStatusCode) return null;

            string result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Rental>(result);
        }

        public async Task<bool> ReturnAlbum(int rentalId)
        {
            var response = await _client.PostAsync($"{BASE_URL}/api/rentals/{rentalId}/return", null);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<Rental>> GetActiveRentals()
        {
            var response = await _client.GetAsync($"{BASE_URL}/api/rentals");
            string result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Rental>>(result);
        }
    }
}
