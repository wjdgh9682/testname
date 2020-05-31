using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SportsEvents2.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEvents2.Models
{
    public class SeedData
    {
        public static void Initialise(IServiceProvider serviceProvider)
        {
            using (var context = new SportsEventsContext
                (serviceProvider.GetRequiredService<DbContextOptions<SportsEventsContext>>()))
            {
                if (context.Pages.Any())
                {
                    return;
                }

                context.Pages.AddRange(
                    new Page
                    {
                        Name = "John",
                        DateOfBirth = "03.15.1997",
                        Gender = "Male",
                        Email = "John@mail.com",
                        Address = "43 London road, kT1 4DT",
                        TelPhone = 0123456789,
                        Location = "London"
                    },
                    new Page
                    {
                        Name = "Bob",
                        DateOfBirth = "21.04.1993",
                        Gender = "Male",
                        Email = "Bob@mail.com",
                        Address = "43 Kingston road, kT1 3RS",
                        TelPhone = 0753026458,
                        Location = "Kingston"
                    },
                    new Page
                    {
                        Name = "Alice",
                        DateOfBirth = "15.06.1990",
                        Gender = "Feale",
                        Email = "Alice@mail.com",
                        Address = "43 Guildford road, SW15 5FJ",
                        TelPhone = 0756521973,
                        Location = "Guildford"
                    },
                    new Page
                    {
                        Name = "Olivia",
                        DateOfBirth = "21.09.1983",
                        Gender = "Female",
                        Email = "Olivia@mail.com",
                        Address = "17 Forsyth Court, kT3 4BH",
                        TelPhone = 0765278612,
                        Location = "Kingston"
                    },
                    new Page
                    {
                        Name = "Joe",
                        DateOfBirth = "18.12.2001",
                        Gender = "Male",
                        Email = "Joe@mail.com",
                        Address = "38 Kingston road, kT1 3RS",
                        TelPhone = 0783624097,
                        Location = "Kingston"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
