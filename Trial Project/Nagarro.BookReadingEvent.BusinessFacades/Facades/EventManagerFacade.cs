using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.BookReadingEvent.Shared;

namespace Nagarro.BookReadingEvent.BusinessFacades
{
    public class EventManagerFacade : IEventFacade
    {
        public EventManagerFacade()
            
        {

        }
        public OperationResult<IList<IEventDTO>> GetEvents()
        {
            IEventBDC EventBDC = (IEventBDC)BDCFactory.Instance.Create(BDCType.EventManagerBDC);
            return EventBDC.GetEvents();
        }
    }
}
