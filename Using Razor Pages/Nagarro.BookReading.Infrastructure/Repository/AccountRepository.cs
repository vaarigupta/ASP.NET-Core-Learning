using Microsoft.AspNetCore.Identity;
using Nagarro.BookReading.Core.Entities;
using Nagarro.BookReading.Core.Repositories;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Infrastructure.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        public AccountRepository(UserManager<IdentityUser> userManager) 
        {
            this._userManager = userManager;
        }

        public async Task<IdentityResult> CreateUser(SignUp userSignUp)
        {
            var user = new IdentityUser()
            {
                
                UserName = userSignUp.userName,
                Email = userSignUp.email
            };

           var result = await _userManager.CreateAsync(user, userSignUp.password);

           return result;
        }
    }
}