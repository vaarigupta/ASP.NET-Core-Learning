using Nagarro.BookReading.Application.Interfaces;
using Nagarro.BookReading.Application.Mapper;
using Nagarro.BookReading.Application.Models;
using Nagarro.BookReading.Core.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Application.Services
{
    // TODO : add validation , authorization, logging, exception handling etc. -- cross cutting activities in here.
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService (IEventRepository eventRepository )
        {
            this._eventRepository = eventRepository;
        }

        public async Task<IList<EventModel>> GetEvents()
        {
            var eventList = await _eventRepository.GetEvents();
            var mapped = ObjectMapper.Mapper.Map<IList<EventModel>>(eventList);
            return mapped;

        }
        public async Task<EventModel> ViewDetails(int eventId)
        {
            var _event = await _eventRepository.ViewDetails(eventId);
            var mapped = ObjectMapper.Mapper.Map<EventModel>(_event);
            return mapped;
        }
    }
}
