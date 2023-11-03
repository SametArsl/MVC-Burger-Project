namespace MVC_Burger_Project.Models.Entities
{
    public class Menu
    {
        public int MenuID { get; set; }
        public int BurgerID { get; set; }
        public int DrinkID { get; set; }
        public int SideID { get; set; }
        public int SizeID { get; set; }
        public int SauceID { get; set; }
        public decimal? TotalPrice { get; set; }
        public Burger? Burger { get; set; }
        public Drink? Drink { get; set; }
        public Side? Side { get; set; }
        public Sauce? Sauce { get; set; }
        public Size? Size { get; set; }
        public ICollection<Order>? Orders { get; set; }

    }
}