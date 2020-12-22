using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Nagarro.BookReading.Application.Interfaces;
using Nagarro.BookReading.Application.Models;
using Nagarro.BookReading.Core.Entities;
using Nagarro.BookReading.Web.Interfaces;
using Nagarro.BookReading.Web.Models;
using System;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Web.Services
{

    public class AccountPageService : IAccountPageService
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AccountPageService(IAccountService accountService, IMapper mapper)
        {
            this._accountService = accountService;
            this._mapper = mapper;
        }
        public async Task<IdentityResult> CreateUser(SignUp signUpViewModel)
        {
            
            var entityDto =  await _accountService.CreateUser(signUpViewModel);
            return entityDto;
        

        }
    }
}
//mapping from viewmodel to application model
//var mapped = _mapper.Map<SignUpModel>(signUpViewModel);
//if (mapped == null)
//    throw new Exception($"Entity could not be mapped.");

/////calling application layer using mapped
///    //outputting result in the same return type
//var mappedViewModel = _mapper.Map<IdentityResult>(entityDto);
//return mappedViewModel;