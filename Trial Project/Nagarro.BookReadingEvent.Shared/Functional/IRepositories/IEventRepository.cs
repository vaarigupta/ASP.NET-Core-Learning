using System;
using System.Collections.Generic;
using System.Text;

namespace Nagarro.BookReadingEvent.Shared.Functional.Repositories
{
    public interface IEventRepository
    {
        IList<Event> GetEvents();
    }
}
