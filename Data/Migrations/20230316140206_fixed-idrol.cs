using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class fixedidrol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_User_rols_IdRol",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_IdRol",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdRol",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdRol",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdRol",
                table: "Users",
                column: "IdRol");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_User_rols_IdRol",
                table: "Users",
                column: "IdRol",
                principalTable: "User_rols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
