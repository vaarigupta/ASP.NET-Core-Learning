using Microsoft.AspNetCore.Identity;
using Nagarro.BookReadingEvent.Shared.Functional.Entities;
using System.Threading.Tasks;

namespace Nagarro.BookReadingEvent.Shared.Functional.IRepositories
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUser(SignUp signUpModel);
    }
}