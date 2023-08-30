using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Burger_Project.Models.Entities;

namespace MVC_Burger_Project.DAL.EntityConfigurations
{
    public class Sauce_CFG : IEntityTypeConfiguration<Sauce>
    {
        public void Configure(EntityTypeBuilder<Sauce> builder)
        {
            builder.HasData(
                new Sauce { ID = 1, Name = "Mayonese", Price = 0.25M, Picture = "mayonese.png", Quantity = 1 },
                new Sauce { ID = 2, Name = "Herb Mayo", Price = 0.25M, Picture = "herbmayo.png", Quantity = 1 },
                new Sauce { ID = 3, Name = "Ketchup", Price = 0.25M, Picture = "ketchup.png", Quantity = 1 },
                new Sauce { ID = 4, Name = "Mustard", Price = 0.25M, Picture = "mustard.png", Quantity = 1 },
                new Sauce { ID = 5, Name = "Honey Mustard", Price = 0.25M, Picture = "honeymustard.png", Quantity = 1 },
                new Sauce { ID = 6, Name = "BBQ", Price = 0.25M, Picture = "bbq.png", Quantity = 1 },
                new Sauce { ID = 7, Name = "Buffalo", Price = 0.25M, Picture = "buffalo.png", Quantity = 1 },
                new Sauce { ID = 8, Name = "Ranch", Price = 0.25M, Picture = "ranch.png", Quantity = 1 }
                );
        }
    }
}
