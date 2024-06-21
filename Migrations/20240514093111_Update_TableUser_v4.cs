using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableUser_v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "User",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsLocked",
                table: "User",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAdminDisabled",
                table: "User",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "IsAdminDisabled", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { false, new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6859), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "IsAdminDisabled", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { false, new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6832), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "IsAdminDisabled", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { false, new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6811), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "IsAdminDisabled", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { false, new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6870), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "IsAdminDisabled", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { false, new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6844), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "IsAdminDisabled", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { false, new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6893), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "IsAdminDisabled", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { false, new DateTime(2024, 5, 14, 9, 31, 11, 453, DateTimeKind.Utc).AddTicks(6881), new byte[] { 62, 104, 124, 52, 195, 95, 65, 234, 56, 245, 145, 221, 243, 168, 105, 93, 4, 180, 162, 88, 0, 55, 123, 238, 216, 174, 206, 190, 244, 128, 113, 236 }, new byte[] { 96, 1, 164, 57, 236, 233, 122, 160, 83, 220, 13, 158, 99, 245, 235, 34, 219, 206, 217, 128, 235, 130, 194, 25, 125, 72, 241, 74, 122, 31, 70, 206, 236, 209, 82, 201, 207, 124, 162, 48, 34, 149, 152, 53, 68, 233, 238, 106, 205, 148, 89, 104, 211, 209, 159, 20, 107, 141, 210, 114, 28, 240, 53, 130 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdminDisabled",
                table: "User");

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "User",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsLocked",
                table: "User",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 23, 47, 843, DateTimeKind.Utc).AddTicks(7448), new byte[] { 90, 232, 249, 126, 255, 158, 76, 73, 147, 240, 130, 10, 104, 92, 69, 126, 0, 99, 202, 225, 233, 140, 44, 190, 23, 37, 78, 242, 22, 49, 126, 138 }, new byte[] { 35, 195, 93, 58, 182, 46, 95, 183, 207, 150, 165, 222, 62, 177, 180, 118, 122, 92, 146, 187, 52, 184, 95, 99, 94, 127, 144, 134, 65, 182, 58, 28, 89, 198, 9, 126, 149, 66, 39, 90, 192, 204, 113, 83, 236, 14, 233, 124, 34, 243, 44, 225, 225, 186, 77, 132, 219, 144, 163, 186, 58, 42, 156, 90 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 23, 47, 843, DateTimeKind.Utc).AddTicks(7422), new byte[] { 90, 232, 249, 126, 255, 158, 76, 73, 147, 240, 130, 10, 104, 92, 69, 126, 0, 99, 202, 225, 233, 140, 44, 190, 23, 37, 78, 242, 22, 49, 126, 138 }, new byte[] { 35, 195, 93, 58, 182, 46, 95, 183, 207, 150, 165, 222, 62, 177, 180, 118, 122, 92, 146, 187, 52, 184, 95, 99, 94, 127, 144, 134, 65, 182, 58, 28, 89, 198, 9, 126, 149, 66, 39, 90, 192, 204, 113, 83, 236, 14, 233, 124, 34, 243, 44, 225, 225, 186, 77, 132, 219, 144, 163, 186, 58, 42, 156, 90 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 23, 47, 843, DateTimeKind.Utc).AddTicks(7405), new byte[] { 90, 232, 249, 126, 255, 158, 76, 73, 147, 240, 130, 10, 104, 92, 69, 126, 0, 99, 202, 225, 233, 140, 44, 190, 23, 37, 78, 242, 22, 49, 126, 138 }, new byte[] { 35, 195, 93, 58, 182, 46, 95, 183, 207, 150, 165, 222, 62, 177, 180, 118, 122, 92, 146, 187, 52, 184, 95, 99, 94, 127, 144, 134, 65, 182, 58, 28, 89, 198, 9, 126, 149, 66, 39, 90, 192, 204, 113, 83, 236, 14, 233, 124, 34, 243, 44, 225, 225, 186, 77, 132, 219, 144, 163, 186, 58, 42, 156, 90 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 23, 47, 843, DateTimeKind.Utc).AddTicks(7460), new byte[] { 90, 232, 249, 126, 255, 158, 76, 73, 147, 240, 130, 10, 104, 92, 69, 126, 0, 99, 202, 225, 233, 140, 44, 190, 23, 37, 78, 242, 22, 49, 126, 138 }, new byte[] { 35, 195, 93, 58, 182, 46, 95, 183, 207, 150, 165, 222, 62, 177, 180, 118, 122, 92, 146, 187, 52, 184, 95, 99, 94, 127, 144, 134, 65, 182, 58, 28, 89, 198, 9, 126, 149, 66, 39, 90, 192, 204, 113, 83, 236, 14, 233, 124, 34, 243, 44, 225, 225, 186, 77, 132, 219, 144, 163, 186, 58, 42, 156, 90 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 23, 47, 843, DateTimeKind.Utc).AddTicks(7435), new byte[] { 90, 232, 249, 126, 255, 158, 76, 73, 147, 240, 130, 10, 104, 92, 69, 126, 0, 99, 202, 225, 233, 140, 44, 190, 23, 37, 78, 242, 22, 49, 126, 138 }, new byte[] { 35, 195, 93, 58, 182, 46, 95, 183, 207, 150, 165, 222, 62, 177, 180, 118, 122, 92, 146, 187, 52, 184, 95, 99, 94, 127, 144, 134, 65, 182, 58, 28, 89, 198, 9, 126, 149, 66, 39, 90, 192, 204, 113, 83, 236, 14, 233, 124, 34, 243, 44, 225, 225, 186, 77, 132, 219, 144, 163, 186, 58, 42, 156, 90 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 23, 47, 843, DateTimeKind.Utc).AddTicks(7485), new byte[] { 90, 232, 249, 126, 255, 158, 76, 73, 147, 240, 130, 10, 104, 92, 69, 126, 0, 99, 202, 225, 233, 140, 44, 190, 23, 37, 78, 242, 22, 49, 126, 138 }, new byte[] { 35, 195, 93, 58, 182, 46, 95, 183, 207, 150, 165, 222, 62, 177, 180, 118, 122, 92, 146, 187, 52, 184, 95, 99, 94, 127, 144, 134, 65, 182, 58, 28, 89, 198, 9, 126, 149, 66, 39, 90, 192, 204, 113, 83, 236, 14, 233, 124, 34, 243, 44, 225, 225, 186, 77, 132, 219, 144, 163, 186, 58, 42, 156, 90 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 23, 47, 843, DateTimeKind.Utc).AddTicks(7472), new byte[] { 90, 232, 249, 126, 255, 158, 76, 73, 147, 240, 130, 10, 104, 92, 69, 126, 0, 99, 202, 225, 233, 140, 44, 190, 23, 37, 78, 242, 22, 49, 126, 138 }, new byte[] { 35, 195, 93, 58, 182, 46, 95, 183, 207, 150, 165, 222, 62, 177, 180, 118, 122, 92, 146, 187, 52, 184, 95, 99, 94, 127, 144, 134, 65, 182, 58, 28, 89, 198, 9, 126, 149, 66, 39, 90, 192, 204, 113, 83, 236, 14, 233, 124, 34, 243, 44, 225, 225, 186, 77, 132, 219, 144, 163, 186, 58, 42, 156, 90 } });
        }
    }
}
