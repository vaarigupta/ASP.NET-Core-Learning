using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nagarro.BookReading.Web.Interfaces;
using Nagarro.BookReading.Web.Models;

namespace Nagarro.BookReading.Web.Pages.Event
{
    public class ViewDetailsModel : PageModel
    {
        private readonly IEventPageService _eventPageService;

        public ViewDetailsModel(IEventPageService eventPageService)
        {
            this._eventPageService = eventPageService;
        }

        [BindProperty]
        public EventViewModel _eventViewModel { get; set; } = new EventViewModel();

        public async Task<IActionResult> OnGet(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            _eventViewModel = await _eventPageService.ViewDetails(Id.Value);
            if (_eventViewModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
