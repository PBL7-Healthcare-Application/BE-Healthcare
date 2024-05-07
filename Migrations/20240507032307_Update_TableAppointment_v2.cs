using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableAppointment_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "Appointments",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "Reason",
                value: null);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "Reason",
                value: null);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "Reason",
                value: null);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "Reason",
                value: null);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "Reason",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 7, 3, 23, 6, 910, DateTimeKind.Utc).AddTicks(4540), new byte[] { 24, 37, 49, 106, 178, 210, 182, 191, 161, 58, 94, 10, 121, 30, 207, 232, 159, 193, 103, 21, 26, 247, 167, 100, 69, 234, 156, 86, 142, 189, 207, 4 }, new byte[] { 112, 227, 30, 199, 84, 50, 101, 207, 162, 162, 113, 65, 72, 128, 183, 203, 246, 36, 163, 250, 79, 219, 155, 113, 111, 68, 93, 215, 143, 8, 144, 17, 193, 252, 209, 253, 165, 110, 69, 254, 242, 93, 74, 15, 171, 229, 90, 85, 77, 96, 7, 39, 75, 182, 66, 119, 138, 18, 126, 9, 155, 232, 188, 89 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 7, 3, 23, 6, 910, DateTimeKind.Utc).AddTicks(4513), new byte[] { 24, 37, 49, 106, 178, 210, 182, 191, 161, 58, 94, 10, 121, 30, 207, 232, 159, 193, 103, 21, 26, 247, 167, 100, 69, 234, 156, 86, 142, 189, 207, 4 }, new byte[] { 112, 227, 30, 199, 84, 50, 101, 207, 162, 162, 113, 65, 72, 128, 183, 203, 246, 36, 163, 250, 79, 219, 155, 113, 111, 68, 93, 215, 143, 8, 144, 17, 193, 252, 209, 253, 165, 110, 69, 254, 242, 93, 74, 15, 171, 229, 90, 85, 77, 96, 7, 39, 75, 182, 66, 119, 138, 18, 126, 9, 155, 232, 188, 89 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 7, 3, 23, 6, 910, DateTimeKind.Utc).AddTicks(4495), new byte[] { 24, 37, 49, 106, 178, 210, 182, 191, 161, 58, 94, 10, 121, 30, 207, 232, 159, 193, 103, 21, 26, 247, 167, 100, 69, 234, 156, 86, 142, 189, 207, 4 }, new byte[] { 112, 227, 30, 199, 84, 50, 101, 207, 162, 162, 113, 65, 72, 128, 183, 203, 246, 36, 163, 250, 79, 219, 155, 113, 111, 68, 93, 215, 143, 8, 144, 17, 193, 252, 209, 253, 165, 110, 69, 254, 242, 93, 74, 15, 171, 229, 90, 85, 77, 96, 7, 39, 75, 182, 66, 119, 138, 18, 126, 9, 155, 232, 188, 89 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 7, 3, 23, 6, 910, DateTimeKind.Utc).AddTicks(4553), new byte[] { 24, 37, 49, 106, 178, 210, 182, 191, 161, 58, 94, 10, 121, 30, 207, 232, 159, 193, 103, 21, 26, 247, 167, 100, 69, 234, 156, 86, 142, 189, 207, 4 }, new byte[] { 112, 227, 30, 199, 84, 50, 101, 207, 162, 162, 113, 65, 72, 128, 183, 203, 246, 36, 163, 250, 79, 219, 155, 113, 111, 68, 93, 215, 143, 8, 144, 17, 193, 252, 209, 253, 165, 110, 69, 254, 242, 93, 74, 15, 171, 229, 90, 85, 77, 96, 7, 39, 75, 182, 66, 119, 138, 18, 126, 9, 155, 232, 188, 89 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 7, 3, 23, 6, 910, DateTimeKind.Utc).AddTicks(4528), new byte[] { 24, 37, 49, 106, 178, 210, 182, 191, 161, 58, 94, 10, 121, 30, 207, 232, 159, 193, 103, 21, 26, 247, 167, 100, 69, 234, 156, 86, 142, 189, 207, 4 }, new byte[] { 112, 227, 30, 199, 84, 50, 101, 207, 162, 162, 113, 65, 72, 128, 183, 203, 246, 36, 163, 250, 79, 219, 155, 113, 111, 68, 93, 215, 143, 8, 144, 17, 193, 252, 209, 253, 165, 110, 69, 254, 242, 93, 74, 15, 171, 229, 90, 85, 77, 96, 7, 39, 75, 182, 66, 119, 138, 18, 126, 9, 155, 232, 188, 89 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 7, 3, 23, 6, 910, DateTimeKind.Utc).AddTicks(4564), new byte[] { 24, 37, 49, 106, 178, 210, 182, 191, 161, 58, 94, 10, 121, 30, 207, 232, 159, 193, 103, 21, 26, 247, 167, 100, 69, 234, 156, 86, 142, 189, 207, 4 }, new byte[] { 112, 227, 30, 199, 84, 50, 101, 207, 162, 162, 113, 65, 72, 128, 183, 203, 246, 36, 163, 250, 79, 219, 155, 113, 111, 68, 93, 215, 143, 8, 144, 17, 193, 252, 209, 253, 165, 110, 69, 254, 242, 93, 74, 15, 171, 229, 90, 85, 77, 96, 7, 39, 75, 182, 66, 119, 138, 18, 126, 9, 155, 232, 188, 89 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reason",
                table: "Appointments");

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
    }
}
