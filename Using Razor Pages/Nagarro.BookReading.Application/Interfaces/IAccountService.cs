using Microsoft.AspNetCore.Identity;
using Nagarro.BookReading.Application.Models;
using Nagarro.BookReading.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Application.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateUser(SignUp signUp);
    }
}
