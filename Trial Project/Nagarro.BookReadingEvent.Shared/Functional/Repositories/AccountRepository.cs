using Microsoft.AspNetCore.Identity;
using Nagarro.BookReadingEvent.Shared.Functional.Entities;
using Nagarro.BookReadingEvent.Shared.Functional.IRepositories;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.BookReadingEvent.Shared.Functional.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<User> _userManager;

        //injected UserManager in this repo
        public AccountRepository(UserManager<User> userManager)
        {
            this._userManager = userManager;
        }

        public async Task<IdentityResult> CreateUser(SignUp signUpModel)
        {
            var user = new User()
            {
                firstName = signUpModel.firstName,
                lastName = signUpModel.lastName,
                Email = signUpModel.email,
                UserName = signUpModel.userName
            };
            var result = await _userManager.CreateAsync(user, signUpModel.password);
            return result;
        }
    }
}
