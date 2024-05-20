using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableUser_v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.AddColumn<string>(
                name: "latitude",
                table: "User",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "longtitude",
                table: "User",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt", "latitude", "longtitude" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8853), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 }, null, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt", "latitude", "longtitude" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8830), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 }, null, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt", "latitude", "longtitude" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8814), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 }, null, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt", "latitude", "longtitude" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8864), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 }, null, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt", "latitude", "longtitude" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8842), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 }, null, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt", "latitude", "longtitude" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8885), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 }, null, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt", "latitude", "longtitude" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8875), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 }, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "latitude",
                table: "User");

            migrationBuilder.DropColumn(
                name: "longtitude",
                table: "User");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    IdNotification = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUser = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdAppointment = table.Column<int>(type: "int", nullable: true),
                    IsRead = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Message = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
    }
}
