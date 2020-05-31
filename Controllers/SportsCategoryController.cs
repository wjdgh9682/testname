using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsEvents2.Infrastructure;
using SportsEvents2.Models;

namespace SportsEvents2.Controllers
{
    public class SportsCategoryController : Controller
    {
        private readonly SportsEventsContext context;

        public SportsCategoryController(SportsEventsContext context)
        {
            this.context = context;
        }


        public async Task<IActionResult> Index()
        {

            return View(await context.SportsCategories.OrderBy(c => c.Id).ToListAsync());
        }

    }
}