using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Create_AdminAccount_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 9, 38, 950, DateTimeKind.Utc).AddTicks(3773), new byte[] { 23, 67, 164, 251, 193, 30, 97, 128, 244, 80, 57, 37, 101, 22, 183, 163, 201, 240, 135, 104, 0, 144, 199, 113, 93, 62, 173, 185, 195, 40, 146, 123 }, new byte[] { 230, 203, 30, 30, 61, 173, 90, 155, 239, 213, 117, 40, 59, 201, 101, 221, 226, 211, 237, 99, 89, 22, 237, 240, 185, 231, 204, 60, 255, 72, 196, 239, 202, 247, 157, 95, 24, 135, 1, 209, 193, 66, 27, 58, 132, 77, 191, 33, 76, 134, 237, 108, 229, 179, 188, 140, 35, 232, 227, 192, 97, 54, 218, 173 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 9, 38, 950, DateTimeKind.Utc).AddTicks(3734), new byte[] { 23, 67, 164, 251, 193, 30, 97, 128, 244, 80, 57, 37, 101, 22, 183, 163, 201, 240, 135, 104, 0, 144, 199, 113, 93, 62, 173, 185, 195, 40, 146, 123 }, new byte[] { 230, 203, 30, 30, 61, 173, 90, 155, 239, 213, 117, 40, 59, 201, 101, 221, 226, 211, 237, 99, 89, 22, 237, 240, 185, 231, 204, 60, 255, 72, 196, 239, 202, 247, 157, 95, 24, 135, 1, 209, 193, 66, 27, 58, 132, 77, 191, 33, 76, 134, 237, 108, 229, 179, 188, 140, 35, 232, 227, 192, 97, 54, 218, 173 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 9, 38, 950, DateTimeKind.Utc).AddTicks(3678), new byte[] { 23, 67, 164, 251, 193, 30, 97, 128, 244, 80, 57, 37, 101, 22, 183, 163, 201, 240, 135, 104, 0, 144, 199, 113, 93, 62, 173, 185, 195, 40, 146, 123 }, new byte[] { 230, 203, 30, 30, 61, 173, 90, 155, 239, 213, 117, 40, 59, 201, 101, 221, 226, 211, 237, 99, 89, 22, 237, 240, 185, 231, 204, 60, 255, 72, 196, 239, 202, 247, 157, 95, 24, 135, 1, 209, 193, 66, 27, 58, 132, 77, 191, 33, 76, 134, 237, 108, 229, 179, 188, 140, 35, 232, 227, 192, 97, 54, 218, 173 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 9, 38, 950, DateTimeKind.Utc).AddTicks(3800), new byte[] { 23, 67, 164, 251, 193, 30, 97, 128, 244, 80, 57, 37, 101, 22, 183, 163, 201, 240, 135, 104, 0, 144, 199, 113, 93, 62, 173, 185, 195, 40, 146, 123 }, new byte[] { 230, 203, 30, 30, 61, 173, 90, 155, 239, 213, 117, 40, 59, 201, 101, 221, 226, 211, 237, 99, 89, 22, 237, 240, 185, 231, 204, 60, 255, 72, 196, 239, 202, 247, 157, 95, 24, 135, 1, 209, 193, 66, 27, 58, 132, 77, 191, 33, 76, 134, 237, 108, 229, 179, 188, 140, 35, 232, 227, 192, 97, 54, 218, 173 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 9, 38, 950, DateTimeKind.Utc).AddTicks(3751), new byte[] { 23, 67, 164, 251, 193, 30, 97, 128, 244, 80, 57, 37, 101, 22, 183, 163, 201, 240, 135, 104, 0, 144, 199, 113, 93, 62, 173, 185, 195, 40, 146, 123 }, new byte[] { 230, 203, 30, 30, 61, 173, 90, 155, 239, 213, 117, 40, 59, 201, 101, 221, 226, 211, 237, 99, 89, 22, 237, 240, 185, 231, 204, 60, 255, 72, 196, 239, 202, 247, 157, 95, 24, 135, 1, 209, 193, 66, 27, 58, 132, 77, 191, 33, 76, 134, 237, 108, 229, 179, 188, 140, 35, 232, 227, 192, 97, 54, 218, 173 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 9, 38, 950, DateTimeKind.Utc).AddTicks(3825), new byte[] { 23, 67, 164, 251, 193, 30, 97, 128, 244, 80, 57, 37, 101, 22, 183, 163, 201, 240, 135, 104, 0, 144, 199, 113, 93, 62, 173, 185, 195, 40, 146, 123 }, new byte[] { 230, 203, 30, 30, 61, 173, 90, 155, 239, 213, 117, 40, 59, 201, 101, 221, 226, 211, 237, 99, 89, 22, 237, 240, 185, 231, 204, 60, 255, 72, 196, 239, 202, 247, 157, 95, 24, 135, 1, 209, 193, 66, 27, 58, 132, 77, 191, 33, 76, 134, 237, 108, 229, 179, 188, 140, 35, 232, 227, 192, 97, 54, 218, 173 } });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "IdUser", "Address", "Avatar", "DOB", "Email", "Gender", "IsLocked", "IsVerified", "Name", "OTPCreatedAt", "OTPVerification", "PasswordHash", "PasswordSalt", "PhoneNumber", "ReasonLockAccount", "idRole" },
                values: new object[] { new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"), null, null, null, "admin@gmail.com", null, false, true, "Admin", new DateTime(2024, 5, 11, 17, 9, 38, 950, DateTimeKind.Utc).AddTicks(3843), "123456", new byte[] { 23, 67, 164, 251, 193, 30, 97, 128, 244, 80, 57, 37, 101, 22, 183, 163, 201, 240, 135, 104, 0, 144, 199, 113, 93, 62, 173, 185, 195, 40, 146, 123 }, new byte[] { 230, 203, 30, 30, 61, 173, 90, 155, 239, 213, 117, 40, 59, 201, 101, 221, 226, 211, 237, 99, 89, 22, 237, 240, 185, 231, 204, 60, 255, 72, 196, 239, 202, 247, 157, 95, 24, 135, 1, 209, 193, 66, 27, 58, 132, 77, 191, 33, 76, 134, 237, 108, 229, 179, 188, 140, 35, 232, 227, 192, 97, 54, 218, 173 }, null, null, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"));

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
    }
}
