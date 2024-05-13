using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Create_AdminAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 7, 9, 450, DateTimeKind.Utc).AddTicks(1584), new byte[] { 64, 228, 146, 99, 51, 116, 115, 230, 49, 230, 65, 174, 151, 232, 131, 2, 11, 238, 64, 166, 29, 86, 212, 183, 109, 128, 6, 51, 68, 146, 90, 20 }, new byte[] { 166, 166, 59, 99, 194, 68, 91, 159, 95, 10, 208, 188, 169, 247, 213, 17, 35, 77, 206, 8, 182, 218, 136, 238, 247, 250, 228, 207, 179, 212, 77, 120, 163, 45, 141, 215, 215, 58, 186, 71, 237, 55, 36, 81, 252, 192, 102, 68, 92, 124, 30, 202, 64, 168, 133, 240, 144, 205, 39, 0, 157, 223, 21, 83 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 7, 9, 450, DateTimeKind.Utc).AddTicks(1555), new byte[] { 64, 228, 146, 99, 51, 116, 115, 230, 49, 230, 65, 174, 151, 232, 131, 2, 11, 238, 64, 166, 29, 86, 212, 183, 109, 128, 6, 51, 68, 146, 90, 20 }, new byte[] { 166, 166, 59, 99, 194, 68, 91, 159, 95, 10, 208, 188, 169, 247, 213, 17, 35, 77, 206, 8, 182, 218, 136, 238, 247, 250, 228, 207, 179, 212, 77, 120, 163, 45, 141, 215, 215, 58, 186, 71, 237, 55, 36, 81, 252, 192, 102, 68, 92, 124, 30, 202, 64, 168, 133, 240, 144, 205, 39, 0, 157, 223, 21, 83 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 7, 9, 450, DateTimeKind.Utc).AddTicks(1537), new byte[] { 64, 228, 146, 99, 51, 116, 115, 230, 49, 230, 65, 174, 151, 232, 131, 2, 11, 238, 64, 166, 29, 86, 212, 183, 109, 128, 6, 51, 68, 146, 90, 20 }, new byte[] { 166, 166, 59, 99, 194, 68, 91, 159, 95, 10, 208, 188, 169, 247, 213, 17, 35, 77, 206, 8, 182, 218, 136, 238, 247, 250, 228, 207, 179, 212, 77, 120, 163, 45, 141, 215, 215, 58, 186, 71, 237, 55, 36, 81, 252, 192, 102, 68, 92, 124, 30, 202, 64, 168, 133, 240, 144, 205, 39, 0, 157, 223, 21, 83 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 7, 9, 450, DateTimeKind.Utc).AddTicks(1596), new byte[] { 64, 228, 146, 99, 51, 116, 115, 230, 49, 230, 65, 174, 151, 232, 131, 2, 11, 238, 64, 166, 29, 86, 212, 183, 109, 128, 6, 51, 68, 146, 90, 20 }, new byte[] { 166, 166, 59, 99, 194, 68, 91, 159, 95, 10, 208, 188, 169, 247, 213, 17, 35, 77, 206, 8, 182, 218, 136, 238, 247, 250, 228, 207, 179, 212, 77, 120, 163, 45, 141, 215, 215, 58, 186, 71, 237, 55, 36, 81, 252, 192, 102, 68, 92, 124, 30, 202, 64, 168, 133, 240, 144, 205, 39, 0, 157, 223, 21, 83 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 7, 9, 450, DateTimeKind.Utc).AddTicks(1570), new byte[] { 64, 228, 146, 99, 51, 116, 115, 230, 49, 230, 65, 174, 151, 232, 131, 2, 11, 238, 64, 166, 29, 86, 212, 183, 109, 128, 6, 51, 68, 146, 90, 20 }, new byte[] { 166, 166, 59, 99, 194, 68, 91, 159, 95, 10, 208, 188, 169, 247, 213, 17, 35, 77, 206, 8, 182, 218, 136, 238, 247, 250, 228, 207, 179, 212, 77, 120, 163, 45, 141, 215, 215, 58, 186, 71, 237, 55, 36, 81, 252, 192, 102, 68, 92, 124, 30, 202, 64, 168, 133, 240, 144, 205, 39, 0, 157, 223, 21, 83 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 7, 9, 450, DateTimeKind.Utc).AddTicks(1609), new byte[] { 64, 228, 146, 99, 51, 116, 115, 230, 49, 230, 65, 174, 151, 232, 131, 2, 11, 238, 64, 166, 29, 86, 212, 183, 109, 128, 6, 51, 68, 146, 90, 20 }, new byte[] { 166, 166, 59, 99, 194, 68, 91, 159, 95, 10, 208, 188, 169, 247, 213, 17, 35, 77, 206, 8, 182, 218, 136, 238, 247, 250, 228, 207, 179, 212, 77, 120, 163, 45, 141, 215, 215, 58, 186, 71, 237, 55, 36, 81, 252, 192, 102, 68, 92, 124, 30, 202, 64, 168, 133, 240, 144, 205, 39, 0, 157, 223, 21, 83 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 7, 15, 7, 906, DateTimeKind.Utc).AddTicks(3364), new byte[] { 171, 41, 190, 13, 92, 19, 161, 126, 163, 132, 5, 45, 26, 109, 1, 176, 92, 89, 180, 100, 3, 170, 206, 72, 215, 236, 238, 106, 162, 7, 42, 4 }, new byte[] { 22, 36, 86, 150, 197, 60, 86, 177, 190, 89, 86, 20, 214, 239, 163, 213, 164, 157, 12, 219, 109, 106, 217, 249, 63, 198, 153, 200, 244, 72, 15, 217, 228, 252, 100, 206, 236, 82, 60, 161, 177, 129, 154, 159, 10, 176, 210, 139, 132, 109, 13, 200, 57, 79, 106, 226, 179, 5, 149, 105, 115, 43, 49, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 7, 15, 7, 906, DateTimeKind.Utc).AddTicks(3335), new byte[] { 171, 41, 190, 13, 92, 19, 161, 126, 163, 132, 5, 45, 26, 109, 1, 176, 92, 89, 180, 100, 3, 170, 206, 72, 215, 236, 238, 106, 162, 7, 42, 4 }, new byte[] { 22, 36, 86, 150, 197, 60, 86, 177, 190, 89, 86, 20, 214, 239, 163, 213, 164, 157, 12, 219, 109, 106, 217, 249, 63, 198, 153, 200, 244, 72, 15, 217, 228, 252, 100, 206, 236, 82, 60, 161, 177, 129, 154, 159, 10, 176, 210, 139, 132, 109, 13, 200, 57, 79, 106, 226, 179, 5, 149, 105, 115, 43, 49, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 7, 15, 7, 906, DateTimeKind.Utc).AddTicks(3317), new byte[] { 171, 41, 190, 13, 92, 19, 161, 126, 163, 132, 5, 45, 26, 109, 1, 176, 92, 89, 180, 100, 3, 170, 206, 72, 215, 236, 238, 106, 162, 7, 42, 4 }, new byte[] { 22, 36, 86, 150, 197, 60, 86, 177, 190, 89, 86, 20, 214, 239, 163, 213, 164, 157, 12, 219, 109, 106, 217, 249, 63, 198, 153, 200, 244, 72, 15, 217, 228, 252, 100, 206, 236, 82, 60, 161, 177, 129, 154, 159, 10, 176, 210, 139, 132, 109, 13, 200, 57, 79, 106, 226, 179, 5, 149, 105, 115, 43, 49, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 7, 15, 7, 906, DateTimeKind.Utc).AddTicks(3376), new byte[] { 171, 41, 190, 13, 92, 19, 161, 126, 163, 132, 5, 45, 26, 109, 1, 176, 92, 89, 180, 100, 3, 170, 206, 72, 215, 236, 238, 106, 162, 7, 42, 4 }, new byte[] { 22, 36, 86, 150, 197, 60, 86, 177, 190, 89, 86, 20, 214, 239, 163, 213, 164, 157, 12, 219, 109, 106, 217, 249, 63, 198, 153, 200, 244, 72, 15, 217, 228, 252, 100, 206, 236, 82, 60, 161, 177, 129, 154, 159, 10, 176, 210, 139, 132, 109, 13, 200, 57, 79, 106, 226, 179, 5, 149, 105, 115, 43, 49, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 7, 15, 7, 906, DateTimeKind.Utc).AddTicks(3349), new byte[] { 171, 41, 190, 13, 92, 19, 161, 126, 163, 132, 5, 45, 26, 109, 1, 176, 92, 89, 180, 100, 3, 170, 206, 72, 215, 236, 238, 106, 162, 7, 42, 4 }, new byte[] { 22, 36, 86, 150, 197, 60, 86, 177, 190, 89, 86, 20, 214, 239, 163, 213, 164, 157, 12, 219, 109, 106, 217, 249, 63, 198, 153, 200, 244, 72, 15, 217, 228, 252, 100, 206, 236, 82, 60, 161, 177, 129, 154, 159, 10, 176, 210, 139, 132, 109, 13, 200, 57, 79, 106, 226, 179, 5, 149, 105, 115, 43, 49, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 7, 15, 7, 906, DateTimeKind.Utc).AddTicks(3388), new byte[] { 171, 41, 190, 13, 92, 19, 161, 126, 163, 132, 5, 45, 26, 109, 1, 176, 92, 89, 180, 100, 3, 170, 206, 72, 215, 236, 238, 106, 162, 7, 42, 4 }, new byte[] { 22, 36, 86, 150, 197, 60, 86, 177, 190, 89, 86, 20, 214, 239, 163, 213, 164, 157, 12, 219, 109, 106, 217, 249, 63, 198, 153, 200, 244, 72, 15, 217, 228, 252, 100, 206, 236, 82, 60, 161, 177, 129, 154, 159, 10, 176, 210, 139, 132, 109, 13, 200, 57, 79, 106, 226, 179, 5, 149, 105, 115, 43, 49, 40 } });
        }
    }
}
