using Nagarro.BookReadingEvent.Shared.Functional.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.BookReadingEvent.Shared
{
    public interface IEventDAC : IDataAccessComponent
    {
      
        IList<IEventDTO> GetEvents();
    }
}
