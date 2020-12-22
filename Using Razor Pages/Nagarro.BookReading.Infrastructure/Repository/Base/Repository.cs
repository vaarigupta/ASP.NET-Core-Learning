using Microsoft.EntityFrameworkCore;
using Nagarro.BookReading.Core.Entities.Base;
using Nagarro.BookReading.Core.Repositories.Base;
using Nagarro.BookReading.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nagarro.BookReading.Infrastructure.Repository.Base
{
    public class Repository<T> : IRepository<T> where T: Entity
    {
        private readonly EventContext _eventContext;

        public Repository(EventContext eventContext)
        {
            this._eventContext = eventContext ?? throw new ArgumentNullException(nameof(eventContext)); ;
        }

       
    }
}
