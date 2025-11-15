using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VibeHive.Core.Models;

namespace VibeHive.Core.Interface
{
    public interface IRentalService
    {
        Rental RentAlbum(int userId, int albumId);
        bool ReturnAlbum(int rentalId);
        IEnumerable<Rental> GetActiveRentals();
    }
}
