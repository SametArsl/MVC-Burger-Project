using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Burger_Project.Models.Entities;

namespace MVC_Burger_Project.DAL.EntityConfigurations
{
    public class Size_CFG : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasData(
                new Size { ID = 1, Name = "Small", Price = 0M },
                new Size { ID = 2, Name = "Medium", Price = 1M },
                new Size { ID = 3, Name = "Large", Price = 2M },
                new Size { ID = 4, Name = "X-Large", Price = 3M }
                );
        }
    }
}
