using Nagarro.BookReading.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Application.Interfaces
{
    public interface IEventService
    {
        Task<IList<EventModel>> GetEvents();
        Task<EventModel> ViewDetails(int eventId);
    }
}
