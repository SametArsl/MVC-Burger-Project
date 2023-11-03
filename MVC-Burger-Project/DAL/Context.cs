using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Burger_Project;
using MVC_Burger_Project.DAL.EntityConfigurations;
using MVC_Burger_Project.Models.Entities;
using System.Data;
using System.Reflection.Emit;

namespace MVC_Burger_Project.DAL
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<AppUser>? AppUsers { get; set; }
        public DbSet<AppRole>? AppRoles { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Burger>? Burgers { get; set; }
        public DbSet<Drink>? Drinks { get; set; }
        public DbSet<Sauce>? Sauces { get; set; }
        public DbSet<Ingredient>? Ingredients { get; set; }
        public DbSet<BurgerIngredient>? BurgerIngredients { get; set; }
        public DbSet<Size>? Sizes { get; set; }
        public DbSet<Side>? Sides { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Bill>? Bills { get; set; }
        public DbSet<Menu>? Menus { get; set; }
        public DbSet<Feedback>? Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BurgerIngredient>()
            .HasKey(bi => new { bi.BurgerID, bi.IngredientID });

            builder.Entity<BurgerIngredient>()
                .HasOne(bi => bi.Burger)
                .WithMany(b => b.BurgerIngredients)
                .HasForeignKey(bi => bi.BurgerID);

            builder.Entity<BurgerIngredient>()
                .HasOne(bi => bi.Ingredient)
                .WithMany(i => i.BurgerIngredients)
                .HasForeignKey(bi => bi.IngredientID);

            builder.ApplyConfiguration<Category>(new Category_CFG());
            builder.ApplyConfiguration<Ingredient>(new Ingredient_CFG());
            builder.ApplyConfiguration<AppRole>(new AppRole_CFG());
            builder.ApplyConfiguration<Drink>(new Drink_CFG());
            builder.ApplyConfiguration<Side>(new Side_CFG());
            builder.ApplyConfiguration<Size>(new Size_CFG());
            builder.ApplyConfiguration<Burger>(new Burger_CFG());
            builder.ApplyConfiguration<BurgerIngredient>(new BurgerIngredient_CFG());
            builder.ApplyConfiguration<Menu>(new Menu_CFG());
            builder.ApplyConfiguration<Sauce>(new Sauce_CFG());
            builder.ApplyConfiguration<Bill>(new Bill_CFG());

            base.OnModelCreating(builder);
        }
    }
}
