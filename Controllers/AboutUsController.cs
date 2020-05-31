using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsEvents2.Infrastructure;

namespace SportsEvents2.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly SportsEventsContext context;

        public AboutUsController(SportsEventsContext context)
        {
            this.context = context;
        }


        public async Task<IActionResult> AboutUs()
        {

            return View();
        }
    }
}