namespace MVC_Burger_Project.Models.Entities
{
    public class BurgerIngredient
    {
        public int BurgerID { get; set; }
        public int IngredientID { get; set; }

        public Burger? Burger { get; set; }
        public Ingredient? Ingredient { get; set; }
    }
}
