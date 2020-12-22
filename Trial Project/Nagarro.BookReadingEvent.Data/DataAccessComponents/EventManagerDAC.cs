using Nagarro.BookReadingEvent.EntityDataModel;
using Nagarro.BookReadingEvent.Shared;
using Nagarro.BookReadingEvent.Shared.Functional.Repositories;
using System;
using System.Collections.Generic;
//Nagarro.BookReadingEvent.Data.EventManagerDAC
namespace Nagarro.BookReadingEvent.Data
{
    public class EventManagerDAC : DACBase, IEventDAC
    {
        private IEventRepository eventRepository;
        public EventManagerDAC(IEventRepository eventRepository)
            : base(DACType.EventManagerDAC)
        {
            this.eventRepository = eventRepository;
        }
        
        public IList<IEventDTO> GetEvents()
        {
            IList<IEventDTO> result = null;
            var eventList = eventRepository.GetEvents();
            try
            {
                if (eventList.Count > 0)
                {
                    result = new List<IEventDTO>();
                    IEventDTO eventDTO = null;
                    foreach (var _event in eventList)
                    {
                        eventDTO = (IEventDTO)DTOFactory.Instance.Create(DTOType.EventDTO);
                        EntityConverter.FillDTOFromEntity(_event, (DTOBase)eventDTO);

                        result.Add(eventDTO);
                    }
                }
               // return result;



            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return result;
        }
    }
}
