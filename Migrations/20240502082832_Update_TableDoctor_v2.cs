using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableDoctor_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { "10:00", "9:00" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 28, 32, 341, DateTimeKind.Utc).AddTicks(3752), new byte[] { 202, 253, 177, 213, 246, 235, 209, 102, 61, 77, 127, 0, 147, 180, 173, 29, 114, 74, 182, 152, 156, 108, 155, 55, 224, 218, 248, 249, 81, 183, 65, 151 }, new byte[] { 183, 209, 243, 182, 242, 115, 96, 163, 60, 124, 86, 103, 145, 22, 230, 147, 10, 58, 115, 244, 220, 0, 242, 185, 102, 152, 135, 214, 224, 32, 115, 183, 128, 9, 32, 147, 202, 66, 184, 226, 115, 145, 15, 28, 134, 66, 9, 250, 205, 119, 69, 157, 200, 155, 158, 96, 234, 140, 215, 149, 224, 123, 233, 76 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 28, 32, 341, DateTimeKind.Utc).AddTicks(3727), new byte[] { 202, 253, 177, 213, 246, 235, 209, 102, 61, 77, 127, 0, 147, 180, 173, 29, 114, 74, 182, 152, 156, 108, 155, 55, 224, 218, 248, 249, 81, 183, 65, 151 }, new byte[] { 183, 209, 243, 182, 242, 115, 96, 163, 60, 124, 86, 103, 145, 22, 230, 147, 10, 58, 115, 244, 220, 0, 242, 185, 102, 152, 135, 214, 224, 32, 115, 183, 128, 9, 32, 147, 202, 66, 184, 226, 115, 145, 15, 28, 134, 66, 9, 250, 205, 119, 69, 157, 200, 155, 158, 96, 234, 140, 215, 149, 224, 123, 233, 76 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 28, 32, 341, DateTimeKind.Utc).AddTicks(3708), new byte[] { 202, 253, 177, 213, 246, 235, 209, 102, 61, 77, 127, 0, 147, 180, 173, 29, 114, 74, 182, 152, 156, 108, 155, 55, 224, 218, 248, 249, 81, 183, 65, 151 }, new byte[] { 183, 209, 243, 182, 242, 115, 96, 163, 60, 124, 86, 103, 145, 22, 230, 147, 10, 58, 115, 244, 220, 0, 242, 185, 102, 152, 135, 214, 224, 32, 115, 183, 128, 9, 32, 147, 202, 66, 184, 226, 115, 145, 15, 28, 134, 66, 9, 250, 205, 119, 69, 157, 200, 155, 158, 96, 234, 140, 215, 149, 224, 123, 233, 76 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 28, 32, 341, DateTimeKind.Utc).AddTicks(3765), new byte[] { 202, 253, 177, 213, 246, 235, 209, 102, 61, 77, 127, 0, 147, 180, 173, 29, 114, 74, 182, 152, 156, 108, 155, 55, 224, 218, 248, 249, 81, 183, 65, 151 }, new byte[] { 183, 209, 243, 182, 242, 115, 96, 163, 60, 124, 86, 103, 145, 22, 230, 147, 10, 58, 115, 244, 220, 0, 242, 185, 102, 152, 135, 214, 224, 32, 115, 183, 128, 9, 32, 147, 202, 66, 184, 226, 115, 145, 15, 28, 134, 66, 9, 250, 205, 119, 69, 157, 200, 155, 158, 96, 234, 140, 215, 149, 224, 123, 233, 76 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 28, 32, 341, DateTimeKind.Utc).AddTicks(3740), new byte[] { 202, 253, 177, 213, 246, 235, 209, 102, 61, 77, 127, 0, 147, 180, 173, 29, 114, 74, 182, 152, 156, 108, 155, 55, 224, 218, 248, 249, 81, 183, 65, 151 }, new byte[] { 183, 209, 243, 182, 242, 115, 96, 163, 60, 124, 86, 103, 145, 22, 230, 147, 10, 58, 115, 244, 220, 0, 242, 185, 102, 152, 135, 214, 224, 32, 115, 183, 128, 9, 32, 147, 202, 66, 184, 226, 115, 145, 15, 28, 134, 66, 9, 250, 205, 119, 69, 157, 200, 155, 158, 96, 234, 140, 215, 149, 224, 123, 233, 76 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 28, 32, 341, DateTimeKind.Utc).AddTicks(3781), new byte[] { 202, 253, 177, 213, 246, 235, 209, 102, 61, 77, 127, 0, 147, 180, 173, 29, 114, 74, 182, 152, 156, 108, 155, 55, 224, 218, 248, 249, 81, 183, 65, 151 }, new byte[] { 183, 209, 243, 182, 242, 115, 96, 163, 60, 124, 86, 103, 145, 22, 230, 147, 10, 58, 115, 244, 220, 0, 242, 185, 102, 152, 135, 214, 224, 32, 115, 183, 128, 9, 32, 147, 202, 66, 184, 226, 115, 145, 15, 28, 134, 66, 9, 250, 205, 119, 69, 157, 200, 155, 158, 96, 234, 140, 215, 149, 224, 123, 233, 76 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { "11:00", "10:00" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 24, 50, 707, DateTimeKind.Utc).AddTicks(9455), new byte[] { 198, 37, 153, 244, 15, 110, 76, 45, 43, 127, 221, 249, 242, 225, 124, 129, 241, 30, 196, 116, 51, 184, 6, 131, 84, 208, 72, 170, 151, 34, 224, 104 }, new byte[] { 22, 192, 70, 142, 188, 122, 128, 112, 27, 138, 176, 64, 135, 43, 250, 109, 153, 154, 40, 132, 192, 40, 178, 254, 113, 215, 178, 82, 157, 159, 41, 14, 51, 225, 49, 1, 93, 183, 95, 44, 255, 0, 17, 252, 41, 60, 81, 59, 28, 117, 100, 46, 114, 180, 214, 50, 241, 193, 176, 60, 19, 54, 20, 11 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 24, 50, 707, DateTimeKind.Utc).AddTicks(9429), new byte[] { 198, 37, 153, 244, 15, 110, 76, 45, 43, 127, 221, 249, 242, 225, 124, 129, 241, 30, 196, 116, 51, 184, 6, 131, 84, 208, 72, 170, 151, 34, 224, 104 }, new byte[] { 22, 192, 70, 142, 188, 122, 128, 112, 27, 138, 176, 64, 135, 43, 250, 109, 153, 154, 40, 132, 192, 40, 178, 254, 113, 215, 178, 82, 157, 159, 41, 14, 51, 225, 49, 1, 93, 183, 95, 44, 255, 0, 17, 252, 41, 60, 81, 59, 28, 117, 100, 46, 114, 180, 214, 50, 241, 193, 176, 60, 19, 54, 20, 11 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 24, 50, 707, DateTimeKind.Utc).AddTicks(9410), new byte[] { 198, 37, 153, 244, 15, 110, 76, 45, 43, 127, 221, 249, 242, 225, 124, 129, 241, 30, 196, 116, 51, 184, 6, 131, 84, 208, 72, 170, 151, 34, 224, 104 }, new byte[] { 22, 192, 70, 142, 188, 122, 128, 112, 27, 138, 176, 64, 135, 43, 250, 109, 153, 154, 40, 132, 192, 40, 178, 254, 113, 215, 178, 82, 157, 159, 41, 14, 51, 225, 49, 1, 93, 183, 95, 44, 255, 0, 17, 252, 41, 60, 81, 59, 28, 117, 100, 46, 114, 180, 214, 50, 241, 193, 176, 60, 19, 54, 20, 11 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 24, 50, 707, DateTimeKind.Utc).AddTicks(9467), new byte[] { 198, 37, 153, 244, 15, 110, 76, 45, 43, 127, 221, 249, 242, 225, 124, 129, 241, 30, 196, 116, 51, 184, 6, 131, 84, 208, 72, 170, 151, 34, 224, 104 }, new byte[] { 22, 192, 70, 142, 188, 122, 128, 112, 27, 138, 176, 64, 135, 43, 250, 109, 153, 154, 40, 132, 192, 40, 178, 254, 113, 215, 178, 82, 157, 159, 41, 14, 51, 225, 49, 1, 93, 183, 95, 44, 255, 0, 17, 252, 41, 60, 81, 59, 28, 117, 100, 46, 114, 180, 214, 50, 241, 193, 176, 60, 19, 54, 20, 11 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 24, 50, 707, DateTimeKind.Utc).AddTicks(9442), new byte[] { 198, 37, 153, 244, 15, 110, 76, 45, 43, 127, 221, 249, 242, 225, 124, 129, 241, 30, 196, 116, 51, 184, 6, 131, 84, 208, 72, 170, 151, 34, 224, 104 }, new byte[] { 22, 192, 70, 142, 188, 122, 128, 112, 27, 138, 176, 64, 135, 43, 250, 109, 153, 154, 40, 132, 192, 40, 178, 254, 113, 215, 178, 82, 157, 159, 41, 14, 51, 225, 49, 1, 93, 183, 95, 44, 255, 0, 17, 252, 41, 60, 81, 59, 28, 117, 100, 46, 114, 180, 214, 50, 241, 193, 176, 60, 19, 54, 20, 11 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 24, 50, 707, DateTimeKind.Utc).AddTicks(9478), new byte[] { 198, 37, 153, 244, 15, 110, 76, 45, 43, 127, 221, 249, 242, 225, 124, 129, 241, 30, 196, 116, 51, 184, 6, 131, 84, 208, 72, 170, 151, 34, 224, 104 }, new byte[] { 22, 192, 70, 142, 188, 122, 128, 112, 27, 138, 176, 64, 135, 43, 250, 109, 153, 154, 40, 132, 192, 40, 178, 254, 113, 215, 178, 82, 157, 159, 41, 14, 51, 225, 49, 1, 93, 183, 95, 44, 255, 0, 17, 252, 41, 60, 81, 59, 28, 117, 100, 46, 114, 180, 214, 50, 241, 193, 176, 60, 19, 54, 20, 11 } });
        }
    }
}
