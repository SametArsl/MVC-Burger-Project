namespace MVC_Burger_Project.Models.Entities
{
    public class Bill : BaseEntity
    {
        public int OrderID { get; set; }
        public Order? Order { get; set; }
    }
}
