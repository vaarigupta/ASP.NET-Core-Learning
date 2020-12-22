using AutoMapper;
using Nagarro.BookReading.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Web.Services
{
    public class IndexPageService : IIndexPageService
    {
        private readonly IMapper _mapper;
        public IndexPageService(IMapper mapper)
        {
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
    }
}
