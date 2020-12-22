using Nagarro.BookReading.Core.Entities.Base;
using System;

namespace Nagarro.BookReading.Core.Entities
{
    public class Event : Entity
    {
        public string title { get; set; }
        public DateTime date { get; set; }
        public DateTime startTime { get; set; }
#nullable enable
        public string? description { get; set; }
        public bool type { get; set; }


    }
}
