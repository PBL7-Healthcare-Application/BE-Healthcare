using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Add_TableNotification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    IdNotification = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsRead = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdUser = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IdAppointment = table.Column<int>(type: "int", nullable: true),
                    NotificationType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.IdNotification);
                    table.ForeignKey(
                        name: "FK_Notifications_User_IdUser",
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
                values: new object[] { new DateTime(2024, 5, 17, 8, 10, 31, 963, DateTimeKind.Utc).AddTicks(6734), new byte[] { 241, 185, 206, 197, 157, 79, 23, 26, 116, 17, 19, 182, 182, 118, 73, 26, 246, 13, 138, 233, 20, 200, 178, 26, 68, 88, 17, 93, 239, 183, 254, 16 }, new byte[] { 243, 92, 25, 142, 46, 3, 171, 133, 186, 23, 106, 127, 238, 235, 169, 179, 191, 212, 51, 188, 124, 164, 63, 146, 228, 62, 246, 165, 96, 36, 197, 29, 234, 201, 190, 36, 166, 35, 237, 137, 126, 114, 156, 206, 83, 54, 221, 122, 108, 43, 80, 5, 154, 162, 119, 182, 224, 41, 245, 119, 19, 47, 80, 136 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 8, 10, 31, 963, DateTimeKind.Utc).AddTicks(6711), new byte[] { 241, 185, 206, 197, 157, 79, 23, 26, 116, 17, 19, 182, 182, 118, 73, 26, 246, 13, 138, 233, 20, 200, 178, 26, 68, 88, 17, 93, 239, 183, 254, 16 }, new byte[] { 243, 92, 25, 142, 46, 3, 171, 133, 186, 23, 106, 127, 238, 235, 169, 179, 191, 212, 51, 188, 124, 164, 63, 146, 228, 62, 246, 165, 96, 36, 197, 29, 234, 201, 190, 36, 166, 35, 237, 137, 126, 114, 156, 206, 83, 54, 221, 122, 108, 43, 80, 5, 154, 162, 119, 182, 224, 41, 245, 119, 19, 47, 80, 136 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 8, 10, 31, 963, DateTimeKind.Utc).AddTicks(6694), new byte[] { 241, 185, 206, 197, 157, 79, 23, 26, 116, 17, 19, 182, 182, 118, 73, 26, 246, 13, 138, 233, 20, 200, 178, 26, 68, 88, 17, 93, 239, 183, 254, 16 }, new byte[] { 243, 92, 25, 142, 46, 3, 171, 133, 186, 23, 106, 127, 238, 235, 169, 179, 191, 212, 51, 188, 124, 164, 63, 146, 228, 62, 246, 165, 96, 36, 197, 29, 234, 201, 190, 36, 166, 35, 237, 137, 126, 114, 156, 206, 83, 54, 221, 122, 108, 43, 80, 5, 154, 162, 119, 182, 224, 41, 245, 119, 19, 47, 80, 136 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 8, 10, 31, 963, DateTimeKind.Utc).AddTicks(6744), new byte[] { 241, 185, 206, 197, 157, 79, 23, 26, 116, 17, 19, 182, 182, 118, 73, 26, 246, 13, 138, 233, 20, 200, 178, 26, 68, 88, 17, 93, 239, 183, 254, 16 }, new byte[] { 243, 92, 25, 142, 46, 3, 171, 133, 186, 23, 106, 127, 238, 235, 169, 179, 191, 212, 51, 188, 124, 164, 63, 146, 228, 62, 246, 165, 96, 36, 197, 29, 234, 201, 190, 36, 166, 35, 237, 137, 126, 114, 156, 206, 83, 54, 221, 122, 108, 43, 80, 5, 154, 162, 119, 182, 224, 41, 245, 119, 19, 47, 80, 136 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 8, 10, 31, 963, DateTimeKind.Utc).AddTicks(6723), new byte[] { 241, 185, 206, 197, 157, 79, 23, 26, 116, 17, 19, 182, 182, 118, 73, 26, 246, 13, 138, 233, 20, 200, 178, 26, 68, 88, 17, 93, 239, 183, 254, 16 }, new byte[] { 243, 92, 25, 142, 46, 3, 171, 133, 186, 23, 106, 127, 238, 235, 169, 179, 191, 212, 51, 188, 124, 164, 63, 146, 228, 62, 246, 165, 96, 36, 197, 29, 234, 201, 190, 36, 166, 35, 237, 137, 126, 114, 156, 206, 83, 54, 221, 122, 108, 43, 80, 5, 154, 162, 119, 182, 224, 41, 245, 119, 19, 47, 80, 136 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 8, 10, 31, 963, DateTimeKind.Utc).AddTicks(6765), new byte[] { 241, 185, 206, 197, 157, 79, 23, 26, 116, 17, 19, 182, 182, 118, 73, 26, 246, 13, 138, 233, 20, 200, 178, 26, 68, 88, 17, 93, 239, 183, 254, 16 }, new byte[] { 243, 92, 25, 142, 46, 3, 171, 133, 186, 23, 106, 127, 238, 235, 169, 179, 191, 212, 51, 188, 124, 164, 63, 146, 228, 62, 246, 165, 96, 36, 197, 29, 234, 201, 190, 36, 166, 35, 237, 137, 126, 114, 156, 206, 83, 54, 221, 122, 108, 43, 80, 5, 154, 162, 119, 182, 224, 41, 245, 119, 19, 47, 80, 136 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 8, 10, 31, 963, DateTimeKind.Utc).AddTicks(6755), new byte[] { 241, 185, 206, 197, 157, 79, 23, 26, 116, 17, 19, 182, 182, 118, 73, 26, 246, 13, 138, 233, 20, 200, 178, 26, 68, 88, 17, 93, 239, 183, 254, 16 }, new byte[] { 243, 92, 25, 142, 46, 3, 171, 133, 186, 23, 106, 127, 238, 235, 169, 179, 191, 212, 51, 188, 124, 164, 63, 146, 228, 62, 246, 165, 96, 36, 197, 29, 234, 201, 190, 36, 166, 35, 237, 137, 126, 114, 156, 206, 83, 54, 221, 122, 108, 43, 80, 5, 154, 162, 119, 182, 224, 41, 245, 119, 19, 47, 80, 136 } });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_IdUser",
                table: "Notifications",
                column: "IdUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6859), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6832), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6811), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6870), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6844), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6893), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6881), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });
        }
    }
}
