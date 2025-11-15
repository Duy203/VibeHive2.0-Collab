using VibeHive.Core.Interface;
using VibeHive.Core.Models;
using VibeHive.Common.DTOs;

namespace MusicRental.API.Services
{
    public class RentalService : IRentalService
    {
        private readonly List<Rental> _rentals = new();
        private readonly List<Music> _musicList;
        private int _rentalIdCounter = 1;

        public RentalService(IMusicService musicService)
        {
            _musicList = musicService.GetAllMusic().ToList();
        }

        public Rental RentAlbum(int userId, int albumId)
        {
            var album = _musicList.FirstOrDefault(a => a.Id == albumId);

            if (album == null || !album.IsAvailable)
            {
                return null;
            }
            album.IsAvailable = false;
            var rental = new Rental
            {
                Id = _rentalIdCounter++,
                UserId = userId,
                AlbumId = albumId,
                RentalDate = DateTime.Now
            };

            _rentals.Add(rental);
            return rental;
        }

        public bool ReturnAlbum(int rentalId)
        {
            var rental = _rentals.FirstOrDefault(r => r.Id == rentalId);
            if (rental == null || rental.ReturnDate != null)
            {
                return false;
            }
            rental.ReturnDate = DateTime.Now;

            var album =_musicList.FirstOrDefault(a => a.Id == rental.AlbumId);
            if (album != null)
            {
                album.IsAvailable = true;
            }
            return true;
        }

        public IEnumerable<Rental> GetActiveRentals()
        {
            return _rentals.Where(r => r.RentalDate == null);
        }
    }
}
