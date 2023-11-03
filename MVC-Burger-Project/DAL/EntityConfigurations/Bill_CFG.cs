using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Burger_Project.Models.Entities;

namespace MVC_Burger_Project.DAL.EntityConfigurations
{
    public class Bill_CFG : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasOne(bill => bill.AppUser).WithMany(user => user.Bills).HasForeignKey(bill => bill.UserID);
        }
    }
}
