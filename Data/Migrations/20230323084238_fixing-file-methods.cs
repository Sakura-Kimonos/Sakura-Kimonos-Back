using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class fixingfilemethods : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_products_t_files_IdPhotoFile",
                table: "t_products");

            migrationBuilder.DropIndex(
                name: "IX_t_products_IdPhotoFile",
                table: "t_products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_t_products_IdPhotoFile",
                table: "t_products",
                column: "IdPhotoFile");

            migrationBuilder.AddForeignKey(
                name: "FK_t_products_t_files_IdPhotoFile",
                table: "t_products",
                column: "IdPhotoFile",
                principalTable: "t_files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
