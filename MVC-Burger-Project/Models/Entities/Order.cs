namespace MVC_Burger_Project.Models.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public int? DrinkID { get; set; }
        public int? SizeID { get; set; }
        public int? SideID { get; set; }
        public int? SauceID { get; set; }
        public int? BurgerID { get; set; }
        public Burger? Burger { get; set; }
        public Drink? Drink { get; set; }
        public Side? Side { get; set; }
        public Sauce? Sauce { get; set; }
        public Size? Size { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalPrice { get; set; }
        public AppUser? AppUser { get; set; }
        public bool? IsActive { get; set; }
    }
}
