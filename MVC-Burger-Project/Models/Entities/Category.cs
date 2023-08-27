namespace MVC_Burger_Project.Models.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public ICollection<Burger>? Burgers { get; set; }
    }
}
