using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_UserTable_ChangeAttribute_IsVerified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VerifiedAt",
                table: "User");

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "User",
                type: "tinyint(1)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "User");

            migrationBuilder.AddColumn<DateTime>(
                name: "VerifiedAt",
                table: "User",
                type: "datetime(6)",
                nullable: true);
        }
    }
}
