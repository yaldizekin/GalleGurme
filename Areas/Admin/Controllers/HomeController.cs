using GalleGurme.Areas.Admin.Models;
using GalleGurme.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GalleGurme.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Area("Admin")]

    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        //private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly UserManager<IdentityUser> _userManager;
        
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Route("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
