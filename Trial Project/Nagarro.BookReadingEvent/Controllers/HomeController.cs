using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nagarro.BookReadingEvent.Models;
using Nagarro.BookReadingEvent.Shared;
using Nagarro.BookReadingEvent.Shared.Functional.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Event = Nagarro.BookReadingEvent.Models.EventModel;

namespace Nagarro.BookReadingEvent.Controllers
{
    public class HomeController : Controller
    {
        //  private IEventFacade _eventFacade;
        private readonly IEventRepository _eventRepository;
        public HomeController(IEventRepository eventRepository)
        {
            this._eventRepository = eventRepository;
        }
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetEvent()
        {
            ///Entity List
            var eventListEntity = _eventRepository.GetEvents();
            //model List
            IList<Event> eventListModel;
            //convert entity to model
            eventListModel = eventListEntity.Select(evnt => new Event
            {
                Id = evnt.Id,
                title = evnt.title,
                date = evnt.date,
                startTime = evnt.startTime,
                description = evnt.description,
                type = evnt.type

            }).ToList<EventModel>();

            return View(eventListModel);
        }

      
    }
}

