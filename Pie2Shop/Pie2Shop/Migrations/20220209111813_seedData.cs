using Microsoft.EntityFrameworkCore.Migrations;

namespace Pie2Shop.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 1, null, "Fruit pies" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 2, null, "Cheese Cakes" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 3, null, "Seasonal pies" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "/Images/carousel2.jpg", "", true, true, "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ", "Apple Pie", 12.95m, "Our famous apple pies!" },
                    { 2, "", 1, "/Images/carousel2.jpg", "", true, false, "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ", "Apple Pie", 12.95m, "Our famous apple pies!" },
                    { 3, "", 1, "/Images/carousel2.jpg", "", true, false, "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ", "Apple Pie", 12.95m, "Our famous apple pies!" },
                    { 4, "", 1, "/Images/carousel2.jpg", "", true, false, "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ", "Apple Pie", 12.95m, "Our famous apple pies!" },
                    { 5, "", 1, "/Images/carousel2.jpg", "", true, false, "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ", "Apple Pie", 12.95m, "Our famous apple pies!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);
        }
    }
}
