using Microsoft.AspNetCore.Identity;
using Nagarro.BookReading.Core.Entities;
using Nagarro.BookReading.Web.Models;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Web.Interfaces
{
    public interface IAccountPageService
    {
        Task<IdentityResult> CreateUser(SignUp signUp);
    }
}
