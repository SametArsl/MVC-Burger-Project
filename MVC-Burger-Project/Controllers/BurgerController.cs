using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Burger_Project.DAL;
using MVC_Burger_Project.Models.Entities;
using MVC_Burger_Project.Models.ViewModels;
using MVC_Burger_Project.ModelVM;
using Newtonsoft.Json;

namespace MVC_Burger_Project.Controllers
{
    public class BurgerController : Controller
    {
        private readonly Context _context;
        private readonly MenuViewModel menuModel;
        private readonly UserManager<AppUser> userManager;

        public BurgerController(Context db, UserManager<AppUser> userManager)
        {
            _context = db;
            menuModel = new MenuViewModel();
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            List<Burger> highestPricedBurgers = new List<Burger>();
            List<Category> categories = _context.Categories.ToList();

            foreach (var category in categories)
            {
                var highestPriceBurger = _context.Burgers
                    .Where(b => b.CategoryID == category.CategoryID)
                    .OrderByDescending(b => b.Price)
                    .FirstOrDefault();

                if (highestPriceBurger != null)
                {
                    highestPricedBurgers.Add(highestPriceBurger);
                }
            }

            return View(highestPricedBurgers);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Menu()
        {
            menuModel.Categories = _context.Categories.ToList();
            menuModel.Menus = _context.Menus.Include(m => m.Burger).Include(m => m.Drink).Include(m => m.Side).Include(m => m.Size).ToList();
            menuModel.Sides = _context.Sides.ToList();
            menuModel.Drinks = _context.Drinks.ToList();
            menuModel.Burgers = _context.Burgers.ToList();
            menuModel.Sauces = _context.Sauces.ToList();
            menuModel.BurgerIngredients = _context.BurgerIngredients.ToList();
            menuModel.Ingredients = _context.Ingredients.ToList();
            foreach (Menu menu in menuModel.Menus)
            {
                menu.TotalPrice = menu.Burger.Price + menu.Drink.Price + menu.Sauce.Price + menu.Side.Price + menu.Size.Price;
            }
            return View(menuModel);
        }
        public IActionResult SelectAMenu(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/Identity/Account/Login");
            }

            var menu = _context.Menus.Include(m => m.Burger).ThenInclude(x => x.BurgerIngredients).ThenInclude(i => i.Ingredient).Include(m => m.Drink).Include(m => m.Side).Include(m => m.Size).FirstOrDefault(x => x.MenuID == id);
            if (menu != null)
            {
                menuModel.SelectedMenu = menu;
                menuModel.SelectedMenu.Burger = _context.Burgers.FirstOrDefault(x => x.ID == menu.BurgerID);
                menuModel.SelectedMenu.Burger.BurgerIngredients = menu.Burger.BurgerIngredients;
                menuModel.SelectedMenu.Burger.Picture = menu.Burger.Picture;
                menuModel.SelectedMenu.Burger.Description = menu.Burger.Description;
                menuModel.SelectedMenu.Drink = menu.Drink;
                menuModel.SelectedMenu.Size = menu.Size;
                menuModel.Ingredients = _context.Ingredients.ToList();
                menuModel.SideList = _context.Sides.Select(x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.ID.ToString(),
                }).ToList();
                menuModel.SizeList = _context.Sizes.Select(x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.ID.ToString(),
                }).ToList();
                menuModel.SauceList = _context.Sauces.Select(x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.ID.ToString(),
                }).ToList();
                menuModel.DrinkList = _context.Drinks.Select(x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.ID.ToString(),
                }).ToList();
                string successMessage = TempData["SuccessMessage"] as string;

                if (!string.IsNullOrEmpty(successMessage))
                {
                    ViewBag.SuccessMessage = successMessage;
                }
                return View(menuModel);
            }
            else
            {
                return Content("Please, choose a menu!");
            }
        }

        [HttpPost]
        public IActionResult Contact(Feedback feedback)
        {
            //Feedback newFeedback = new Feedback()
            //{
            //    Name = feedback.Name,
            //    Email = feedback.Email,
            //    Comment = feedback.Comment,
            //};

            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SelectAMenu(MenuViewModel vm)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/Identity/Account/Login");
            }

            if (vm != null)
            {
                Order order = new Order()
                {
                    Burger = _context.Burgers.FirstOrDefault(x => x.ID == vm.SelectedMenu.BurgerID),
                    Drink = _context.Drinks.FirstOrDefault(x => x.ID == vm.SelectedMenu.DrinkID),
                    Sauce = _context.Sauces.FirstOrDefault(x => x.ID == vm.SelectedMenu.SauceID),
                    Size = _context.Sizes.FirstOrDefault(x => x.ID == vm.SelectedMenu.SizeID),
                    Side = _context.Sides.FirstOrDefault(x => x.ID == vm.SelectedMenu.SideID),
                    Quantity = vm.Burger.Quantity,
                    IsActive = true,
                    AppUser = await userManager.GetUserAsync(User)
                };
                order.TotalPrice = (order.Burger.Price + order.Drink.Price + order.Sauce.Price + order.Size.Price + order.Side.Price) * order.Quantity;
                _context.Orders.Add(order);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Sipariş başarıyla oluşturuldu.";
                return RedirectToAction("Menu", "Burger");

            }
            else
            {
                TempData["SuccessMessage"] = "Hata";
                return RedirectToAction("Menu", "Burger");
            }
        }
        public async Task<IActionResult> SelectASide(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/Identity/Account/Login");
            }

            if (id != 0)
            {
                Order order = new Order()
                {

                    Side = _context.Sides.FirstOrDefault(x => x.ID == id),
                    Quantity = 1,
                    IsActive = true,
                    AppUser = await userManager.GetUserAsync(User)
                };
                order.TotalPrice = order.Side.Price * order.Quantity;
                _context.Orders.Add(order);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Sipariş başarıyla oluşturuldu.";
                return RedirectToAction("Menu", "Burger");

            }
            else
            {
                TempData["SuccessMessage"] = "Hata";
                return RedirectToAction("Menu", "Burger");
            }
        }
        public async Task<IActionResult> SelectADrink(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/Identity/Account/Login");
            }

            if (id != 0)
            {
                Order order = new Order()
                {

                    Drink = _context.Drinks.FirstOrDefault(x => x.ID == id),
                    Quantity = 1,
                    IsActive = true,
                    AppUser = await userManager.GetUserAsync(User)
                };
                order.TotalPrice = order.Drink.Price * order.Quantity;
                _context.Orders.Add(order);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Sipariş başarıyla oluşturuldu.";
                return RedirectToAction("Menu", "Burger");

            }
            else
            {
                TempData["SuccessMessage"] = "Hata";
                return RedirectToAction("Menu", "Burger");
            }
        }
        public async Task<IActionResult> SelectASauce(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/Identity/Account/Login");
            }

            if (id != 0)
            {
                Order order = new Order()
                {

                    Sauce = _context.Sauces.FirstOrDefault(x => x.ID == id),
                    Quantity = 1,
                    IsActive = true,
                    AppUser = await userManager.GetUserAsync(User)
                };
                order.TotalPrice = order.Sauce.Price * order.Quantity;
                _context.Orders.Add(order);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Sipariş başarıyla oluşturuldu.";
                return RedirectToAction("Menu", "Burger");

            }
            else
            {
                TempData["SuccessMessage"] = "Hata";
                return RedirectToAction("Menu", "Burger");
            }
        }

        public async Task<IActionResult> MyCart()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/Identity/Account/Login");
            }

            AppUser user = await userManager.GetUserAsync(User);
            menuModel.Orders = _context.Orders.Include(b => b.Burger).ThenInclude(bi => bi.BurgerIngredients).ThenInclude(i => i.Ingredient).Include(m => m.Drink).Include(m => m.Side).Include(m => m.Size).Include(s => s.Sauce).Where(x => x.AppUser.Id == user.Id && x.IsActive == true).ToList();
            return View(menuModel);
        }
        public IActionResult DeleteOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(x => x.OrderID == id);
            _context.Orders.Remove(order);
            _context.SaveChanges();
            return RedirectToAction("MyCart", "Burger");
        }
        public async Task<IActionResult> CheckOut(int id)
        {
            AppUser user = await userManager.GetUserAsync(User);

            var orders = _context.Orders
                .Include(b => b.Burger)
                .ThenInclude(bi => bi.BurgerIngredients)
                .ThenInclude(i => i.Ingredient)
                .Include(m => m.Drink)
                .Include(m => m.Side)
                .Include(m => m.Size)
                .Include(s => s.Sauce)
                .Where(x => x.AppUser.Id == user.Id && x.IsActive == true)
                .ToList();

            decimal totalPrice = orders.Sum(item => Convert.ToDecimal(item.TotalPrice));

            if(orders != null)
            {
                Bill bill = new Bill
                {
                    UserID = user.Id,
                    Name = $"{user.FirstName} {user.LastName}",
                    Price = totalPrice
                };

                foreach (var item in orders)
                {
                    item.IsActive = false;
                }

                if (bill != null)
                {
                    _context.Bills.Add(bill);
                    await _context.SaveChangesAsync();
                    ViewData["OrderCompleted"] = "Order Completed";
                }
            }

            return RedirectToAction("GetOrders", "Panel", new { area = "CustomerPanel" });
        }
    }
}
