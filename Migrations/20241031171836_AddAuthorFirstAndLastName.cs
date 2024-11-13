using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modi_Naomi_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorFirstAndLastName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Category");
        }
    }
}
