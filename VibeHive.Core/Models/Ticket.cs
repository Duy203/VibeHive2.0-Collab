using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VibeHive.Core.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
    }
}
