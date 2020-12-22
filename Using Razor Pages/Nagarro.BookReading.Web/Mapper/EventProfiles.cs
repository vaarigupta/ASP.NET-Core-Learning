using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Nagarro.BookReading.Application.Models;
using Nagarro.BookReading.Web.Models;

namespace Nagarro.BookReading.Web.Mapper
{
    public class EventProfiles : Profile
    {

        public EventProfiles()
        {
            CreateMap<EventModel, EventViewModel>().ReverseMap();
            CreateMap<SignUpModel, SignUpViewModel>().ReverseMap();
          
        }
    }
}
