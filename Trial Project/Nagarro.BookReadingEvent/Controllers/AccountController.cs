using Microsoft.AspNetCore.Mvc;
using Nagarro.BookReadingEvent.Models;
using Nagarro.BookReadingEvent.Shared.Functional.Entities;
using Nagarro.BookReadingEvent.Shared.Functional.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nagarro.BookReadingEvent.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            this._accountRepository = accountRepository;
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel signUpModel)
        {

            //create an entity 
            var signUpEntity = new SignUp()
            {
                firstName = signUpModel.firstName,
                lastName = signUpModel.lastName,
                userName = signUpModel.userName,
                email = signUpModel.email,
                password = signUpModel.password,
                confirmPassword = signUpModel.confirmPassword

            };
            if (ModelState.IsValid)
            {
                var result = await _accountRepository.CreateUser(signUpEntity);
                if(!result.Succeeded)
                {
                    foreach(var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage.Description);
                    }
                    return View(signUpModel);
                }
                ModelState.Clear();
               
            }
                return View();
           
        }
        //myadmin@bookevents.com
        //Myadmin@123
        public IActionResult Login()
        {
            
                return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                return RedirectToAction("SignUp");
            }
            else
            {
                return View();
            }
            
        }
    }
}
