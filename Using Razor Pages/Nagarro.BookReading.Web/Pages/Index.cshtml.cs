using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nagarro.BookReading.Web.Interfaces;

namespace Nagarro.BookReading.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IIndexPageService _indexPageService;

        public IndexModel(IIndexPageService indexPageService)
        {
            this._indexPageService = indexPageService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
