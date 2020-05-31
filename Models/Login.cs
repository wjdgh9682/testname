using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEvents2.Models
{
    public class Login
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password), Required, MinLength(3, ErrorMessage = "Minimum length is 3")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
