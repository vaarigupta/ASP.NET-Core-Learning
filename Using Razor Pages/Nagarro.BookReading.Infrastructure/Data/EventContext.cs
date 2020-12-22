using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nagarro.BookReading.Core.Entities;

namespace Nagarro.BookReading.Infrastructure.Data
{
    public class EventContext : IdentityDbContext
    {
        public EventContext(
            DbContextOptions<EventContext> options)
            : base(options)
        {
        }
        public DbSet<Event> Events { get; set; }
    }
}
