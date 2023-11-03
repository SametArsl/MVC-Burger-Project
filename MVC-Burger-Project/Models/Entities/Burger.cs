namespace MVC_Burger_Project.Models.Entities
{
    public class Burger : BaseEntity
    {
        public ICollection<BurgerIngredient>? BurgerIngredients { get; set; }
        public string? Description { get; set; }
        public string Picture { get; set; }
        public int Quantity { get; set; }
        public int CategoryID { get; set; }
        public Category? Category { get; set; }
    }
}
