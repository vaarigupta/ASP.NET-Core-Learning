using Microsoft.AspNetCore.Identity;
using Nagarro.BookReading.Application.Interfaces;
using Nagarro.BookReading.Application.Mapper;
using Nagarro.BookReading.Application.Models;
using Nagarro.BookReading.Core.Entities;
using Nagarro.BookReading.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            this._accountRepository = accountRepository;
        }

        public async Task<IdentityResult> CreateUser(SignUp signUpModel)
        {
          
            var entityDto = await _accountRepository.CreateUser(signUpModel);
            return entityDto;
          
            
        }
    }
}
//mapping from application model to entity
//var mapped = ObjectMapper.Mapper.Map<SignUp>(signUpModel);
//if (mapped == null)
//    throw new ApplicationException($"Entity could not be mapped.");

///calling data layer using mapped
///
////outputting result in the same return type
//var newMappedEntity = ObjectMapper.Mapper.Map<IdentityResult>(entityDto);
//return newMappedEntity;