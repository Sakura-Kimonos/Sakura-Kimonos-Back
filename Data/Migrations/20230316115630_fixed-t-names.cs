using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class fixedtnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rols_authorizations_Eendpoint_authorizations_IdAuthorization",
                table: "Rols_authorizations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Eendpoint_authorizations",
                table: "Eendpoint_authorizations");

            migrationBuilder.RenameTable(
                name: "Eendpoint_authorizations",
                newName: "Endpoint_authorizations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endpoint_authorizations",
                table: "Endpoint_authorizations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rols_authorizations_Endpoint_authorizations_IdAuthorization",
                table: "Rols_authorizations",
                column: "IdAuthorization",
                principalTable: "Endpoint_authorizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rols_authorizations_Endpoint_authorizations_IdAuthorization",
                table: "Rols_authorizations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endpoint_authorizations",
                table: "Endpoint_authorizations");

            migrationBuilder.RenameTable(
                name: "Endpoint_authorizations",
                newName: "Eendpoint_authorizations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Eendpoint_authorizations",
                table: "Eendpoint_authorizations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rols_authorizations_Eendpoint_authorizations_IdAuthorization",
                table: "Rols_authorizations",
                column: "IdAuthorization",
                principalTable: "Eendpoint_authorizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
