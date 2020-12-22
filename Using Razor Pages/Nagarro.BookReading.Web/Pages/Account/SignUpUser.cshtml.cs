using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nagarro.BookReading.Core.Entities;
using Nagarro.BookReading.Web.Interfaces;
using Nagarro.BookReading.Web.Models;

namespace Nagarro.BookReading.Web.Pages.Account
{
    public class SignUpUserModel : PageModel
    {
        private readonly IAccountPageService _accountPageService;

        public SignUpUserModel(IAccountPageService accountPageService)
        {
            this._accountPageService = accountPageService ?? throw new ArgumentNullException(nameof(accountPageService));
        }

        [BindProperty]
        public SignUp user { get; set; }
        //[BindProperty]
        //public IdentityResult result { get; set; }


        //[TempData]
        //public string Message { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var result = await _accountPageService.CreateUser(user);
            return RedirectToPage("/Index");
        }

    }
}
//if (!result.Succeeded)
//{
//    foreach (var errorMessage in result.Errors)
//    {
//        ModelState.AddModelError("", errorMessage.Description);
//    }
//    //return NotFound();
//}
/*
 * 
vaarigupta
vaarigupta@gmail.com
Vaari@123
Vaari@123
 * 
 * */