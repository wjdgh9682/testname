using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsEvents2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEvents2.Infrastructure
{
    public class SportsEventsContext : IdentityDbContext<AppUser>
    {
        public SportsEventsContext(DbContextOptions<SportsEventsContext> options)
            : base(options)
        { 
        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<SportsCategory> SportsCategories { get; set; }
         public DbSet<AppUser> AppUsers { get; set; }
    }
}
