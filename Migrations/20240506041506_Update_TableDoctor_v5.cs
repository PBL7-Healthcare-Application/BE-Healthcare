using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableDoctor_v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameClinic",
                table: "Doctors",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "NameClinic",
                value: "Phòng khám bác sĩ Thịnh");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "NameClinic",
                value: "Phòng khám bác sĩ Hương");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "NameClinic",
                value: "Phòng khám Bác sĩ Thái Hà");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 6, 4, 15, 6, 7, DateTimeKind.Utc).AddTicks(8164), new byte[] { 252, 16, 141, 210, 121, 86, 78, 251, 202, 78, 8, 220, 134, 165, 131, 101, 32, 128, 39, 79, 93, 30, 6, 174, 128, 10, 76, 44, 126, 209, 137, 229 }, new byte[] { 228, 143, 82, 82, 55, 174, 52, 1, 35, 238, 30, 84, 11, 19, 28, 235, 54, 106, 72, 118, 37, 182, 45, 2, 177, 177, 254, 155, 50, 169, 93, 9, 185, 158, 59, 105, 241, 93, 17, 64, 3, 235, 181, 131, 101, 48, 154, 115, 170, 174, 242, 15, 201, 22, 81, 101, 192, 186, 227, 46, 130, 200, 141, 218 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 6, 4, 15, 6, 7, DateTimeKind.Utc).AddTicks(8140), new byte[] { 252, 16, 141, 210, 121, 86, 78, 251, 202, 78, 8, 220, 134, 165, 131, 101, 32, 128, 39, 79, 93, 30, 6, 174, 128, 10, 76, 44, 126, 209, 137, 229 }, new byte[] { 228, 143, 82, 82, 55, 174, 52, 1, 35, 238, 30, 84, 11, 19, 28, 235, 54, 106, 72, 118, 37, 182, 45, 2, 177, 177, 254, 155, 50, 169, 93, 9, 185, 158, 59, 105, 241, 93, 17, 64, 3, 235, 181, 131, 101, 48, 154, 115, 170, 174, 242, 15, 201, 22, 81, 101, 192, 186, 227, 46, 130, 200, 141, 218 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 6, 4, 15, 6, 7, DateTimeKind.Utc).AddTicks(8123), new byte[] { 252, 16, 141, 210, 121, 86, 78, 251, 202, 78, 8, 220, 134, 165, 131, 101, 32, 128, 39, 79, 93, 30, 6, 174, 128, 10, 76, 44, 126, 209, 137, 229 }, new byte[] { 228, 143, 82, 82, 55, 174, 52, 1, 35, 238, 30, 84, 11, 19, 28, 235, 54, 106, 72, 118, 37, 182, 45, 2, 177, 177, 254, 155, 50, 169, 93, 9, 185, 158, 59, 105, 241, 93, 17, 64, 3, 235, 181, 131, 101, 48, 154, 115, 170, 174, 242, 15, 201, 22, 81, 101, 192, 186, 227, 46, 130, 200, 141, 218 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 6, 4, 15, 6, 7, DateTimeKind.Utc).AddTicks(8404), new byte[] { 252, 16, 141, 210, 121, 86, 78, 251, 202, 78, 8, 220, 134, 165, 131, 101, 32, 128, 39, 79, 93, 30, 6, 174, 128, 10, 76, 44, 126, 209, 137, 229 }, new byte[] { 228, 143, 82, 82, 55, 174, 52, 1, 35, 238, 30, 84, 11, 19, 28, 235, 54, 106, 72, 118, 37, 182, 45, 2, 177, 177, 254, 155, 50, 169, 93, 9, 185, 158, 59, 105, 241, 93, 17, 64, 3, 235, 181, 131, 101, 48, 154, 115, 170, 174, 242, 15, 201, 22, 81, 101, 192, 186, 227, 46, 130, 200, 141, 218 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 6, 4, 15, 6, 7, DateTimeKind.Utc).AddTicks(8153), new byte[] { 252, 16, 141, 210, 121, 86, 78, 251, 202, 78, 8, 220, 134, 165, 131, 101, 32, 128, 39, 79, 93, 30, 6, 174, 128, 10, 76, 44, 126, 209, 137, 229 }, new byte[] { 228, 143, 82, 82, 55, 174, 52, 1, 35, 238, 30, 84, 11, 19, 28, 235, 54, 106, 72, 118, 37, 182, 45, 2, 177, 177, 254, 155, 50, 169, 93, 9, 185, 158, 59, 105, 241, 93, 17, 64, 3, 235, 181, 131, 101, 48, 154, 115, 170, 174, 242, 15, 201, 22, 81, 101, 192, 186, 227, 46, 130, 200, 141, 218 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 6, 4, 15, 6, 7, DateTimeKind.Utc).AddTicks(8417), new byte[] { 252, 16, 141, 210, 121, 86, 78, 251, 202, 78, 8, 220, 134, 165, 131, 101, 32, 128, 39, 79, 93, 30, 6, 174, 128, 10, 76, 44, 126, 209, 137, 229 }, new byte[] { 228, 143, 82, 82, 55, 174, 52, 1, 35, 238, 30, 84, 11, 19, 28, 235, 54, 106, 72, 118, 37, 182, 45, 2, 177, 177, 254, 155, 50, 169, 93, 9, 185, 158, 59, 105, 241, 93, 17, 64, 3, 235, 181, 131, 101, 48, 154, 115, 170, 174, 242, 15, 201, 22, 81, 101, 192, 186, 227, 46, 130, 200, 141, 218 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameClinic",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 5, 17, 45, 21, 640, DateTimeKind.Utc).AddTicks(1639), new byte[] { 1, 196, 25, 61, 133, 37, 189, 47, 103, 118, 58, 146, 185, 8, 179, 47, 176, 202, 200, 73, 127, 90, 81, 131, 255, 27, 149, 218, 192, 184, 147, 63 }, new byte[] { 33, 205, 28, 116, 159, 240, 200, 101, 103, 32, 118, 76, 111, 125, 249, 232, 12, 38, 244, 149, 49, 234, 227, 248, 148, 141, 181, 161, 210, 191, 15, 151, 193, 30, 220, 9, 99, 1, 189, 17, 79, 33, 118, 124, 41, 0, 145, 26, 180, 96, 136, 67, 210, 107, 14, 215, 180, 97, 169, 47, 115, 66, 64, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 5, 17, 45, 21, 640, DateTimeKind.Utc).AddTicks(1610), new byte[] { 1, 196, 25, 61, 133, 37, 189, 47, 103, 118, 58, 146, 185, 8, 179, 47, 176, 202, 200, 73, 127, 90, 81, 131, 255, 27, 149, 218, 192, 184, 147, 63 }, new byte[] { 33, 205, 28, 116, 159, 240, 200, 101, 103, 32, 118, 76, 111, 125, 249, 232, 12, 38, 244, 149, 49, 234, 227, 248, 148, 141, 181, 161, 210, 191, 15, 151, 193, 30, 220, 9, 99, 1, 189, 17, 79, 33, 118, 124, 41, 0, 145, 26, 180, 96, 136, 67, 210, 107, 14, 215, 180, 97, 169, 47, 115, 66, 64, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 5, 17, 45, 21, 640, DateTimeKind.Utc).AddTicks(1589), new byte[] { 1, 196, 25, 61, 133, 37, 189, 47, 103, 118, 58, 146, 185, 8, 179, 47, 176, 202, 200, 73, 127, 90, 81, 131, 255, 27, 149, 218, 192, 184, 147, 63 }, new byte[] { 33, 205, 28, 116, 159, 240, 200, 101, 103, 32, 118, 76, 111, 125, 249, 232, 12, 38, 244, 149, 49, 234, 227, 248, 148, 141, 181, 161, 210, 191, 15, 151, 193, 30, 220, 9, 99, 1, 189, 17, 79, 33, 118, 124, 41, 0, 145, 26, 180, 96, 136, 67, 210, 107, 14, 215, 180, 97, 169, 47, 115, 66, 64, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 5, 17, 45, 21, 640, DateTimeKind.Utc).AddTicks(1653), new byte[] { 1, 196, 25, 61, 133, 37, 189, 47, 103, 118, 58, 146, 185, 8, 179, 47, 176, 202, 200, 73, 127, 90, 81, 131, 255, 27, 149, 218, 192, 184, 147, 63 }, new byte[] { 33, 205, 28, 116, 159, 240, 200, 101, 103, 32, 118, 76, 111, 125, 249, 232, 12, 38, 244, 149, 49, 234, 227, 248, 148, 141, 181, 161, 210, 191, 15, 151, 193, 30, 220, 9, 99, 1, 189, 17, 79, 33, 118, 124, 41, 0, 145, 26, 180, 96, 136, 67, 210, 107, 14, 215, 180, 97, 169, 47, 115, 66, 64, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 5, 17, 45, 21, 640, DateTimeKind.Utc).AddTicks(1626), new byte[] { 1, 196, 25, 61, 133, 37, 189, 47, 103, 118, 58, 146, 185, 8, 179, 47, 176, 202, 200, 73, 127, 90, 81, 131, 255, 27, 149, 218, 192, 184, 147, 63 }, new byte[] { 33, 205, 28, 116, 159, 240, 200, 101, 103, 32, 118, 76, 111, 125, 249, 232, 12, 38, 244, 149, 49, 234, 227, 248, 148, 141, 181, 161, 210, 191, 15, 151, 193, 30, 220, 9, 99, 1, 189, 17, 79, 33, 118, 124, 41, 0, 145, 26, 180, 96, 136, 67, 210, 107, 14, 215, 180, 97, 169, 47, 115, 66, 64, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 5, 17, 45, 21, 640, DateTimeKind.Utc).AddTicks(1666), new byte[] { 1, 196, 25, 61, 133, 37, 189, 47, 103, 118, 58, 146, 185, 8, 179, 47, 176, 202, 200, 73, 127, 90, 81, 131, 255, 27, 149, 218, 192, 184, 147, 63 }, new byte[] { 33, 205, 28, 116, 159, 240, 200, 101, 103, 32, 118, 76, 111, 125, 249, 232, 12, 38, 244, 149, 49, 234, 227, 248, 148, 141, 181, 161, 210, 191, 15, 151, 193, 30, 220, 9, 99, 1, 189, 17, 79, 33, 118, 124, 41, 0, 145, 26, 180, 96, 136, 67, 210, 107, 14, 215, 180, 97, 169, 47, 115, 66, 64, 232 } });
        }
    }
}
