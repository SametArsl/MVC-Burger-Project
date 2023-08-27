namespace MVC_Burger_Project.Models.Entities
{
    public class Side : BaseEntity
    {
        public string Picture { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public int Quantity { get; set; }
    }
}