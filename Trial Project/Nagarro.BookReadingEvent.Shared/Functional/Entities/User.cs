using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nagarro.BookReadingEvent.Shared.Functional.Entities
{
    public class User: IdentityUser
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        
    }
}
