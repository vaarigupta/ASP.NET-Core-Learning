using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nagarro.BookReadingEvent.Shared.Functional.Repositories
{
   
        public class EventRepository : IEventRepository
        {
            private readonly EventContext context = null;
            public EventRepository(EventContext context)
            {
                this.context = context;
            }
            
            public IList<Event> GetEvents()
            {
            var eventList = context.Events.Select(evnt => new Event()
            {
                Id = evnt.Id,
                title = evnt.title,
                date = evnt.date,
                startTime = evnt.startTime,
                description = evnt.description,
                type = evnt.type

            }).ToList();

            return eventList;
            }

        }
    
}

