using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_DB_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 8, 16, 51, 623, DateTimeKind.Utc).AddTicks(380), new byte[] { 85, 238, 143, 4, 49, 172, 180, 98, 111, 57, 5, 218, 198, 95, 202, 16, 58, 212, 42, 208, 67, 208, 176, 92, 125, 69, 99, 174, 142, 215, 58, 80 }, new byte[] { 245, 126, 211, 17, 216, 9, 108, 46, 188, 181, 58, 206, 28, 118, 242, 46, 102, 27, 114, 95, 254, 15, 42, 38, 90, 90, 252, 52, 157, 196, 219, 90, 205, 251, 78, 204, 127, 182, 119, 219, 85, 162, 8, 199, 18, 92, 246, 222, 174, 154, 89, 57, 100, 46, 111, 44, 16, 191, 46, 58, 243, 162, 243, 139 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 8, 16, 51, 623, DateTimeKind.Utc).AddTicks(354), new byte[] { 85, 238, 143, 4, 49, 172, 180, 98, 111, 57, 5, 218, 198, 95, 202, 16, 58, 212, 42, 208, 67, 208, 176, 92, 125, 69, 99, 174, 142, 215, 58, 80 }, new byte[] { 245, 126, 211, 17, 216, 9, 108, 46, 188, 181, 58, 206, 28, 118, 242, 46, 102, 27, 114, 95, 254, 15, 42, 38, 90, 90, 252, 52, 157, 196, 219, 90, 205, 251, 78, 204, 127, 182, 119, 219, 85, 162, 8, 199, 18, 92, 246, 222, 174, 154, 89, 57, 100, 46, 111, 44, 16, 191, 46, 58, 243, 162, 243, 139 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 8, 16, 51, 623, DateTimeKind.Utc).AddTicks(335), new byte[] { 85, 238, 143, 4, 49, 172, 180, 98, 111, 57, 5, 218, 198, 95, 202, 16, 58, 212, 42, 208, 67, 208, 176, 92, 125, 69, 99, 174, 142, 215, 58, 80 }, new byte[] { 245, 126, 211, 17, 216, 9, 108, 46, 188, 181, 58, 206, 28, 118, 242, 46, 102, 27, 114, 95, 254, 15, 42, 38, 90, 90, 252, 52, 157, 196, 219, 90, 205, 251, 78, 204, 127, 182, 119, 219, 85, 162, 8, 199, 18, 92, 246, 222, 174, 154, 89, 57, 100, 46, 111, 44, 16, 191, 46, 58, 243, 162, 243, 139 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 8, 16, 51, 623, DateTimeKind.Utc).AddTicks(392), new byte[] { 85, 238, 143, 4, 49, 172, 180, 98, 111, 57, 5, 218, 198, 95, 202, 16, 58, 212, 42, 208, 67, 208, 176, 92, 125, 69, 99, 174, 142, 215, 58, 80 }, new byte[] { 245, 126, 211, 17, 216, 9, 108, 46, 188, 181, 58, 206, 28, 118, 242, 46, 102, 27, 114, 95, 254, 15, 42, 38, 90, 90, 252, 52, 157, 196, 219, 90, 205, 251, 78, 204, 127, 182, 119, 219, 85, 162, 8, 199, 18, 92, 246, 222, 174, 154, 89, 57, 100, 46, 111, 44, 16, 191, 46, 58, 243, 162, 243, 139 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 8, 16, 51, 623, DateTimeKind.Utc).AddTicks(367), new byte[] { 85, 238, 143, 4, 49, 172, 180, 98, 111, 57, 5, 218, 198, 95, 202, 16, 58, 212, 42, 208, 67, 208, 176, 92, 125, 69, 99, 174, 142, 215, 58, 80 }, new byte[] { 245, 126, 211, 17, 216, 9, 108, 46, 188, 181, 58, 206, 28, 118, 242, 46, 102, 27, 114, 95, 254, 15, 42, 38, 90, 90, 252, 52, 157, 196, 219, 90, 205, 251, 78, 204, 127, 182, 119, 219, 85, 162, 8, 199, 18, 92, 246, 222, 174, 154, 89, 57, 100, 46, 111, 44, 16, 191, 46, 58, 243, 162, 243, 139 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 8, 16, 51, 623, DateTimeKind.Utc).AddTicks(404), new byte[] { 85, 238, 143, 4, 49, 172, 180, 98, 111, 57, 5, 218, 198, 95, 202, 16, 58, 212, 42, 208, 67, 208, 176, 92, 125, 69, 99, 174, 142, 215, 58, 80 }, new byte[] { 245, 126, 211, 17, 216, 9, 108, 46, 188, 181, 58, 206, 28, 118, 242, 46, 102, 27, 114, 95, 254, 15, 42, 38, 90, 90, 252, 52, 157, 196, 219, 90, 205, 251, 78, 204, 127, 182, 119, 219, 85, 162, 8, 199, 18, 92, 246, 222, 174, 154, 89, 57, 100, 46, 111, 44, 16, 191, 46, 58, 243, 162, 243, 139 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 55, 15, 648, DateTimeKind.Utc).AddTicks(6750), new byte[] { 14, 79, 154, 146, 159, 69, 53, 200, 107, 235, 163, 217, 130, 240, 27, 149, 216, 131, 30, 248, 225, 153, 119, 108, 136, 172, 122, 29, 196, 132, 207, 168 }, new byte[] { 162, 77, 225, 226, 253, 48, 5, 77, 42, 147, 100, 126, 237, 41, 109, 77, 226, 152, 33, 43, 249, 69, 203, 84, 189, 200, 37, 244, 220, 100, 232, 51, 66, 27, 215, 98, 131, 131, 215, 190, 81, 143, 176, 59, 236, 201, 189, 42, 120, 180, 74, 158, 143, 107, 113, 134, 16, 222, 99, 239, 115, 147, 60, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 55, 15, 648, DateTimeKind.Utc).AddTicks(6673), new byte[] { 14, 79, 154, 146, 159, 69, 53, 200, 107, 235, 163, 217, 130, 240, 27, 149, 216, 131, 30, 248, 225, 153, 119, 108, 136, 172, 122, 29, 196, 132, 207, 168 }, new byte[] { 162, 77, 225, 226, 253, 48, 5, 77, 42, 147, 100, 126, 237, 41, 109, 77, 226, 152, 33, 43, 249, 69, 203, 84, 189, 200, 37, 244, 220, 100, 232, 51, 66, 27, 215, 98, 131, 131, 215, 190, 81, 143, 176, 59, 236, 201, 189, 42, 120, 180, 74, 158, 143, 107, 113, 134, 16, 222, 99, 239, 115, 147, 60, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 55, 15, 648, DateTimeKind.Utc).AddTicks(6655), new byte[] { 14, 79, 154, 146, 159, 69, 53, 200, 107, 235, 163, 217, 130, 240, 27, 149, 216, 131, 30, 248, 225, 153, 119, 108, 136, 172, 122, 29, 196, 132, 207, 168 }, new byte[] { 162, 77, 225, 226, 253, 48, 5, 77, 42, 147, 100, 126, 237, 41, 109, 77, 226, 152, 33, 43, 249, 69, 203, 84, 189, 200, 37, 244, 220, 100, 232, 51, 66, 27, 215, 98, 131, 131, 215, 190, 81, 143, 176, 59, 236, 201, 189, 42, 120, 180, 74, 158, 143, 107, 113, 134, 16, 222, 99, 239, 115, 147, 60, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 55, 15, 648, DateTimeKind.Utc).AddTicks(6763), new byte[] { 14, 79, 154, 146, 159, 69, 53, 200, 107, 235, 163, 217, 130, 240, 27, 149, 216, 131, 30, 248, 225, 153, 119, 108, 136, 172, 122, 29, 196, 132, 207, 168 }, new byte[] { 162, 77, 225, 226, 253, 48, 5, 77, 42, 147, 100, 126, 237, 41, 109, 77, 226, 152, 33, 43, 249, 69, 203, 84, 189, 200, 37, 244, 220, 100, 232, 51, 66, 27, 215, 98, 131, 131, 215, 190, 81, 143, 176, 59, 236, 201, 189, 42, 120, 180, 74, 158, 143, 107, 113, 134, 16, 222, 99, 239, 115, 147, 60, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 55, 15, 648, DateTimeKind.Utc).AddTicks(6736), new byte[] { 14, 79, 154, 146, 159, 69, 53, 200, 107, 235, 163, 217, 130, 240, 27, 149, 216, 131, 30, 248, 225, 153, 119, 108, 136, 172, 122, 29, 196, 132, 207, 168 }, new byte[] { 162, 77, 225, 226, 253, 48, 5, 77, 42, 147, 100, 126, 237, 41, 109, 77, 226, 152, 33, 43, 249, 69, 203, 84, 189, 200, 37, 244, 220, 100, 232, 51, 66, 27, 215, 98, 131, 131, 215, 190, 81, 143, 176, 59, 236, 201, 189, 42, 120, 180, 74, 158, 143, 107, 113, 134, 16, 222, 99, 239, 115, 147, 60, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 55, 15, 648, DateTimeKind.Utc).AddTicks(6776), new byte[] { 14, 79, 154, 146, 159, 69, 53, 200, 107, 235, 163, 217, 130, 240, 27, 149, 216, 131, 30, 248, 225, 153, 119, 108, 136, 172, 122, 29, 196, 132, 207, 168 }, new byte[] { 162, 77, 225, 226, 253, 48, 5, 77, 42, 147, 100, 126, 237, 41, 109, 77, 226, 152, 33, 43, 249, 69, 203, 84, 189, 200, 37, 244, 220, 100, 232, 51, 66, 27, 215, 98, 131, 131, 215, 190, 81, 143, 176, 59, 236, 201, 189, 42, 120, 180, 74, 158, 143, 107, 113, 134, 16, 222, 99, 239, 115, 147, 60, 2 } });
        }
    }
}
