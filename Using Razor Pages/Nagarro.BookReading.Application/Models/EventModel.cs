using Nagarro.BookReading.Application.Models.Base;
using System;

namespace Nagarro.BookReading.Application.Models
{
    public class EventModel : BaseModel
    {
        public string title { get; set; }
        public DateTime date { get; set; }
        public DateTime startTime { get; set; }
#nullable enable
        public string? description { get; set; }
        public bool type { get; set; }
    }
}
