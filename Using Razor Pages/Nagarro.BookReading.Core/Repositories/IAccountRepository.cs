using Microsoft.AspNetCore.Identity;
using Nagarro.BookReading.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Core.Repositories
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUser(SignUp user);
    }
}
