using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Burger_Project.Models.Entities;

namespace MVC_Burger_Project.Areas.ManagerPanel.Controllers
{
    [Area("ManagerPanel")]
    //[Authorize(Roles = "Manager")]

    //[Authorize(Policy = "RequireAdminRole")]
    public class PanelController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public PanelController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult ManagerIndex()
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
                Email = "yazilim_barcode@gmail.com",
                UserName = "yazilimbarcode@gmail.com",
            };

            await _userManager.CreateAsync(user, "Brcd.123");
            await _userManager.AddToRoleAsync(user, "Manager");

            return Content("Barcode Admin Olustu");
        }
    }
}
