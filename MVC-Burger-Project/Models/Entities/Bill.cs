namespace MVC_Burger_Project.Models.Entities
{
    public class Bill : BaseEntity
    {
        public int UserID { get; set; }
        public decimal TotalPrice { get; set; }
        public AppUser AppUser { get; set; }
    }
}
