using Microsoft.AspNetCore.Mvc;
using MVC_Burger_Project.DAL;
using MVC_Burger_Project.Models.Entities;

namespace MVC_Burger_Project.Controllers
{
    public class BurgerController : Controller
    {
        private readonly Context _context;

        public BurgerController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
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
