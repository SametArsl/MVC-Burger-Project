using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Burger_Project.Models.Entities;

namespace MVC_Burger_Project.DAL.EntityConfigurations
{
    public class Category_CFG : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { CategoryID = 1, Name = "Hamburgers" },
                new Category { CategoryID = 2, Name = "Chicken Burgers" },
                new Category { CategoryID = 3, Name = "Vegetarian Burgers" },
                new Category { CategoryID = 4, Name = "Vegan Burgers" },
                new Category { CategoryID = 5, Name = "Sides" },
                new Category { CategoryID = 6, Name = "Drinks" },
                new Category { CategoryID = 7, Name = "Sauces" }
                );
        }
    }
}
