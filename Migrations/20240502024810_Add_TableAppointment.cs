using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Add_TableAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "TimeOffs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    IdAppointment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StartTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EndTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "Date", nullable: true),
                    Issue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IdUser = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.IdAppointment);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_IdDoctor",
                        column: x => x.IdDoctor,
                        principalTable: "Doctors",
                        principalColumn: "IdDoctor");
                    table.ForeignKey(
                        name: "FK_Appointments_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "IdUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 48, 10, 691, DateTimeKind.Utc).AddTicks(6510), new byte[] { 241, 227, 31, 179, 113, 112, 111, 69, 119, 153, 249, 8, 226, 95, 82, 150, 26, 90, 188, 81, 17, 209, 161, 36, 224, 240, 19, 194, 53, 157, 114, 155 }, new byte[] { 96, 238, 82, 115, 10, 18, 234, 74, 63, 6, 90, 228, 33, 154, 6, 15, 41, 205, 75, 246, 56, 171, 227, 116, 254, 193, 241, 108, 175, 35, 179, 35, 122, 60, 56, 142, 216, 7, 124, 222, 159, 76, 136, 104, 122, 21, 122, 126, 142, 4, 103, 74, 196, 20, 25, 200, 183, 107, 45, 213, 166, 114, 198, 38 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 48, 10, 691, DateTimeKind.Utc).AddTicks(6487), new byte[] { 241, 227, 31, 179, 113, 112, 111, 69, 119, 153, 249, 8, 226, 95, 82, 150, 26, 90, 188, 81, 17, 209, 161, 36, 224, 240, 19, 194, 53, 157, 114, 155 }, new byte[] { 96, 238, 82, 115, 10, 18, 234, 74, 63, 6, 90, 228, 33, 154, 6, 15, 41, 205, 75, 246, 56, 171, 227, 116, 254, 193, 241, 108, 175, 35, 179, 35, 122, 60, 56, 142, 216, 7, 124, 222, 159, 76, 136, 104, 122, 21, 122, 126, 142, 4, 103, 74, 196, 20, 25, 200, 183, 107, 45, 213, 166, 114, 198, 38 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 48, 10, 691, DateTimeKind.Utc).AddTicks(6467), new byte[] { 241, 227, 31, 179, 113, 112, 111, 69, 119, 153, 249, 8, 226, 95, 82, 150, 26, 90, 188, 81, 17, 209, 161, 36, 224, 240, 19, 194, 53, 157, 114, 155 }, new byte[] { 96, 238, 82, 115, 10, 18, 234, 74, 63, 6, 90, 228, 33, 154, 6, 15, 41, 205, 75, 246, 56, 171, 227, 116, 254, 193, 241, 108, 175, 35, 179, 35, 122, 60, 56, 142, 216, 7, 124, 222, 159, 76, 136, 104, 122, 21, 122, 126, 142, 4, 103, 74, 196, 20, 25, 200, 183, 107, 45, 213, 166, 114, 198, 38 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 48, 10, 691, DateTimeKind.Utc).AddTicks(6521), new byte[] { 241, 227, 31, 179, 113, 112, 111, 69, 119, 153, 249, 8, 226, 95, 82, 150, 26, 90, 188, 81, 17, 209, 161, 36, 224, 240, 19, 194, 53, 157, 114, 155 }, new byte[] { 96, 238, 82, 115, 10, 18, 234, 74, 63, 6, 90, 228, 33, 154, 6, 15, 41, 205, 75, 246, 56, 171, 227, 116, 254, 193, 241, 108, 175, 35, 179, 35, 122, 60, 56, 142, 216, 7, 124, 222, 159, 76, 136, 104, 122, 21, 122, 126, 142, 4, 103, 74, 196, 20, 25, 200, 183, 107, 45, 213, 166, 114, 198, 38 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 48, 10, 691, DateTimeKind.Utc).AddTicks(6499), new byte[] { 241, 227, 31, 179, 113, 112, 111, 69, 119, 153, 249, 8, 226, 95, 82, 150, 26, 90, 188, 81, 17, 209, 161, 36, 224, 240, 19, 194, 53, 157, 114, 155 }, new byte[] { 96, 238, 82, 115, 10, 18, 234, 74, 63, 6, 90, 228, 33, 154, 6, 15, 41, 205, 75, 246, 56, 171, 227, 116, 254, 193, 241, 108, 175, 35, 179, 35, 122, 60, 56, 142, 216, 7, 124, 222, 159, 76, 136, 104, 122, 21, 122, 126, 142, 4, 103, 74, 196, 20, 25, 200, 183, 107, 45, 213, 166, 114, 198, 38 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 48, 10, 691, DateTimeKind.Utc).AddTicks(6533), new byte[] { 241, 227, 31, 179, 113, 112, 111, 69, 119, 153, 249, 8, 226, 95, 82, 150, 26, 90, 188, 81, 17, 209, 161, 36, 224, 240, 19, 194, 53, 157, 114, 155 }, new byte[] { 96, 238, 82, 115, 10, 18, 234, 74, 63, 6, 90, 228, 33, 154, 6, 15, 41, 205, 75, 246, 56, 171, 227, 116, 254, 193, 241, 108, 175, 35, 179, 35, 122, 60, 56, 142, 216, 7, 124, 222, 159, 76, 136, 104, 122, 21, 122, 126, 142, 4, 103, 74, 196, 20, 25, 200, 183, 107, 45, 213, 166, 114, 198, 38 } });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_IdDoctor",
                table: "Appointments",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_IdUser",
                table: "Appointments",
                column: "IdUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "TimeOffs",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 44, 59, 633, DateTimeKind.Utc).AddTicks(20), new byte[] { 109, 228, 197, 167, 110, 150, 82, 86, 132, 89, 13, 161, 153, 180, 76, 179, 159, 119, 216, 157, 92, 107, 137, 109, 37, 13, 57, 247, 100, 204, 209, 176 }, new byte[] { 136, 239, 91, 222, 24, 93, 11, 139, 181, 147, 201, 103, 67, 6, 54, 135, 7, 28, 45, 158, 17, 161, 153, 100, 32, 176, 71, 37, 50, 95, 6, 147, 178, 226, 15, 84, 233, 71, 8, 19, 84, 34, 240, 81, 179, 56, 89, 33, 0, 225, 113, 161, 137, 94, 40, 110, 172, 38, 131, 85, 252, 219, 234, 194 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 44, 59, 632, DateTimeKind.Utc).AddTicks(9993), new byte[] { 109, 228, 197, 167, 110, 150, 82, 86, 132, 89, 13, 161, 153, 180, 76, 179, 159, 119, 216, 157, 92, 107, 137, 109, 37, 13, 57, 247, 100, 204, 209, 176 }, new byte[] { 136, 239, 91, 222, 24, 93, 11, 139, 181, 147, 201, 103, 67, 6, 54, 135, 7, 28, 45, 158, 17, 161, 153, 100, 32, 176, 71, 37, 50, 95, 6, 147, 178, 226, 15, 84, 233, 71, 8, 19, 84, 34, 240, 81, 179, 56, 89, 33, 0, 225, 113, 161, 137, 94, 40, 110, 172, 38, 131, 85, 252, 219, 234, 194 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 44, 59, 632, DateTimeKind.Utc).AddTicks(9974), new byte[] { 109, 228, 197, 167, 110, 150, 82, 86, 132, 89, 13, 161, 153, 180, 76, 179, 159, 119, 216, 157, 92, 107, 137, 109, 37, 13, 57, 247, 100, 204, 209, 176 }, new byte[] { 136, 239, 91, 222, 24, 93, 11, 139, 181, 147, 201, 103, 67, 6, 54, 135, 7, 28, 45, 158, 17, 161, 153, 100, 32, 176, 71, 37, 50, 95, 6, 147, 178, 226, 15, 84, 233, 71, 8, 19, 84, 34, 240, 81, 179, 56, 89, 33, 0, 225, 113, 161, 137, 94, 40, 110, 172, 38, 131, 85, 252, 219, 234, 194 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 44, 59, 633, DateTimeKind.Utc).AddTicks(34), new byte[] { 109, 228, 197, 167, 110, 150, 82, 86, 132, 89, 13, 161, 153, 180, 76, 179, 159, 119, 216, 157, 92, 107, 137, 109, 37, 13, 57, 247, 100, 204, 209, 176 }, new byte[] { 136, 239, 91, 222, 24, 93, 11, 139, 181, 147, 201, 103, 67, 6, 54, 135, 7, 28, 45, 158, 17, 161, 153, 100, 32, 176, 71, 37, 50, 95, 6, 147, 178, 226, 15, 84, 233, 71, 8, 19, 84, 34, 240, 81, 179, 56, 89, 33, 0, 225, 113, 161, 137, 94, 40, 110, 172, 38, 131, 85, 252, 219, 234, 194 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 44, 59, 633, DateTimeKind.Utc).AddTicks(6), new byte[] { 109, 228, 197, 167, 110, 150, 82, 86, 132, 89, 13, 161, 153, 180, 76, 179, 159, 119, 216, 157, 92, 107, 137, 109, 37, 13, 57, 247, 100, 204, 209, 176 }, new byte[] { 136, 239, 91, 222, 24, 93, 11, 139, 181, 147, 201, 103, 67, 6, 54, 135, 7, 28, 45, 158, 17, 161, 153, 100, 32, 176, 71, 37, 50, 95, 6, 147, 178, 226, 15, 84, 233, 71, 8, 19, 84, 34, 240, 81, 179, 56, 89, 33, 0, 225, 113, 161, 137, 94, 40, 110, 172, 38, 131, 85, 252, 219, 234, 194 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 44, 59, 633, DateTimeKind.Utc).AddTicks(48), new byte[] { 109, 228, 197, 167, 110, 150, 82, 86, 132, 89, 13, 161, 153, 180, 76, 179, 159, 119, 216, 157, 92, 107, 137, 109, 37, 13, 57, 247, 100, 204, 209, 176 }, new byte[] { 136, 239, 91, 222, 24, 93, 11, 139, 181, 147, 201, 103, 67, 6, 54, 135, 7, 28, 45, 158, 17, 161, 153, 100, 32, 176, 71, 37, 50, 95, 6, 147, 178, 226, 15, 84, 233, 71, 8, 19, 84, 34, 240, 81, 179, 56, 89, 33, 0, 225, 113, 161, 137, 94, 40, 110, 172, 38, 131, 85, 252, 219, 234, 194 } });
        }
    }
}
