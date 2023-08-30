using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Burger_Project.Models.Entities;

namespace MVC_Burger_Project.DAL.EntityConfigurations
{
    public class Side_CFG : IEntityTypeConfiguration<Side>
    {
        public void Configure(EntityTypeBuilder<Side> builder)
        {
            builder.HasData(
                new Side { ID = 1, Name = "French Fries", Price = 1M, Picture = "frenchfries.png", Quantity = 1 },
                new Side { ID = 2, Name = "Curly Fries", Price = 1.25M, Picture = "curlyfries.png", Quantity = 1 },
                new Side { ID = 3, Name = "Serrated Fries", Price = 1M, Picture = "serratedfries.png", Quantity = 1 },
                new Side { ID = 4, Name = "Chicken Nuggets", Price = 2M, Picture = "chickennuggets.png", Quantity = 1 },
                new Side { ID = 5, Name = "Cheese Sticks", Price = 2M, Picture = "cheesesticks.png", Quantity = 1 },
                new Side { ID = 6, Name = "Onion Rings", Price = 1M, Picture = "onionrings.png", Quantity = 1 },
                new Side { ID = 7, Name = "Buffalo Wings", Price = 2M, Picture = "buffalowings.png", Quantity = 1 },
                new Side { ID = 8, Name = "Glaze Donut", Price = 1.5M, Picture = "glazedonut.png", Quantity = 1 },
                new Side { ID = 9, Name = "Apple Pie", Price = 1.5M, Picture = "applepie.png", Quantity = 1 },
                new Side { ID = 10, Name = "Souffle", Price = 1.5M, Picture = "souffle.png", Quantity = 1 }
                );
        }
    }
}
