namespace MVC_Burger_Project.Models.Entities
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
