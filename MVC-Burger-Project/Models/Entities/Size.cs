namespace MVC_Burger_Project.Models.Entities
{
    public class Size : BaseEntity
    {
        public ICollection<Order>? Orders { get; set; }
        public int Quantity { get; set; }
    }
}