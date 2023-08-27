using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Burger_Project.Models.Entities;

namespace MVC_Burger_Project.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public HomeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AdminUserOlustur()
        {
            AppUser user = new AppUser()
            {
                FirstName = "BarCode",
                LastName = "Yazılım",
                Address = "Istanbul",
                Email = "yazilimbarcode@gmail.com",
                UserName = "yazilimbarcode@gmail.com",
            };

            await _userManager.CreateAsync(user, "Brcd_123");
            await _userManager.AddToRoleAsync(user, "Manager");

            return Content("Barcode Admin Olustu");
        }
    }
}
