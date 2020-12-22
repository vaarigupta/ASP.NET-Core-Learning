using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.BookReadingEvent.Shared
{
    public interface IEventBDC: IBusinessDomainComponent
    {
        OperationResult<IList<IEventDTO>> GetEvents();
    }
}
