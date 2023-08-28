using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Burger_Project.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sauces",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sauces", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sides",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sides", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppRoleId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetRoles_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bills_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Burgers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burgers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Burgers_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Burgers_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DrinkOrder",
                columns: table => new
                {
                    DrinksID = table.Column<int>(type: "int", nullable: false),
                    OrdersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkOrder", x => new { x.DrinksID, x.OrdersID });
                    table.ForeignKey(
                        name: "FK_DrinkOrder_Drinks_DrinksID",
                        column: x => x.DrinksID,
                        principalTable: "Drinks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrinkOrder_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderSauce",
                columns: table => new
                {
                    OrdersID = table.Column<int>(type: "int", nullable: false),
                    SaucesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSauce", x => new { x.OrdersID, x.SaucesID });
                    table.ForeignKey(
                        name: "FK_OrderSauce_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderSauce_Sauces_SaucesID",
                        column: x => x.SaucesID,
                        principalTable: "Sauces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderSide",
                columns: table => new
                {
                    OrdersID = table.Column<int>(type: "int", nullable: false),
                    SidesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSide", x => new { x.OrdersID, x.SidesID });
                    table.ForeignKey(
                        name: "FK_OrderSide_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderSide_Sides_SidesID",
                        column: x => x.SidesID,
                        principalTable: "Sides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderSize",
                columns: table => new
                {
                    OrdersID = table.Column<int>(type: "int", nullable: false),
                    SizesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSize", x => new { x.OrdersID, x.SizesID });
                    table.ForeignKey(
                        name: "FK_OrderSize_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderSize_Sizes_SizesID",
                        column: x => x.SizesID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BurgerIngredients",
                columns: table => new
                {
                    BurgerID = table.Column<int>(type: "int", nullable: false),
                    IngredientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BurgerIngredients", x => new { x.BurgerID, x.IngredientID });
                    table.ForeignKey(
                        name: "FK_BurgerIngredients_Burgers_BurgerID",
                        column: x => x.BurgerID,
                        principalTable: "Burgers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BurgerIngredients_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BurgerID = table.Column<int>(type: "int", nullable: false),
                    DrinkID = table.Column<int>(type: "int", nullable: false),
                    SideID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuID);
                    table.ForeignKey(
                        name: "FK_Menus_Burgers_BurgerID",
                        column: x => x.BurgerID,
                        principalTable: "Burgers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menus_Drinks_DrinkID",
                        column: x => x.DrinkID,
                        principalTable: "Drinks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menus_Sides_SideID",
                        column: x => x.SideID,
                        principalTable: "Sides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menus_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "eb8d917a-03f9-4f8a-97bc-da0405cc00da", "Manager", "MANAGER" },
                    { 2, "5032ef61-6d1d-4ddd-af69-c997ec47ca49", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1, "Hamburgers" },
                    { 2, "Chicken Burgers" },
                    { 3, "Vegetarian Burgers" },
                    { 4, "Vegan Burgers" },
                    { 5, "Sides" },
                    { 6, "Drinks" },
                    { 7, "Sauces" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "ID", "CreationDate", "Name", "Picture", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4604), "Pepsi", "pepsi.jpg", 1m, 1 },
                    { 2, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4606), "Pepsi-Max", "pepsimax.jpg", 1m, 1 },
                    { 3, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4607), "Pepsi-Twist", "pepsitwist.jpg", 1m, 1 },
                    { 4, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4608), "Pepsi-Mango", "pepsimango.jpg", 1m, 1 },
                    { 5, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4610), "Pepsi-Raspberry", "pepsiraspberry.jpg", 1m, 1 },
                    { 6, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4611), "7UP", "7up.jpg", 1m, 1 },
                    { 7, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4612), "Fanta", "fanta.jpg", 1m, 1 },
                    { 8, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4613), "Ice-Tea Lemon", "icetealemon.jpg", 1m, 1 },
                    { 9, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4614), "Ice-Tea Peach", "iceteapeach.jpg", 1m, 1 },
                    { 10, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4615), "Ayran", "ayran.jpg", 2m, 1 },
                    { 11, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4616), "Chocolate Milkshake", "chocolatemilkshake.jpg", 1.5m, 1 },
                    { 12, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4617), "Strawberry Milkshake", "strawberrymilkshake.jpg", 1.5m, 1 },
                    { 13, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4618), "Vanilla Milkshake", "vanillamilkshake.jpg", 1.5m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreationDate", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4358), "Beef Patty", 5m },
                    { 2, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4368), "Spicy Beef Patty", 5m },
                    { 3, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4370), "Double Beef Patty", 8m },
                    { 4, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4371), "Grilled Chicken Patty", 4m },
                    { 5, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4372), "Crispy Fried Chicken Patty", 5m },
                    { 6, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4373), "Veggie Patty", 3m },
                    { 7, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4374), "Portobello Mushroom Patty", 3m },
                    { 8, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4375), "Vegan Patty (Protein-rich)", 4m },
                    { 9, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4376), "Quinoa Black Bean Patty", 5m },
                    { 10, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4377), "Lettuce", 0.25m },
                    { 11, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4379), "Tomato", 0.25m },
                    { 12, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4380), "Onion", 0.25m },
                    { 13, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4381), "Caramelized Onions", 0.25m },
                    { 14, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4382), "Onion Rings", 0.50m },
                    { 15, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4383), "Pickles", 0.25m },
                    { 16, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4384), "Jalapenos", 0.25m },
                    { 17, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4385), "Cheese", 1m },
                    { 18, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4387), "Pepper Jack Cheese", 1m },
                    { 19, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4388), "Swiss Cheese", 1m },
                    { 20, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4389), "Bacon", 1m }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreationDate", "Name", "Price" },
                values: new object[,]
                {
                    { 21, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4390), "Sauteed Mushrooms", 0.50m },
                    { 22, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4391), "Cucumber", 0.25m },
                    { 23, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4392), "Roasted Red Peppers", 0.50m },
                    { 24, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4393), "Arugula", 0.50m },
                    { 25, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4394), "Avocado Slices", 1m },
                    { 26, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4395), "Lime", 0.50m },
                    { 27, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4396), "Roasted Red Peppers", 0.50m },
                    { 28, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4397), "House Sauce", 0.25m },
                    { 29, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4398), "Mustard", 0.25m },
                    { 30, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4399), "Mayo", 0.25m },
                    { 31, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4400), "Chipotle Mayo", 0.25m },
                    { 32, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4401), "Herb Mayo", 0.25m },
                    { 33, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4402), "Ketchup", 0.25m },
                    { 34, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4403), "BBQ Sauce", 0.25m },
                    { 35, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4404), "Tangy Sauce", 0.25m },
                    { 36, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4405), "Balsamic Glaze", 0.25m },
                    { 37, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4406), "Garlic Aioli", 0.25m },
                    { 38, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4407), "Cashew Cream Sauce", 0.25m }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "ID", "CreationDate", "Name", "Picture", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4684), "French Fries", "frenchfries.jpg", 1m, 1 },
                    { 2, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4686), "Curly Fries", "curlyfries.jpg", 1.25m, 1 },
                    { 3, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4688), "Serrated Fries", "serratedfries.jpg", 1m, 1 },
                    { 4, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4689), "Chicken Nuggets", "chickennuggets.jpg", 2m, 1 },
                    { 5, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4690), "Cheese Sticks", "cheesesticks.jpg", 2m, 1 },
                    { 6, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4692), "Onion Rings", "onionrings.jpg", 1m, 1 },
                    { 7, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4693), "Buffalo Wings", "buffalowings.jpg", 2m, 1 },
                    { 8, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4694), "Glaze Donut", "glazedonut.jpg", 1.5m, 1 },
                    { 9, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4695), "Apple Pie", "applepie.jpg", 1.5m, 1 },
                    { 10, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4697), "Souffle", "souffle.jpg", 1.5m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreationDate", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4762), "Small", 0m, 0 },
                    { 2, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4763), "Medium", 1m, 0 },
                    { 3, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4764), "Large", 2m, 0 },
                    { 4, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4766), "X-Large", 3m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "ID", "CategoryID", "CreationDate", "Description", "Name", "OrderID", "Picture", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4857), "A timeless favorite made with juicy beef patty, fresh lettuce, ripe tomatoes, and our special house sauce.", "Classic Beef Burger", null, "classicbeefburger.jpg", 7m, 1 },
                    { 2, 1, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4860), "Indulge in the rich flavors of our savory beef patty topped with melted cheese, caramelized onions, and tangy pickles.", "Savory Beef Burger", null, "savorybeefburger.jpg", 8m, 1 },
                    { 3, 1, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4862), "For those who crave heat, our spicy beef burger features a fiery patty, jalapeños, and pepper jack cheese.", "Spicy Beef Burger", null, "spicybeefburger.jpg", 8m, 1 },
                    { 4, 1, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4863), "Double the cheese, double the satisfaction! Enjoy our beef patty layered with multiple cheese varieties and a burst of flavors.", "Cheese Lover's Beef Burger", null, "cheeseloversbeefburger.jpg", 8m, 1 },
                    { 5, 1, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4864), "Dive into the smoky goodness of our BBQ beef burger, featuring a char-grilled patty, crispy bacon, and tangy barbecue sauce.", "BBQ Beef Burger", null, "bbqbeefburger.jpg", 10m, 1 },
                    { 6, 1, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4866), "A gourmet delight with a beef patty topped with sautéed mushrooms and melted Swiss cheese.", "Mushroom Swiss Beef Burger", null, "mushroomswissbeefburger.jpg", 9m, 1 },
                    { 7, 1, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4867), "For the bacon enthusiasts, our deluxe beef burger includes a generous helping of crispy bacon, lettuce, and creamy mayo.", "Bacon Deluxe Beef Burger", null, "bacondeluxebeefburger.jpg", 10m, 1 },
                    { 8, 1, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4869), "When one patty isn't enough, enjoy the indulgence of a double beef patty burger with all your favorite toppings.", "Double Patty Beef Burger", null, "doublepattybeefburger.jpg", 15m, 1 },
                    { 9, 2, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4870), "A healthier option featuring a tender grilled chicken patty, lettuce, tomatoes, and zesty herb mayo.", "Grilled Chicken Burger", null, "grilledchickenburger.jpg", 8m, 1 },
                    { 10, 2, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4871), "Satisfy your cravings with our crispy fried chicken patty topped with fresh veggies and tangy sauce.", "Crispy Chicken Burger", null, "crispychickenburger.jpg", 9m, 1 },
                    { 11, 3, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4873), "A garden-fresh delight with a hearty veggie patty, lettuce, tomatoes, and a drizzle of balsamic glaze.", "Veggie Delight Burger", null, "veggiedelightburger.jpg", 11m, 1 },
                    { 12, 3, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4874), "Experience the earthy flavors of our portobello mushroom patty topped with roasted red peppers and garlic aioli.", "Portobello Mushroom Burger", null, "portobellomushroomburger.jpg", 12m, 1 },
                    { 13, 4, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4875), "A feast for plant-based eaters, our ultimate vegan burger features a protein-rich patty, avocado, and cashew cream sauce.", "Ultimate Vegan Burger", null, "ultimateveganburger.jpg", 14m, 1 },
                    { 14, 4, new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4878), "Savor the goodness of quinoa and black beans in our vegan burger, complemented by avocado slices and a touch of lime.", "Quinoa Black Bean Burger", null, "quinoablackbeanburger.jpg", 15m, 1 }
                });

            migrationBuilder.InsertData(
                table: "BurgerIngredients",
                columns: new[] { "BurgerID", "IngredientID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 15 },
                    { 1, 28 },
                    { 2, 1 },
                    { 2, 13 },
                    { 2, 15 },
                    { 2, 17 },
                    { 2, 29 },
                    { 3, 2 },
                    { 3, 10 },
                    { 3, 16 },
                    { 3, 18 },
                    { 3, 31 },
                    { 4, 1 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 12 },
                    { 4, 17 },
                    { 4, 19 },
                    { 4, 33 },
                    { 5, 1 },
                    { 5, 14 },
                    { 5, 17 },
                    { 5, 20 },
                    { 5, 34 },
                    { 6, 1 },
                    { 6, 10 },
                    { 6, 19 },
                    { 6, 21 },
                    { 6, 30 },
                    { 7, 1 },
                    { 7, 10 },
                    { 7, 11 },
                    { 7, 20 },
                    { 7, 30 },
                    { 8, 3 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 12 }
                });

            migrationBuilder.InsertData(
                table: "BurgerIngredients",
                columns: new[] { "BurgerID", "IngredientID" },
                values: new object[,]
                {
                    { 8, 15 },
                    { 8, 17 },
                    { 9, 4 },
                    { 9, 10 },
                    { 9, 11 },
                    { 9, 32 },
                    { 10, 5 },
                    { 10, 10 },
                    { 10, 11 },
                    { 10, 15 },
                    { 10, 35 },
                    { 11, 6 },
                    { 11, 10 },
                    { 11, 11 },
                    { 11, 22 },
                    { 11, 36 },
                    { 12, 7 },
                    { 12, 24 },
                    { 12, 27 },
                    { 12, 37 },
                    { 13, 8 },
                    { 13, 10 },
                    { 13, 11 },
                    { 13, 25 },
                    { 13, 38 },
                    { 14, 9 },
                    { 14, 10 },
                    { 14, 11 },
                    { 14, 25 },
                    { 14, 26 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "BurgerID", "DrinkID", "SideID", "SizeID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1 },
                    { 2, 2, 1, 1, 1 },
                    { 3, 3, 1, 1, 1 },
                    { 4, 4, 1, 1, 1 },
                    { 5, 5, 1, 1, 1 },
                    { 6, 6, 1, 1, 1 },
                    { 7, 7, 1, 1, 1 },
                    { 8, 8, 1, 1, 1 },
                    { 9, 9, 1, 1, 1 },
                    { 10, 10, 1, 1, 1 },
                    { 11, 11, 1, 1, 1 },
                    { 12, 12, 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "BurgerID", "DrinkID", "SideID", "SizeID" },
                values: new object[] { 13, 13, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "BurgerID", "DrinkID", "SideID", "SizeID" },
                values: new object[] { 14, 14, 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AppRoleId",
                table: "AspNetUsers",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_OrderID",
                table: "Bills",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_BurgerIngredients_IngredientID",
                table: "BurgerIngredients",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_Burgers_CategoryID",
                table: "Burgers",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Burgers_OrderID",
                table: "Burgers",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_DrinkOrder_OrdersID",
                table: "DrinkOrder",
                column: "OrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_BurgerID",
                table: "Menus",
                column: "BurgerID");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_DrinkID",
                table: "Menus",
                column: "DrinkID");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_SideID",
                table: "Menus",
                column: "SideID");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_SizeID",
                table: "Menus",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSauce_SaucesID",
                table: "OrderSauce",
                column: "SaucesID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSide_SidesID",
                table: "OrderSide",
                column: "SidesID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSize_SizesID",
                table: "OrderSize",
                column: "SizesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "BurgerIngredients");

            migrationBuilder.DropTable(
                name: "DrinkOrder");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "OrderSauce");

            migrationBuilder.DropTable(
                name: "OrderSide");

            migrationBuilder.DropTable(
                name: "OrderSize");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Burgers");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Sauces");

            migrationBuilder.DropTable(
                name: "Sides");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");
        }
    }
}
