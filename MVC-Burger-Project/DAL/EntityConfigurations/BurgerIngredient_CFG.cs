using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Burger_Project.Models.Entities;
using System.Reflection.Emit;

namespace MVC_Burger_Project.DAL.EntityConfigurations
{
    public class BurgerIngredient_CFG : IEntityTypeConfiguration<BurgerIngredient>
    {
        public void Configure(EntityTypeBuilder<BurgerIngredient> builder)
        {
            builder.HasData(
                new BurgerIngredient { BurgerID = 1, IngredientID = 1 },
                new BurgerIngredient { BurgerID = 1, IngredientID = 10 },
                new BurgerIngredient { BurgerID = 1, IngredientID = 11 },
                new BurgerIngredient { BurgerID = 1, IngredientID = 12 },
                new BurgerIngredient { BurgerID = 1, IngredientID = 15 },
                new BurgerIngredient { BurgerID = 1, IngredientID = 28 },
                new BurgerIngredient { BurgerID = 2, IngredientID = 1 },
                new BurgerIngredient { BurgerID = 2, IngredientID = 17 },
                new BurgerIngredient { BurgerID = 2, IngredientID = 13 },
                new BurgerIngredient { BurgerID = 2, IngredientID = 15 },
                new BurgerIngredient { BurgerID = 2, IngredientID = 29 },
                new BurgerIngredient { BurgerID = 3, IngredientID = 2 },
                new BurgerIngredient { BurgerID = 3, IngredientID = 16 },
                new BurgerIngredient { BurgerID = 3, IngredientID = 18 },
                new BurgerIngredient { BurgerID = 3, IngredientID = 10 },
                new BurgerIngredient { BurgerID = 3, IngredientID = 31 },
                new BurgerIngredient { BurgerID = 4, IngredientID = 1 },
                new BurgerIngredient { BurgerID = 4, IngredientID = 17 },
                new BurgerIngredient { BurgerID = 4, IngredientID = 19 },
                new BurgerIngredient { BurgerID = 4, IngredientID = 10 },
                new BurgerIngredient { BurgerID = 4, IngredientID = 11 },
                new BurgerIngredient { BurgerID = 4, IngredientID = 12 },
                new BurgerIngredient { BurgerID = 4, IngredientID = 33 },
                new BurgerIngredient { BurgerID = 5, IngredientID = 1 },
                new BurgerIngredient { BurgerID = 5, IngredientID = 20 },
                new BurgerIngredient { BurgerID = 5, IngredientID = 17 },
                new BurgerIngredient { BurgerID = 5, IngredientID = 14 },
                new BurgerIngredient { BurgerID = 5, IngredientID = 34 },
                new BurgerIngredient { BurgerID = 6, IngredientID = 1 },
                new BurgerIngredient { BurgerID = 6, IngredientID = 19 },
                new BurgerIngredient { BurgerID = 6, IngredientID = 21 },
                new BurgerIngredient { BurgerID = 6, IngredientID = 10 },
                new BurgerIngredient { BurgerID = 6, IngredientID = 30 },
                new BurgerIngredient { BurgerID = 7, IngredientID = 1 },
                new BurgerIngredient { BurgerID = 7, IngredientID = 20 },
                new BurgerIngredient { BurgerID = 7, IngredientID = 10 },
                new BurgerIngredient { BurgerID = 7, IngredientID = 11 },
                new BurgerIngredient { BurgerID = 7, IngredientID = 30 },
                new BurgerIngredient { BurgerID = 8, IngredientID = 3 },
                new BurgerIngredient { BurgerID = 8, IngredientID = 17 },
                new BurgerIngredient { BurgerID = 8, IngredientID = 10 },
                new BurgerIngredient { BurgerID = 8, IngredientID = 11 },
                new BurgerIngredient { BurgerID = 8, IngredientID = 12 },
                new BurgerIngredient { BurgerID = 8, IngredientID = 15 },
                new BurgerIngredient { BurgerID = 9, IngredientID = 4 },
                new BurgerIngredient { BurgerID = 9, IngredientID = 10 },
                new BurgerIngredient { BurgerID = 9, IngredientID = 11 },
                new BurgerIngredient { BurgerID = 9, IngredientID = 32 },
                new BurgerIngredient { BurgerID = 10, IngredientID = 5 },
                new BurgerIngredient { BurgerID = 10, IngredientID = 10 },
                new BurgerIngredient { BurgerID = 10, IngredientID = 11 },
                new BurgerIngredient { BurgerID = 10, IngredientID = 15 },
                new BurgerIngredient { BurgerID = 10, IngredientID = 35 },
                new BurgerIngredient { BurgerID = 11, IngredientID = 6 },
                new BurgerIngredient { BurgerID = 11, IngredientID = 10 },
                new BurgerIngredient { BurgerID = 11, IngredientID = 11 },
                new BurgerIngredient { BurgerID = 11, IngredientID = 22 },
                new BurgerIngredient { BurgerID = 11, IngredientID = 36 },
                new BurgerIngredient { BurgerID = 12, IngredientID = 7 },
                new BurgerIngredient { BurgerID = 12, IngredientID = 27 },
                new BurgerIngredient { BurgerID = 12, IngredientID = 24 },
                new BurgerIngredient { BurgerID = 12, IngredientID = 37 },
                new BurgerIngredient { BurgerID = 13, IngredientID = 8 },
                new BurgerIngredient { BurgerID = 13, IngredientID = 25 },
                new BurgerIngredient { BurgerID = 13, IngredientID = 10 },
                new BurgerIngredient { BurgerID = 13, IngredientID = 11 },
                new BurgerIngredient { BurgerID = 13, IngredientID = 38 },
                new BurgerIngredient { BurgerID = 14, IngredientID = 9 },
                new BurgerIngredient { BurgerID = 14, IngredientID = 25 },
                new BurgerIngredient { BurgerID = 14, IngredientID = 26 },
                new BurgerIngredient { BurgerID = 14, IngredientID = 10 },
                new BurgerIngredient { BurgerID = 14, IngredientID = 11 }
                );
        }
    }
}
