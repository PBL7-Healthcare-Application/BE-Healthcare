using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableUser_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLocked",
                table: "User",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReasonLockAccount",
                table: "User",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "IsLocked", "OTPCreatedAt", "PasswordHash", "PasswordSalt", "ReasonLockAccount" },
                values: new object[] { false, new DateTime(2024, 5, 7, 6, 46, 34, 921, DateTimeKind.Utc).AddTicks(7706), new byte[] { 74, 184, 239, 78, 241, 80, 43, 96, 219, 151, 116, 33, 222, 190, 200, 221, 3, 146, 6, 240, 221, 76, 26, 128, 60, 173, 229, 171, 53, 112, 180, 65 }, new byte[] { 35, 246, 10, 86, 34, 92, 123, 80, 90, 108, 138, 186, 57, 115, 36, 217, 141, 190, 154, 58, 38, 163, 178, 21, 169, 157, 195, 207, 161, 210, 50, 253, 229, 27, 3, 115, 21, 92, 246, 90, 208, 31, 7, 6, 112, 132, 187, 126, 137, 160, 49, 205, 172, 165, 72, 14, 45, 119, 221, 162, 126, 235, 148, 191 }, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "IsLocked", "OTPCreatedAt", "PasswordHash", "PasswordSalt", "ReasonLockAccount" },
                values: new object[] { false, new DateTime(2024, 5, 7, 6, 46, 34, 921, DateTimeKind.Utc).AddTicks(7631), new byte[] { 74, 184, 239, 78, 241, 80, 43, 96, 219, 151, 116, 33, 222, 190, 200, 221, 3, 146, 6, 240, 221, 76, 26, 128, 60, 173, 229, 171, 53, 112, 180, 65 }, new byte[] { 35, 246, 10, 86, 34, 92, 123, 80, 90, 108, 138, 186, 57, 115, 36, 217, 141, 190, 154, 58, 38, 163, 178, 21, 169, 157, 195, 207, 161, 210, 50, 253, 229, 27, 3, 115, 21, 92, 246, 90, 208, 31, 7, 6, 112, 132, 187, 126, 137, 160, 49, 205, 172, 165, 72, 14, 45, 119, 221, 162, 126, 235, 148, 191 }, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "IsLocked", "OTPCreatedAt", "PasswordHash", "PasswordSalt", "ReasonLockAccount" },
                values: new object[] { false, new DateTime(2024, 5, 7, 6, 46, 34, 921, DateTimeKind.Utc).AddTicks(7612), new byte[] { 74, 184, 239, 78, 241, 80, 43, 96, 219, 151, 116, 33, 222, 190, 200, 221, 3, 146, 6, 240, 221, 76, 26, 128, 60, 173, 229, 171, 53, 112, 180, 65 }, new byte[] { 35, 246, 10, 86, 34, 92, 123, 80, 90, 108, 138, 186, 57, 115, 36, 217, 141, 190, 154, 58, 38, 163, 178, 21, 169, 157, 195, 207, 161, 210, 50, 253, 229, 27, 3, 115, 21, 92, 246, 90, 208, 31, 7, 6, 112, 132, 187, 126, 137, 160, 49, 205, 172, 165, 72, 14, 45, 119, 221, 162, 126, 235, 148, 191 }, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "IsLocked", "OTPCreatedAt", "PasswordHash", "PasswordSalt", "ReasonLockAccount" },
                values: new object[] { false, new DateTime(2024, 5, 7, 6, 46, 34, 921, DateTimeKind.Utc).AddTicks(7718), new byte[] { 74, 184, 239, 78, 241, 80, 43, 96, 219, 151, 116, 33, 222, 190, 200, 221, 3, 146, 6, 240, 221, 76, 26, 128, 60, 173, 229, 171, 53, 112, 180, 65 }, new byte[] { 35, 246, 10, 86, 34, 92, 123, 80, 90, 108, 138, 186, 57, 115, 36, 217, 141, 190, 154, 58, 38, 163, 178, 21, 169, 157, 195, 207, 161, 210, 50, 253, 229, 27, 3, 115, 21, 92, 246, 90, 208, 31, 7, 6, 112, 132, 187, 126, 137, 160, 49, 205, 172, 165, 72, 14, 45, 119, 221, 162, 126, 235, 148, 191 }, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "IsLocked", "OTPCreatedAt", "PasswordHash", "PasswordSalt", "ReasonLockAccount" },
                values: new object[] { false, new DateTime(2024, 5, 7, 6, 46, 34, 921, DateTimeKind.Utc).AddTicks(7665), new byte[] { 74, 184, 239, 78, 241, 80, 43, 96, 219, 151, 116, 33, 222, 190, 200, 221, 3, 146, 6, 240, 221, 76, 26, 128, 60, 173, 229, 171, 53, 112, 180, 65 }, new byte[] { 35, 246, 10, 86, 34, 92, 123, 80, 90, 108, 138, 186, 57, 115, 36, 217, 141, 190, 154, 58, 38, 163, 178, 21, 169, 157, 195, 207, 161, 210, 50, 253, 229, 27, 3, 115, 21, 92, 246, 90, 208, 31, 7, 6, 112, 132, 187, 126, 137, 160, 49, 205, 172, 165, 72, 14, 45, 119, 221, 162, 126, 235, 148, 191 }, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "IsLocked", "OTPCreatedAt", "PasswordHash", "PasswordSalt", "ReasonLockAccount" },
                values: new object[] { false, new DateTime(2024, 5, 7, 6, 46, 34, 921, DateTimeKind.Utc).AddTicks(7729), new byte[] { 74, 184, 239, 78, 241, 80, 43, 96, 219, 151, 116, 33, 222, 190, 200, 221, 3, 146, 6, 240, 221, 76, 26, 128, 60, 173, 229, 171, 53, 112, 180, 65 }, new byte[] { 35, 246, 10, 86, 34, 92, 123, 80, 90, 108, 138, 186, 57, 115, 36, 217, 141, 190, 154, 58, 38, 163, 178, 21, 169, 157, 195, 207, 161, 210, 50, 253, 229, 27, 3, 115, 21, 92, 246, 90, 208, 31, 7, 6, 112, 132, 187, 126, 137, 160, 49, 205, 172, 165, 72, 14, 45, 119, 221, 162, 126, 235, 148, 191 }, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLocked",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ReasonLockAccount",
                table: "User");

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
    }
}
