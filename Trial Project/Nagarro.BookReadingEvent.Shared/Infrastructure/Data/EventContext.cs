using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nagarro.BookReadingEvent.Shared.Functional.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nagarro.BookReadingEvent.Shared
{
    public class EventContext : IdentityDbContext<User>
    {
        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
    }
}
