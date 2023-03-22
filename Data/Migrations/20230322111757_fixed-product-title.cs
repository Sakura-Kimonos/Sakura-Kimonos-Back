using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class fixedproducttitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "t_products",
                newName: "Units");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "t_products",
                newName: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Units",
                table: "t_products",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "t_products",
                newName: "Name");
        }
    }
}
