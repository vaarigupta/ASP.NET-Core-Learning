using Nagarro.BookReading.Core.Entities;
using Nagarro.BookReading.Core.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Core.Repositories
{
    public interface IEventRepository : IRepository<Event>
    {
        Task<IList<Event>> GetEvents();
        Task<Event> ViewDetails(int eventId);

    }
}
