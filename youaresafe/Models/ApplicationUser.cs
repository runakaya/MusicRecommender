using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System;

namespace youaresafe.Models
{
    public class ApplicationUser :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Photo> Photos { get; set; }

    }

}
