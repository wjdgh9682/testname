using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEvents2.Models
{
    public class Page
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Required, MinLength(6, ErrorMessage ="Minimum length is 6")]
        public string Address { get; set; }
        [Required]
        public int TelPhone { get; set; }
        [Required, MinLength(3, ErrorMessage = "Minimum length is 3")]
        public string Location { get; set; }
    }
}
