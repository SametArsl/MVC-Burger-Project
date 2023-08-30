using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Burger_Project.Models.Entities;
using System.Xml.Linq;

namespace MVC_Burger_Project.DAL.EntityConfigurations
{
    public class Burger_CFG : IEntityTypeConfiguration<Burger>
    {
        public void Configure(EntityTypeBuilder<Burger> builder)
        {
            builder.HasData(
                new Burger
                {
                    ID = 1,
                    Name = "Classic Beef Burger",
                    CategoryID = 1,
                    Description = "A timeless favorite made with juicy beef patty, fresh lettuce, ripe tomatoes, and our special house sauce.",
                    Price = 7M,
                    Picture = "classicbeefburger.png",
                    Quantity = 1,
                },
                new Burger
                {
                    ID = 2,
                    Name = "Savory Beef Burger",
                    CategoryID = 1,
                    Description = "Indulge in the rich flavors of our savory beef patty topped with melted cheese, caramelized onions, and tangy pickles.",
                    Price = 8M,
                    Picture = "savorybeefburger.png",
                    Quantity = 1,
                },
                new Burger
                {
                    ID = 3,
                    Name = "Spicy Beef Burger",
                    CategoryID = 1,
                    Description = "For those who crave heat, our spicy beef burger features a fiery patty, jalapeños, and pepper jack cheese.",
                    Price = 8M,
                    Picture = "spicybeefburger.png",
                    Quantity = 1,
                },
                new Burger
                {
                    ID = 4,
                    Name = "Cheese Lover's Beef Burger",
                    CategoryID = 1,
                    Description = "Double the cheese, double the satisfaction! Enjoy our beef patty layered with multiple cheese varieties and a burst of flavors.",
                    Price = 8M,
                    Picture = "cheeseloversbeefburger.png",
                    Quantity = 1,
                },
                new Burger
                {
                    ID = 5,
                    Name = "BBQ Beef Burger",
                    CategoryID = 1,
                    Description = "Dive into the smoky goodness of our BBQ beef burger, featuring a char-grilled patty, crispy bacon, and tangy barbecue sauce.",
                    Price = 10M,
                    Picture = "bbqbeefburger.png",
                    Quantity = 1,
                },
                new Burger
                {
                    ID = 6,
                    Name = "Mushroom Swiss Beef Burger",
                    CategoryID = 1,
                    Description = "A gourmet delight with a beef patty topped with sautéed mushrooms and melted Swiss cheese.",
                    Price = 9M,
                    Picture = "mushroomswissbeefburger.png",
                    Quantity = 1,
                },
                new Burger
                {
                    ID = 7,
                    Name = "Bacon Deluxe Beef Burger",
                    CategoryID = 1,
                    Description = "For the bacon enthusiasts, our deluxe beef burger includes a generous helping of crispy bacon, lettuce, and creamy mayo.",
                    Price = 10M,
                    Picture = "bacondeluxebeefburger.png",
                    Quantity = 1,
                },
                new Burger
                {
                    ID = 8,
                    Name = "Double Patty Beef Burger",
                    CategoryID = 1,
                    Description = "When one patty isn't enough, enjoy the indulgence of a double beef patty burger with all your favorite toppings.",
                    Price = 15M,
                    Picture = "doublepattybeefburger.png",
                    Quantity = 1,
                },
                new Burger
                {
                    ID = 9,
                    Name = "Grilled Chicken Burger",
                    CategoryID = 2,
                    Description = "A healthier option featuring a tender grilled chicken patty, lettuce, tomatoes, and zesty herb mayo.",
                    Price = 8M,
                    Picture = "grilledchickenburger.png",
                    Quantity = 1,
                },
                new Burger
                {
                    ID = 10,
                    Name = "Crispy Chicken Burger",
                    CategoryID = 2,
                    Description = "Satisfy your cravings with our crispy fried chicken patty topped with fresh veggies and tangy sauce.",
                    Price = 9M,
                    Picture = "crispychickenburger.png",
                    Quantity = 1,
                },
                new Burger
                {
                    ID = 11,
                    Name = "Veggie Delight Burger",
                    CategoryID = 3,
                    Description = "A garden-fresh delight with a hearty veggie patty, lettuce, tomatoes, and a drizzle of balsamic glaze.",
                    Price = 11M,
                    Picture = "veggiedelightburger.png",
                    Quantity = 1,
                },
                new Burger
                {
                    ID = 12,
                    Name = "Portobello Mushroom Burger",
                    CategoryID = 3,
                    Description = "Experience the earthy flavors of our portobello mushroom patty topped with roasted red peppers and garlic aioli.",
                    Price = 12M,
                    Picture = "portobellomushroomburger.png",
                    Quantity = 1,
                },
                new Burger
                {
                    ID = 13,
                    Name = "Ultimate Vegan Burger",
                    CategoryID = 4,
                    Description = "A feast for plant-based eaters, our ultimate vegan burger features a protein-rich patty, avocado, and cashew cream sauce.",
                    Price = 14M,
                    Picture = "ultimateveganburger.png",
                    Quantity = 1,
                },
                new Burger
                {
                    ID = 14,
                    Name = "Quinoa Black Bean Burger",
                    CategoryID = 4,
                    Description = "Savor the goodness of quinoa and black beans in our vegan burger, complemented by avocado slices and a touch of lime.",
                    Price = 15M,
                    Picture = "quinoablackbeanburger.png",
                    Quantity = 1,
                }
                );
        }
    }
}
