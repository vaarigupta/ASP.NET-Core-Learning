using Nagarro.BookReading.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Web.Interfaces
{
    public interface IEventPageService
    {
        Task<IList<EventViewModel>> GetEvents();
        Task<EventViewModel> ViewDetails(int eventId);
    }
}
