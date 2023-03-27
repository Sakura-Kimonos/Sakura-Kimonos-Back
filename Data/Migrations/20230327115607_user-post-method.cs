using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class userpostmethod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "t_users",
                newName: "ShippingAddress");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "t_users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "t_users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "t_users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "t_users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "t_users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "t_users");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "t_users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "t_users");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress",
                table: "t_users",
                newName: "UserName");
        }
    }
}
