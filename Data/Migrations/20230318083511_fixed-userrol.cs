using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class fixeduserrol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_users_t_user_rols_IdRol",
                table: "t_users");

            migrationBuilder.DropIndex(
                name: "IX_t_users_IdRol",
                table: "t_users");

            migrationBuilder.RenameColumn(
                name: "IdRol",
                table: "t_users",
                newName: "UserRol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserRol",
                table: "t_users",
                newName: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_t_users_IdRol",
                table: "t_users",
                column: "IdRol");

            migrationBuilder.AddForeignKey(
                name: "FK_t_users_t_user_rols_IdRol",
                table: "t_users",
                column: "IdRol",
                principalTable: "t_user_rols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
