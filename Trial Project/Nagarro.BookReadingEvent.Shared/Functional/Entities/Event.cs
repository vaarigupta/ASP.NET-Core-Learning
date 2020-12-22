using System;
using System.Collections.Generic;
using System.Text;

namespace Nagarro.BookReadingEvent.Shared
{
    public class Event
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
