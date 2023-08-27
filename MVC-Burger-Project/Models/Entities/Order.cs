namespace MVC_Burger_Project.Models.Entities
{
    public class Order : BaseEntity
    {
        public ICollection<Burger>? Burgers { get; set; }
        public ICollection<Drink>? Drinks { get; set; }
        public ICollection<Side>? Sides { get; set; }
        public ICollection<Sauce>? Sauces { get; set; }
        public ICollection<Size>? Sizes { get; set; }
        public int Quantity { get; set; }

        public int? UserID { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
