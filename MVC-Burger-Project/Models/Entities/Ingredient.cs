namespace MVC_Burger_Project.Models.Entities
{
    public class Ingredient : BaseEntity
    {
        public ICollection<BurgerIngredient>? BurgerIngredients { get; set; }
    }
}
