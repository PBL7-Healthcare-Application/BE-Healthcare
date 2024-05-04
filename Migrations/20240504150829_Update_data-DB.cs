using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_dataDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 15, 8, 29, 730, DateTimeKind.Utc).AddTicks(1459), new byte[] { 175, 119, 100, 33, 81, 67, 229, 253, 8, 33, 209, 250, 91, 15, 147, 172, 204, 114, 142, 25, 156, 153, 224, 73, 117, 182, 62, 153, 99, 50, 140, 217 }, new byte[] { 31, 139, 91, 134, 7, 28, 176, 227, 240, 61, 38, 210, 153, 20, 22, 143, 1, 181, 87, 96, 70, 108, 88, 183, 192, 92, 225, 230, 28, 36, 12, 195, 157, 75, 77, 104, 135, 225, 176, 248, 64, 118, 43, 139, 186, 97, 68, 8, 199, 246, 27, 201, 31, 24, 209, 46, 57, 188, 164, 51, 14, 105, 49, 91 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 15, 8, 29, 730, DateTimeKind.Utc).AddTicks(1429), new byte[] { 175, 119, 100, 33, 81, 67, 229, 253, 8, 33, 209, 250, 91, 15, 147, 172, 204, 114, 142, 25, 156, 153, 224, 73, 117, 182, 62, 153, 99, 50, 140, 217 }, new byte[] { 31, 139, 91, 134, 7, 28, 176, 227, 240, 61, 38, 210, 153, 20, 22, 143, 1, 181, 87, 96, 70, 108, 88, 183, 192, 92, 225, 230, 28, 36, 12, 195, 157, 75, 77, 104, 135, 225, 176, 248, 64, 118, 43, 139, 186, 97, 68, 8, 199, 246, 27, 201, 31, 24, 209, 46, 57, 188, 164, 51, 14, 105, 49, 91 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 15, 8, 29, 730, DateTimeKind.Utc).AddTicks(1407), new byte[] { 175, 119, 100, 33, 81, 67, 229, 253, 8, 33, 209, 250, 91, 15, 147, 172, 204, 114, 142, 25, 156, 153, 224, 73, 117, 182, 62, 153, 99, 50, 140, 217 }, new byte[] { 31, 139, 91, 134, 7, 28, 176, 227, 240, 61, 38, 210, 153, 20, 22, 143, 1, 181, 87, 96, 70, 108, 88, 183, 192, 92, 225, 230, 28, 36, 12, 195, 157, 75, 77, 104, 135, 225, 176, 248, 64, 118, 43, 139, 186, 97, 68, 8, 199, 246, 27, 201, 31, 24, 209, 46, 57, 188, 164, 51, 14, 105, 49, 91 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 15, 8, 29, 730, DateTimeKind.Utc).AddTicks(1474), new byte[] { 175, 119, 100, 33, 81, 67, 229, 253, 8, 33, 209, 250, 91, 15, 147, 172, 204, 114, 142, 25, 156, 153, 224, 73, 117, 182, 62, 153, 99, 50, 140, 217 }, new byte[] { 31, 139, 91, 134, 7, 28, 176, 227, 240, 61, 38, 210, 153, 20, 22, 143, 1, 181, 87, 96, 70, 108, 88, 183, 192, 92, 225, 230, 28, 36, 12, 195, 157, 75, 77, 104, 135, 225, 176, 248, 64, 118, 43, 139, 186, 97, 68, 8, 199, 246, 27, 201, 31, 24, 209, 46, 57, 188, 164, 51, 14, 105, 49, 91 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 15, 8, 29, 730, DateTimeKind.Utc).AddTicks(1444), new byte[] { 175, 119, 100, 33, 81, 67, 229, 253, 8, 33, 209, 250, 91, 15, 147, 172, 204, 114, 142, 25, 156, 153, 224, 73, 117, 182, 62, 153, 99, 50, 140, 217 }, new byte[] { 31, 139, 91, 134, 7, 28, 176, 227, 240, 61, 38, 210, 153, 20, 22, 143, 1, 181, 87, 96, 70, 108, 88, 183, 192, 92, 225, 230, 28, 36, 12, 195, 157, 75, 77, 104, 135, 225, 176, 248, 64, 118, 43, 139, 186, 97, 68, 8, 199, 246, 27, 201, 31, 24, 209, 46, 57, 188, 164, 51, 14, 105, 49, 91 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 15, 8, 29, 730, DateTimeKind.Utc).AddTicks(1489), new byte[] { 175, 119, 100, 33, 81, 67, 229, 253, 8, 33, 209, 250, 91, 15, 147, 172, 204, 114, 142, 25, 156, 153, 224, 73, 117, 182, 62, 153, 99, 50, 140, 217 }, new byte[] { 31, 139, 91, 134, 7, 28, 176, 227, 240, 61, 38, 210, 153, 20, 22, 143, 1, 181, 87, 96, 70, 108, 88, 183, 192, 92, 225, 230, 28, 36, 12, 195, 157, 75, 77, 104, 135, 225, 176, 248, 64, 118, 43, 139, 186, 97, 68, 8, 199, 246, 27, 201, 31, 24, 209, 46, 57, 188, 164, 51, 14, 105, 49, 91 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 10, 38, 32, 118, DateTimeKind.Utc).AddTicks(3726), new byte[] { 186, 123, 86, 24, 109, 1, 35, 147, 194, 0, 56, 236, 57, 227, 250, 119, 225, 244, 24, 220, 176, 229, 5, 64, 23, 223, 143, 220, 186, 203, 27, 28 }, new byte[] { 163, 143, 241, 88, 64, 215, 163, 138, 156, 77, 185, 145, 81, 170, 93, 120, 74, 150, 180, 112, 143, 182, 146, 40, 179, 176, 38, 136, 53, 93, 143, 222, 191, 123, 114, 159, 82, 164, 48, 141, 192, 93, 36, 34, 129, 152, 24, 78, 60, 219, 243, 60, 144, 132, 181, 185, 125, 125, 118, 137, 33, 112, 155, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 10, 38, 32, 118, DateTimeKind.Utc).AddTicks(3699), new byte[] { 186, 123, 86, 24, 109, 1, 35, 147, 194, 0, 56, 236, 57, 227, 250, 119, 225, 244, 24, 220, 176, 229, 5, 64, 23, 223, 143, 220, 186, 203, 27, 28 }, new byte[] { 163, 143, 241, 88, 64, 215, 163, 138, 156, 77, 185, 145, 81, 170, 93, 120, 74, 150, 180, 112, 143, 182, 146, 40, 179, 176, 38, 136, 53, 93, 143, 222, 191, 123, 114, 159, 82, 164, 48, 141, 192, 93, 36, 34, 129, 152, 24, 78, 60, 219, 243, 60, 144, 132, 181, 185, 125, 125, 118, 137, 33, 112, 155, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 10, 38, 32, 118, DateTimeKind.Utc).AddTicks(3681), new byte[] { 186, 123, 86, 24, 109, 1, 35, 147, 194, 0, 56, 236, 57, 227, 250, 119, 225, 244, 24, 220, 176, 229, 5, 64, 23, 223, 143, 220, 186, 203, 27, 28 }, new byte[] { 163, 143, 241, 88, 64, 215, 163, 138, 156, 77, 185, 145, 81, 170, 93, 120, 74, 150, 180, 112, 143, 182, 146, 40, 179, 176, 38, 136, 53, 93, 143, 222, 191, 123, 114, 159, 82, 164, 48, 141, 192, 93, 36, 34, 129, 152, 24, 78, 60, 219, 243, 60, 144, 132, 181, 185, 125, 125, 118, 137, 33, 112, 155, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 10, 38, 32, 118, DateTimeKind.Utc).AddTicks(3737), new byte[] { 186, 123, 86, 24, 109, 1, 35, 147, 194, 0, 56, 236, 57, 227, 250, 119, 225, 244, 24, 220, 176, 229, 5, 64, 23, 223, 143, 220, 186, 203, 27, 28 }, new byte[] { 163, 143, 241, 88, 64, 215, 163, 138, 156, 77, 185, 145, 81, 170, 93, 120, 74, 150, 180, 112, 143, 182, 146, 40, 179, 176, 38, 136, 53, 93, 143, 222, 191, 123, 114, 159, 82, 164, 48, 141, 192, 93, 36, 34, 129, 152, 24, 78, 60, 219, 243, 60, 144, 132, 181, 185, 125, 125, 118, 137, 33, 112, 155, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 10, 38, 32, 118, DateTimeKind.Utc).AddTicks(3712), new byte[] { 186, 123, 86, 24, 109, 1, 35, 147, 194, 0, 56, 236, 57, 227, 250, 119, 225, 244, 24, 220, 176, 229, 5, 64, 23, 223, 143, 220, 186, 203, 27, 28 }, new byte[] { 163, 143, 241, 88, 64, 215, 163, 138, 156, 77, 185, 145, 81, 170, 93, 120, 74, 150, 180, 112, 143, 182, 146, 40, 179, 176, 38, 136, 53, 93, 143, 222, 191, 123, 114, 159, 82, 164, 48, 141, 192, 93, 36, 34, 129, 152, 24, 78, 60, 219, 243, 60, 144, 132, 181, 185, 125, 125, 118, 137, 33, 112, 155, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 10, 38, 32, 118, DateTimeKind.Utc).AddTicks(3748), new byte[] { 186, 123, 86, 24, 109, 1, 35, 147, 194, 0, 56, 236, 57, 227, 250, 119, 225, 244, 24, 220, 176, 229, 5, 64, 23, 223, 143, 220, 186, 203, 27, 28 }, new byte[] { 163, 143, 241, 88, 64, 215, 163, 138, 156, 77, 185, 145, 81, 170, 93, 120, 74, 150, 180, 112, 143, 182, 146, 40, 179, 176, 38, 136, 53, 93, 143, 222, 191, 123, 114, 159, 82, 164, 48, 141, 192, 93, 36, 34, 129, 152, 24, 78, 60, 219, 243, 60, 144, 132, 181, 185, 125, 125, 118, 137, 33, 112, 155, 40 } });
        }
    }
}
