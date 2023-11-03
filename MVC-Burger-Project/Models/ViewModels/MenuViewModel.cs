using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Burger_Project.Models.Entities;

namespace MVC_Burger_Project.Models.ViewModels
{
    public class MenuViewModel
    {
        public ICollection<Category>? Categories { get; set; }
        public ICollection<Menu>? Menus { get; set; }
        public ICollection<Burger>? Burgers { get; set; }
        public ICollection<Drink>? Drinks { get; set; }
        public ICollection<Sauce>? Sauces { get; set; }
        public ICollection<Side>? Sides { get; set; }
        public ICollection<BurgerIngredient>? BurgerIngredients { get; set; }
        public ICollection<Ingredient>? Ingredients { get; set; }
        public Burger? Burger { get; set; }
        public Drink? Drink { get; set; }
        public Sauce? Sauce { get; set; }
        public Side? Side { get; set; }
        public Size? Size { get; set; }
        public Menu? SelectedMenu { get; set; }
        public decimal TotalPrice { get; set; }
        public List<SelectListItem> DrinkList { get; set; }
        public List<SelectListItem> SauceList { get; set; }
        public List<SelectListItem> SizeList { get; set; }
        public List<SelectListItem> SideList { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

}
