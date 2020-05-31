using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsEvents2.Infrastructure;
using SportsEvents2.Models;

namespace SportsEvents2.Controllers
{
    public class PagesController : Controller
    {
        private readonly SportsEventsContext context;

        public PagesController(SportsEventsContext context)
        {
            this.context = context;
        }

        // GET or /name
        public async Task<IActionResult> Page(string slug)
        {
            if (slug == null)
            {
                return View(await context.SportsCategories.Where(x => x.Name == "home").FirstOrDefaultAsync());
            }

            SportsCategory page = await context.SportsCategories.Where(x => x.Name == slug).FirstOrDefaultAsync();

            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }
    }
}