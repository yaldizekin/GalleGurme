using GalleGurme.Areas.Admin.Models;
using GalleGurme.Data;
using GalleGurme.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace GalleGurme.Controllers
{
 
	public class HomeController : Controller
	{
        private readonly ApplicationDbContext _context;
        //private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route(template:"menu")]
        public IActionResult Menu()
        {
            return View(_context.Menu.OrderBy(Menu => Menu.Id).ToList());
        }
        [Route(template: "product")]
        public IActionResult Product()
        {
            return View(_context.Products.OrderBy(Products => Products.Id).ToList());
        }
        [Route(template: "about")]
        public IActionResult About()
        {
            return View();
        }

        public IActionResult PageNotFound()
        {
            Response.StatusCode = 404;
            return View();
        }

        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}