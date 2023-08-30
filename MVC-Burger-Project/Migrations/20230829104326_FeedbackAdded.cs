using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Burger_Project.Migrations
{
    public partial class FeedbackAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ae6d5f3c-e048-4490-8666-898d548995b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5cc9c1ae-7904-4033-81e6-1e31f648fc27");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8783), "classicbeefburger.png" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8785), "savorybeefburger.png" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8786), "spicybeefburger.png" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8788), "cheeseloversbeefburger.png" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8789), "bbqbeefburger.png" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8790), "mushroomswissbeefburger.png" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8792), "bacondeluxebeefburger.png" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8793), "doublepattybeefburger.png" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8794), "grilledchickenburger.png" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8795), "crispychickenburger.png" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8797), "veggiedelightburger.png" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8798), "portobellomushroomburger.png" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8800), "ultimateveganburger.png" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8803), "quinoablackbeanburger.png" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 8, 29, 13, 43, 25, 460, DateTimeKind.Local).AddTicks(8717));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "eb8d917a-03f9-4f8a-97bc-da0405cc00da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5032ef61-6d1d-4ddd-af69-c997ec47ca49");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4857), "classicbeefburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4860), "savorybeefburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4862), "spicybeefburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4863), "cheeseloversbeefburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4864), "bbqbeefburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4866), "mushroomswissbeefburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4867), "bacondeluxebeefburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4869), "doublepattybeefburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4870), "grilledchickenburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4871), "crispychickenburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4873), "veggiedelightburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4874), "portobellomushroomburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4875), "ultimateveganburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationDate", "Picture" },
                values: new object[] { new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4878), "quinoablackbeanburger.jpg" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Sides",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 8, 28, 10, 1, 58, 607, DateTimeKind.Local).AddTicks(4766));
        }
    }
}
