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
        public Menu? SelectedMenu { get; set; }
    }
}
