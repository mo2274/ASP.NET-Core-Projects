using Microsoft.EntityFrameworkCore.Migrations;

namespace Pie2Shop.Migrations
{
    public partial class changethenameofthedescriptioncolumnincategorymodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descriprion",
                table: "Categories",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "Descriprion");
        }
    }
}
