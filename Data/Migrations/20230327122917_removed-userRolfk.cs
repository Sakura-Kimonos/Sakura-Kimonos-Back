using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class removeduserRolfk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_users_t_userRol_Rol",
                table: "t_users");

            migrationBuilder.DropIndex(
                name: "IX_t_users_Rol",
                table: "t_users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_t_users_Rol",
                table: "t_users",
                column: "Rol");

            migrationBuilder.AddForeignKey(
                name: "FK_t_users_t_userRol_Rol",
                table: "t_users",
                column: "Rol",
                principalTable: "t_userRol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
