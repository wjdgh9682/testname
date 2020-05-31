using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEvents2.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }
        [DataType(DataType.Password), Required]
        public string Password { get; set; }
        //
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string PreferedSport { get; set; }
    }
}
