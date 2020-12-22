using System;

namespace Nagarro.BookReadingEvent.Shared
{
    public interface IEventDTO : IDTO
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
