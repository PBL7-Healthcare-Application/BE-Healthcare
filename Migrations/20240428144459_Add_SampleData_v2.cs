using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Add_SampleData_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "IdCertificate", "IdDoctor", "Image", "Name", "Year" },
                values: new object[,]
                {
                    { 1, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "https://hellobacsi.com/care/bac-si/bsckii-tran-thi-hoai-huong-646/", "Hội viên chi hội Da liễu Hồ Chí Minh", 2020 },
                    { 2, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "https://hellobacsi.com/care/bac-si/bsckii-tran-thi-hoai-huong-646/", "Hội viên Hội Da liễu Việt Nam", 2022 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 43, 15, 440, DateTimeKind.Utc).AddTicks(2578), new byte[] { 62, 27, 121, 222, 74, 220, 242, 94, 47, 147, 14, 16, 156, 245, 25, 253, 3, 1, 3, 68, 123, 250, 254, 83, 1, 221, 91, 50, 234, 136, 54, 13 }, new byte[] { 219, 144, 94, 227, 146, 137, 230, 248, 143, 158, 121, 62, 155, 122, 108, 17, 12, 89, 56, 144, 128, 83, 244, 251, 139, 48, 35, 159, 118, 45, 15, 187, 101, 73, 30, 195, 244, 155, 216, 152, 173, 81, 215, 217, 75, 20, 170, 193, 191, 237, 198, 209, 159, 54, 64, 195, 184, 52, 8, 188, 222, 173, 13, 106 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 43, 15, 440, DateTimeKind.Utc).AddTicks(2554), new byte[] { 62, 27, 121, 222, 74, 220, 242, 94, 47, 147, 14, 16, 156, 245, 25, 253, 3, 1, 3, 68, 123, 250, 254, 83, 1, 221, 91, 50, 234, 136, 54, 13 }, new byte[] { 219, 144, 94, 227, 146, 137, 230, 248, 143, 158, 121, 62, 155, 122, 108, 17, 12, 89, 56, 144, 128, 83, 244, 251, 139, 48, 35, 159, 118, 45, 15, 187, 101, 73, 30, 195, 244, 155, 216, 152, 173, 81, 215, 217, 75, 20, 170, 193, 191, 237, 198, 209, 159, 54, 64, 195, 184, 52, 8, 188, 222, 173, 13, 106 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 43, 15, 440, DateTimeKind.Utc).AddTicks(2535), new byte[] { 62, 27, 121, 222, 74, 220, 242, 94, 47, 147, 14, 16, 156, 245, 25, 253, 3, 1, 3, 68, 123, 250, 254, 83, 1, 221, 91, 50, 234, 136, 54, 13 }, new byte[] { 219, 144, 94, 227, 146, 137, 230, 248, 143, 158, 121, 62, 155, 122, 108, 17, 12, 89, 56, 144, 128, 83, 244, 251, 139, 48, 35, 159, 118, 45, 15, 187, 101, 73, 30, 195, 244, 155, 216, 152, 173, 81, 215, 217, 75, 20, 170, 193, 191, 237, 198, 209, 159, 54, 64, 195, 184, 52, 8, 188, 222, 173, 13, 106 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 43, 15, 440, DateTimeKind.Utc).AddTicks(2590), new byte[] { 62, 27, 121, 222, 74, 220, 242, 94, 47, 147, 14, 16, 156, 245, 25, 253, 3, 1, 3, 68, 123, 250, 254, 83, 1, 221, 91, 50, 234, 136, 54, 13 }, new byte[] { 219, 144, 94, 227, 146, 137, 230, 248, 143, 158, 121, 62, 155, 122, 108, 17, 12, 89, 56, 144, 128, 83, 244, 251, 139, 48, 35, 159, 118, 45, 15, 187, 101, 73, 30, 195, 244, 155, 216, 152, 173, 81, 215, 217, 75, 20, 170, 193, 191, 237, 198, 209, 159, 54, 64, 195, 184, 52, 8, 188, 222, 173, 13, 106 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 43, 15, 440, DateTimeKind.Utc).AddTicks(2566), new byte[] { 62, 27, 121, 222, 74, 220, 242, 94, 47, 147, 14, 16, 156, 245, 25, 253, 3, 1, 3, 68, 123, 250, 254, 83, 1, 221, 91, 50, 234, 136, 54, 13 }, new byte[] { 219, 144, 94, 227, 146, 137, 230, 248, 143, 158, 121, 62, 155, 122, 108, 17, 12, 89, 56, 144, 128, 83, 244, 251, 139, 48, 35, 159, 118, 45, 15, 187, 101, 73, 30, 195, 244, 155, 216, 152, 173, 81, 215, 217, 75, 20, 170, 193, 191, 237, 198, 209, 159, 54, 64, 195, 184, 52, 8, 188, 222, 173, 13, 106 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 43, 15, 440, DateTimeKind.Utc).AddTicks(2602), new byte[] { 62, 27, 121, 222, 74, 220, 242, 94, 47, 147, 14, 16, 156, 245, 25, 253, 3, 1, 3, 68, 123, 250, 254, 83, 1, 221, 91, 50, 234, 136, 54, 13 }, new byte[] { 219, 144, 94, 227, 146, 137, 230, 248, 143, 158, 121, 62, 155, 122, 108, 17, 12, 89, 56, 144, 128, 83, 244, 251, 139, 48, 35, 159, 118, 45, 15, 187, 101, 73, 30, 195, 244, 155, 216, 152, 173, 81, 215, 217, 75, 20, 170, 193, 191, 237, 198, 209, 159, 54, 64, 195, 184, 52, 8, 188, 222, 173, 13, 106 } });
        }
    }
}
