using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsEvents2.Infrastructure;
using SportsEvents2.Models;

namespace SportsEvents2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly SportsEventsContext context;

        public UsersController(SportsEventsContext context)
        {
            this.context = context;
        }

        //GET /admin/Users
        public async Task<IActionResult> Index()
        {
            IQueryable<AppUser> pages = from a in context.AppUsers orderby a.Id select a;

            List<AppUser> pagesList = await pages.ToListAsync();

            ViewBag.MembersSystem = "Members System";

            return View(pagesList);
        }
        /*
        //GET /admin/users/details/5
        public async Task<IActionResult> Details(string phoneNumber)
        {
            AppUser page = await context.AppUsers.FirstOrDefaultAsync(x => x.PhoneNumber == phoneNumber);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }*/

        //GET /admin/users/create
        public IActionResult Create() => View();

        //GET /admin/users/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AppUser appUser)
        {
            if (ModelState.IsValid)
            {
                context.Add(appUser);
                await context.SaveChangesAsync();

                TempData["Success"] = "The page has been added!";

                return RedirectToAction("Index");
            }

            return View(appUser);
        }

        //GET /admin/users/edit/3
        public async Task<IActionResult> Edit(string id)
        {
            AppUser page = await context.AppUsers.FindAsync(id);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        //GET /admin/pages/edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AppUser page)
        {
            if (ModelState.IsValid)
            {
                //return View(page);

                context.Update(page);
                await context.SaveChangesAsync();

                TempData["Success"] = "The page has been edited!";

                return RedirectToAction("Edit", new { id = page.Id });
            }

            return View(page);
        }

        //GET /admin/users/delete/2
        public async Task<IActionResult> Delete(string id)
        {
            AppUser page = await context.AppUsers.FindAsync(id);
            if (page == null)
            {
                TempData["Error"] = "The page does not exist!";
            }
            else
            {
                context.AppUsers.Remove(page);
                await context.SaveChangesAsync();

                TempData["Success"] = "The page has been removed!";
            }

            return RedirectToAction("Index");
        }
        /*
        //GET /admin/users/reorder
        [HttpPost]
        public async Task<IActionResult> Reorder(int[] id)
        {
            int count = 1;

            foreach (var pageId in id)
            {
                AppUser page = await context.AppUsers.FindAsync(pageId);
                AppUser.Id = count;
                context.Update(page);
                await context.SaveChangesAsync();
                count++;
            }

            return Ok();
        }
        */

        /*
        private readonly UserManager<AppUser> userManager;

        public UsersController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        
        
        public IActionResult Index()
        {
            return View(userManager.Users);
        }
        */
    }
}