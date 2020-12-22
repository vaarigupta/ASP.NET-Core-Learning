using System;

namespace Nagarro.BookReading.Web.Models
{
    public class EventViewModel : BaseViewModel
    {
        public string title { get; set; }
        public DateTime date { get; set; }
        public DateTime startTime { get; set; }
#nullable enable
        public string? description { get; set; }
        public bool type { get; set; }


    }
}
