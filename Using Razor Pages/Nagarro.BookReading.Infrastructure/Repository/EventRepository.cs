using Microsoft.EntityFrameworkCore;
using Nagarro.BookReading.Core.Entities;
using Nagarro.BookReading.Core.Repositories;
using Nagarro.BookReading.Infrastructure.Data;
using Nagarro.BookReading.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Infrastructure.Repository
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        private readonly EventContext _eventContext;

        public EventRepository(EventContext eventContext) : base(eventContext)
        {
            this._eventContext = eventContext;
        }

        public async Task<IList<Event>> GetEvents()
        {
            return await _eventContext.Events.ToListAsync();
        }

        public async Task<Event> ViewDetails(int eventId)
        {
            return await _eventContext.Events.FindAsync(eventId);

        }
    }
}
