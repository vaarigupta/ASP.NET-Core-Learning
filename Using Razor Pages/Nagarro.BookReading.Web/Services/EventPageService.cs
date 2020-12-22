using AutoMapper;
using Microsoft.Extensions.Logging;
using Nagarro.BookReading.Application.Interfaces;
using Nagarro.BookReading.Web.Interfaces;
using Nagarro.BookReading.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Web.Services
{
    public class EventPageService : IEventPageService
    {
        private readonly IEventService _eventService;
        private readonly IMapper _mapper;
        private readonly ILogger<EventPageService> _logger;
        public EventPageService(IEventService eventService, IMapper mapper, ILogger<EventPageService> logger)
        {
            this._eventService = eventService?? throw new ArgumentNullException(nameof(eventService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IList<EventViewModel>> GetEvents()
        {
            var list = await _eventService.GetEvents();
            var mapped = _mapper.Map<IList<EventViewModel>>(list);
            return mapped;
        }
        public async Task<EventViewModel> ViewDetails(int eventId)
        {
            var _event = await _eventService.ViewDetails(eventId);
            var mapped = _mapper.Map<EventViewModel>(_event);
            return mapped;
        }
    }
}
