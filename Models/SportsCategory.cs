using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEvents2.Models
{
    public class SportsCategory
    {
        public int Id { get; set; }
        [Required, MinLength(3, ErrorMessage = "Minimum length is 3")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        [Required]
        public int Capacity { get; set; }
    }
}
