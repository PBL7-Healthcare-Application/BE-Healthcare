using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableUser_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDay",
                table: "User",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedDay", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4770), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedDay", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4747), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedDay", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4729), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedDay", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4781), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedDay", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4759), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedDay", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4803), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedDay", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4792), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDay",
                table: "User");

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
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 9, 38, 950, DateTimeKind.Utc).AddTicks(3843), new byte[] { 23, 67, 164, 251, 193, 30, 97, 128, 244, 80, 57, 37, 101, 22, 183, 163, 201, 240, 135, 104, 0, 144, 199, 113, 93, 62, 173, 185, 195, 40, 146, 123 }, new byte[] { 230, 203, 30, 30, 61, 173, 90, 155, 239, 213, 117, 40, 59, 201, 101, 221, 226, 211, 237, 99, 89, 22, 237, 240, 185, 231, 204, 60, 255, 72, 196, 239, 202, 247, 157, 95, 24, 135, 1, 209, 193, 66, 27, 58, 132, 77, 191, 33, 76, 134, 237, 108, 229, 179, 188, 140, 35, 232, 227, 192, 97, 54, 218, 173 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 9, 38, 950, DateTimeKind.Utc).AddTicks(3825), new byte[] { 23, 67, 164, 251, 193, 30, 97, 128, 244, 80, 57, 37, 101, 22, 183, 163, 201, 240, 135, 104, 0, 144, 199, 113, 93, 62, 173, 185, 195, 40, 146, 123 }, new byte[] { 230, 203, 30, 30, 61, 173, 90, 155, 239, 213, 117, 40, 59, 201, 101, 221, 226, 211, 237, 99, 89, 22, 237, 240, 185, 231, 204, 60, 255, 72, 196, 239, 202, 247, 157, 95, 24, 135, 1, 209, 193, 66, 27, 58, 132, 77, 191, 33, 76, 134, 237, 108, 229, 179, 188, 140, 35, 232, 227, 192, 97, 54, 218, 173 } });
        }
    }
}
