using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEvents2.Models
{
    public class UserEdit
    {/*
        public int Id { get; set; }

        [Required, MinLength(2, ErrorMessage = "Minimum length is 2")]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        */ 
        [Required, EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password), MinLength(3, ErrorMessage = "Minimum length is 3")]
        public string Password { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string PreferedSport { get; set; }

        
        public UserEdit() { }

        public UserEdit(AppUser appuser)
        {
            Email = appuser.Email;
            Password = appuser.PasswordHash;
            Name = appuser.Name;
            DateOfBirth = appuser.DateOfBirth;
            Gender = appuser.Gender;
            Address = appuser.Address;
            PhoneNumber = appuser.PhoneNumber;
            Location = appuser.Location;
            PreferedSport = appuser.PreferedSport;
        }
        
    }
}