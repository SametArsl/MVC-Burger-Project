using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Burger_Project.Models.Entities;

namespace MVC_Burger_Project.DAL.EntityConfigurations
{
    public class Drink_CFG : IEntityTypeConfiguration<Drink>
    {
        public void Configure(EntityTypeBuilder<Drink> builder)
        {
            builder.HasData(
                new Drink { ID = 1, Name = "Pepsi", Price = 1M, Picture = "pepsi.png", Quantity = 1 },
                new Drink { ID = 2, Name = "Pepsi-Max", Price = 1M, Picture = "pepsimax.png", Quantity = 1 },
                new Drink { ID = 3, Name = "Pepsi-Twist", Price = 1M, Picture = "pepsitwist.png", Quantity = 1 },
                new Drink { ID = 4, Name = "Pepsi-Mango", Price = 1M, Picture = "pepsimango.png", Quantity = 1 },
                new Drink { ID = 5, Name = "Pepsi-Raspberry", Price = 1M, Picture = "pepsiraspberry.png", Quantity = 1 },
                new Drink { ID = 6, Name = "7UP", Price = 1M, Picture = "7up.png", Quantity = 1 },
                new Drink { ID = 7, Name = "Fanta", Price = 1M, Picture = "fanta.png", Quantity = 1 },
                new Drink { ID = 8, Name = "Ice-Tea Lemon", Price = 1M, Picture = "icetealemon.png", Quantity = 1 },
                new Drink { ID = 9, Name = "Ice-Tea Peach", Price = 1M, Picture = "iceteapeach.png", Quantity = 1 },
                new Drink { ID = 10, Name = "Ayran", Price = 2M, Picture = "ayran.png", Quantity = 1 },
                new Drink { ID = 11, Name = "Chocolate Milkshake", Price = 1.5M, Picture = "chocolatemilkshake.png", Quantity = 1 },
                new Drink { ID = 12, Name = "Strawberry Milkshake", Price = 1.5M, Picture = "strawberrymilkshake.png", Quantity = 1 },
                new Drink { ID = 13, Name = "Vanilla Milkshake", Price = 1.5M, Picture = "vanillamilkshake.png", Quantity = 1 }
                );
        }
    }
}
