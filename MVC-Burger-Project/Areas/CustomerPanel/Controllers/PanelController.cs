using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Burger_Project.DAL;
using MVC_Burger_Project.Models.Entities;
using MVC_Burger_Project.Models.ViewModels;

namespace MVC_Burger_Project.Areas.CustomerPanel.Controllers
{
    [Authorize(Roles = "Customer")]
    [Area("CustomerPanel")]
    public class PanelController : Controller
    {
        private readonly Context _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly MenuViewModel menuModel;

        public PanelController(Context context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            menuModel = new MenuViewModel();
        }

        public IActionResult CustomerIndex()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            AppUser appUser = await _userManager.GetUserAsync(User);

            return View(appUser);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, AppUser updatedUser)
        {
            AppUser appUser = await _userManager.GetUserAsync(User);
            appUser.FirstName = updatedUser.FirstName;
            appUser.LastName = updatedUser.LastName;
            appUser.Email = updatedUser.Email;
            appUser.UserName = updatedUser.Email;
            appUser.NormalizedEmail = updatedUser.Email.ToUpper();
            appUser.NormalizedUserName = updatedUser.Email.ToUpper();
            if (updatedUser.PasswordHash != null)
            {
                appUser.PasswordHash = _userManager.PasswordHasher.HashPassword(appUser, updatedUser.PasswordHash);
            }
            appUser.Address = updatedUser.Address;

            _context.SaveChanges();

            return Redirect("/CustomerPanel/Panel/CustomerIndex");
        }

        public async Task<IActionResult> GetOrders (int id)
        {
            AppUser appUser = await _userManager.GetUserAsync(User);

            menuModel.Orders = _context.Orders.Include(b => b.Burger).ThenInclude(bi => bi.BurgerIngredients).ThenInclude(i => i.Ingredient).Include(m => m.Drink).Include(m => m.Side).Include(m => m.Size).Include(s => s.Sauce).Where(x => x.AppUser.Id == appUser.Id).ToList();

            return View(menuModel);
        }
    }
}