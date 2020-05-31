using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsEvents2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEvents2.Infrastructure
{
    public class MainPageViewComponent : ViewComponent
    {
        private readonly SportsEventsContext context;

        public MainPageViewComponent(SportsEventsContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pages = await GetPagesAsync();
            return View(pages);
        }

        private Task<List<SportsCategory>> GetPagesAsync()
        {
            return context.SportsCategories.OrderBy(p => p.Name).ToListAsync();
        }
    }
}

// Shared/Components/{ViewComponent}/Default.cshtml