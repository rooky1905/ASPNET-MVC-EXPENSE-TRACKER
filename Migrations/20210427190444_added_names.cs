using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNET_MVC_2._0.Migrations
{
    public partial class added_names : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Items",
                newName: "Lender");

            migrationBuilder.AddColumn<string>(
                name: "Borrower",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Item_Name",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Borrower",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Item_Name",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Lender",
                table: "Items",
                newName: "Name");
        }
    }
}
