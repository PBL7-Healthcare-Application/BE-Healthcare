using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableAppointment_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Appointments",
                type: "double",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "Price",
                value: null);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Appointments");

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
    }
}
