using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Burger_Project.DAL;
using MVC_Burger_Project.Models.Entities;
using MVC_Burger_Project.Models.ViewModels;
using Newtonsoft.Json;

namespace MVC_Burger_Project.Controllers
{
    public class BurgerController : Controller
    {
        private readonly Context _context;
        private readonly MenuViewModel menuModel;

        public BurgerController(Context db)
        {
            _context = db;
            menuModel = new MenuViewModel();
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
            menuModel.Burgers=_context.Burgers.ToList();
            menuModel.Sauces=_context.Sauces.ToList();
            return View(menuModel);

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
    }
}
