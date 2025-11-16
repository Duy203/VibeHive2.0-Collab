using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VibeHive.Common.DTOs
{
    public class EventDto
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime Date { get; set; }
        public int TicketsAvailable { get; set; }
    }
}
