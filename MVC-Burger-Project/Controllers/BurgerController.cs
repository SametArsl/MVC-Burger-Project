using Microsoft.AspNetCore.Mvc;

namespace MVC_Burger_Project.Controllers
{
    public class BurgerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
