using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nagarro.BookReading.Web.Interfaces;
using Nagarro.BookReading.Web.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Web.Pages.Event
{
    public class IndexModel : PageModel
    {
        private readonly IEventPageService _eventPageService;

        public IndexModel(IEventPageService eventPageService)
        {
            this._eventPageService = eventPageService ?? throw new ArgumentNullException(nameof(eventPageService));
        }

        public IList<EventViewModel> EventList { get; set; } = new List<EventViewModel>();
       
        public async Task<IActionResult> OnGet()
        {
            EventList = await _eventPageService.GetEvents();
            return Page();
        }
    }
}

