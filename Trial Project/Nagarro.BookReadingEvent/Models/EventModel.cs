using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nagarro.BookReadingEvent.Models
{
    public class EventModel
    {

        public int Id { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public DateTime startTime { get; set; }
#nullable enable
        public string? description { get; set; }
        public bool type { get; set; }
    }
}
