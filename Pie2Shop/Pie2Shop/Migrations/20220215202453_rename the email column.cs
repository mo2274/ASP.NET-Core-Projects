using Microsoft.EntityFrameworkCore.Migrations;

namespace Pie2Shop.Migrations
{
    public partial class renametheemailcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Enail",
                table: "Orders",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Orders",
                newName: "Enail");
        }
    }
}
