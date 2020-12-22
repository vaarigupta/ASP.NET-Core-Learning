using Nagarro.BookReadingEvent.Shared;
using Nagarro.BookReadingEvent.Validations;
using System;
using System.Collections.Generic;

namespace Nagarro.BookReadingEvent.Business
{
    public class EventManagerBDC : BDCBase, IEventBDC
    {
        public EventManagerBDC()
            : base(BDCType.EventManagerBDC)
        {

        }

        public OperationResult<IList<IEventDTO>> GetEvents()
        {
            OperationResult<IList<IEventDTO>> retVal = null;
            try
            {
                IEventDAC eventDAC = (IEventDAC)DACFactory.Instance.Create(DACType.EventManagerDAC);
                IList<IEventDTO> resultDTO = eventDAC.GetEvents();

                if (resultDTO!=null)
                {
                   
                    if (resultDTO != null)
                    {
                        retVal = OperationResult<IList<IEventDTO>>.CreateSuccessResult(resultDTO);
                    }
                    else
                    {
                        retVal = OperationResult<IList<IEventDTO>>.CreateFailureResult("Failed!");
                    }
                }
                else
                {
                    retVal = OperationResult<IList<IEventDTO>>.CreateFailureResult("Failed");
                }
            }
            catch (DACException dacEx)
            {
                retVal = OperationResult<IList<IEventDTO>>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                retVal = OperationResult<IList<IEventDTO>>.CreateErrorResult(ex.Message, ex.StackTrace);
            }

            return retVal;
        }

       
    }
}
