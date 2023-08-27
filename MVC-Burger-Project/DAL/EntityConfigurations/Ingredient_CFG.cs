using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Burger_Project.Models.Entities;

namespace MVC_Burger_Project.DAL.EntityConfigurations
{
    public class Ingredient_CFG : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasData(
                new Ingredient { ID = 1, Name = "Beef Patty", Price = 5M },
                new Ingredient { ID = 2, Name = "Spicy Beef Patty", Price = 5M },
                new Ingredient { ID = 3, Name = "Double Beef Patty", Price = 8M },
                new Ingredient { ID = 4, Name = "Grilled Chicken Patty", Price = 4M },
                new Ingredient { ID = 5, Name = "Crispy Fried Chicken Patty", Price = 5M },
                new Ingredient { ID = 6, Name = "Veggie Patty", Price = 3M },
                new Ingredient { ID = 7, Name = "Portobello Mushroom Patty", Price = 3M },
                new Ingredient { ID = 8, Name = "Vegan Patty (Protein-rich)", Price = 4M },
                new Ingredient { ID = 9, Name = "Quinoa Black Bean Patty", Price = 5M },
                new Ingredient { ID = 10, Name = "Lettuce", Price = 0.25M },
                new Ingredient { ID = 11, Name = "Tomato", Price = 0.25M },
                new Ingredient { ID = 12, Name = "Onion", Price = 0.25M },
                new Ingredient { ID = 13, Name = "Caramelized Onions", Price = 0.25M },
                new Ingredient { ID = 14, Name = "Onion Rings", Price = 0.50M },
                new Ingredient { ID = 15, Name = "Pickles", Price = 0.25M },
                new Ingredient { ID = 16, Name = "Jalapenos", Price = 0.25M },
                new Ingredient { ID = 17, Name = "Cheese", Price = 1M },
                new Ingredient { ID = 18, Name = "Pepper Jack Cheese", Price = 1M },
                new Ingredient { ID = 19, Name = "Swiss Cheese", Price = 1M },
                new Ingredient { ID = 20, Name = "Bacon", Price = 1M },
                new Ingredient { ID = 21, Name = "Sauteed Mushrooms", Price = 0.50M },
                new Ingredient { ID = 22, Name = "Cucumber", Price = 0.25M },
                new Ingredient { ID = 23, Name = "Roasted Red Peppers", Price = 0.50M },
                new Ingredient { ID = 24, Name = "Arugula", Price = 0.50M },
                new Ingredient { ID = 25, Name = "Avocado Slices", Price = 1M },
                new Ingredient { ID = 26, Name = "Lime", Price = 0.50M },
                new Ingredient { ID = 27, Name = "Roasted Red Peppers", Price = 0.50M },
                new Ingredient { ID = 28, Name = "House Sauce", Price = 0.25M },
                new Ingredient { ID = 29, Name = "Mustard", Price = 0.25M },
                new Ingredient { ID = 30, Name = "Mayo", Price = 0.25M },
                new Ingredient { ID = 31, Name = "Chipotle Mayo", Price = 0.25M },
                new Ingredient { ID = 32, Name = "Herb Mayo", Price = 0.25M },
                new Ingredient { ID = 33, Name = "Ketchup", Price = 0.25M },
                new Ingredient { ID = 34, Name = "BBQ Sauce", Price = 0.25M },
                new Ingredient { ID = 35, Name = "Tangy Sauce", Price = 0.25M },
                new Ingredient { ID = 36, Name = "Balsamic Glaze", Price = 0.25M },
                new Ingredient { ID = 37, Name = "Garlic Aioli", Price = 0.25M },
                new Ingredient { ID = 38, Name = "Cashew Cream Sauce", Price = 0.25M }
                );
        }
    }
}
