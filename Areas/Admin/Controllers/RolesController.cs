﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SportsEvents2.Models;

namespace SportsEvents2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<AppUser> userManager;

        public RolesController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        public IActionResult Index() => View(roleManager.Roles);
        
    }
}