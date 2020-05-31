using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsEvents2.Infrastructure;
using SportsEvents2.Models;

namespace SportsEvents2.Areas.Admin.Controllers
{
    //[Authorize(Roles="Jeongho")]
    [Area("Admin")]
    public class CategoriesController : Controller
    {

        private readonly SportsEventsContext context;

        public CategoriesController(SportsEventsContext context)
        {
            this.context = context;
        }

        //GET /admin/categories
        public async Task<IActionResult> Index()
        {
            
            return View(await context.SportsCategories.OrderBy(c => c.Id).ToListAsync());
        }

        //GET /admin/categories/create
        public IActionResult Create() => View();

        //GET /admin/categories/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SportsCategory sportsCategory)
        {
            if (ModelState.IsValid)
            {

                context.Add(sportsCategory);
                await context.SaveChangesAsync();

                TempData["Success"] = "The category has been added!";

                return RedirectToAction("Index");
            }

            return View(sportsCategory);
        }

        //GET /admin/categories/edit/3
        public async Task<IActionResult> Edit(int id)
        {
            SportsCategory category = await context.SportsCategories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        //GET /admin/categories/edit/2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SportsCategory category)
        {
            if (ModelState.IsValid)
            {
                
                context.Update(category);
                await context.SaveChangesAsync();

                TempData["Success"] = "The category has been edited!";

                return RedirectToAction("Edit", new {id});
            }

            return View(category);
        }

        //GET /admin/categories/delete/2
        public async Task<IActionResult> Delete(int id)
        {
            SportsCategory category = await context.SportsCategories.FindAsync(id);
            if (category == null)
            {
                TempData["Error"] = "The category does not exist!";
            }
            else
            {
                context.SportsCategories.Remove(category);
                await context.SaveChangesAsync();

                TempData["Success"] = "The category has been removed!";
            }

            return RedirectToAction("Index");
        }
    }
}