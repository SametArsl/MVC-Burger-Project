using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Burger_Project.Models.Entities;

namespace MVC_Burger_Project.DAL.EntityConfigurations
{
    public class Menu_CFG : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasData(
                new Menu { MenuID = 1, BurgerID = 1, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 },
                new Menu { MenuID = 2, BurgerID = 2, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 },
                new Menu { MenuID = 3, BurgerID = 3, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 },
                new Menu { MenuID = 4, BurgerID = 4, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 },
                new Menu { MenuID = 5, BurgerID = 5, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 },
                new Menu { MenuID = 6, BurgerID = 6, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 },
                new Menu { MenuID = 7, BurgerID = 7, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 },
                new Menu { MenuID = 8, BurgerID = 8, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 },
                new Menu { MenuID = 9, BurgerID = 9, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 },
                new Menu { MenuID = 10, BurgerID = 10, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 },
                new Menu { MenuID = 11, BurgerID = 11, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 },
                new Menu { MenuID = 12, BurgerID = 12, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 },
                new Menu { MenuID = 13, BurgerID = 13, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 },
                new Menu { MenuID = 14, BurgerID = 14, DrinkID = 1, SideID = 1, SizeID = 1, SauceID = 1 }
                );
        }
    }
}
