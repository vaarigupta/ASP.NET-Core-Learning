using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nagarro.BookReading.Application.Models
{
    public class SignUpModel
    {
        //[Required(ErrorMessage = "Please enter your First name")]
        //[Display(Name = "First Name")]
        //public string firstName { get; set; }

        //[Required(ErrorMessage = "Please enter your Last name")]
        //[Display(Name = "Last Name")]
        //public string lastName { get; set; }

        [Required(ErrorMessage = "Please enter your username")]
        [Display(Name = "User Name")]
        public string userName { get; set; }


        [Required(ErrorMessage = "Please enter your Email Address")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please provide a valid Email Address")]
        public string email { get; set; }


        [Required(ErrorMessage = "Please enter your Password")]
        [Display(Name = "Password")]
        [Compare("confirmPassword", ErrorMessage = "Password does not match")]
        [DataType(DataType.Password, ErrorMessage = "Please Provide a valid Password")]
        public string password { get; set; }


        [Required(ErrorMessage = "Please confirm your Password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password, ErrorMessage = "Password does not match")]
        public string confirmPassword { get; set; }
    }
}
