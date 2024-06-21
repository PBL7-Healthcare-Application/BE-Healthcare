using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableUser_v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDay",
                table: "User",
                newName: "CreatedDate");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 14, 17, 778, DateTimeKind.Utc).AddTicks(7160), new byte[] { 13, 86, 33, 183, 57, 84, 3, 29, 170, 51, 93, 146, 189, 131, 181, 218, 49, 149, 194, 112, 251, 217, 36, 228, 46, 193, 23, 154, 127, 81, 72, 184 }, new byte[] { 91, 24, 45, 141, 112, 112, 246, 43, 144, 144, 1, 17, 186, 239, 3, 29, 168, 191, 251, 85, 167, 208, 186, 65, 114, 137, 193, 169, 91, 29, 171, 128, 19, 183, 13, 154, 186, 221, 45, 198, 7, 39, 20, 178, 143, 184, 146, 133, 49, 60, 146, 191, 82, 9, 170, 104, 148, 23, 166, 24, 226, 166, 251, 43 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 14, 17, 778, DateTimeKind.Utc).AddTicks(7133), new byte[] { 13, 86, 33, 183, 57, 84, 3, 29, 170, 51, 93, 146, 189, 131, 181, 218, 49, 149, 194, 112, 251, 217, 36, 228, 46, 193, 23, 154, 127, 81, 72, 184 }, new byte[] { 91, 24, 45, 141, 112, 112, 246, 43, 144, 144, 1, 17, 186, 239, 3, 29, 168, 191, 251, 85, 167, 208, 186, 65, 114, 137, 193, 169, 91, 29, 171, 128, 19, 183, 13, 154, 186, 221, 45, 198, 7, 39, 20, 178, 143, 184, 146, 133, 49, 60, 146, 191, 82, 9, 170, 104, 148, 23, 166, 24, 226, 166, 251, 43 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 14, 17, 778, DateTimeKind.Utc).AddTicks(7112), new byte[] { 13, 86, 33, 183, 57, 84, 3, 29, 170, 51, 93, 146, 189, 131, 181, 218, 49, 149, 194, 112, 251, 217, 36, 228, 46, 193, 23, 154, 127, 81, 72, 184 }, new byte[] { 91, 24, 45, 141, 112, 112, 246, 43, 144, 144, 1, 17, 186, 239, 3, 29, 168, 191, 251, 85, 167, 208, 186, 65, 114, 137, 193, 169, 91, 29, 171, 128, 19, 183, 13, 154, 186, 221, 45, 198, 7, 39, 20, 178, 143, 184, 146, 133, 49, 60, 146, 191, 82, 9, 170, 104, 148, 23, 166, 24, 226, 166, 251, 43 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 14, 17, 778, DateTimeKind.Utc).AddTicks(7173), new byte[] { 13, 86, 33, 183, 57, 84, 3, 29, 170, 51, 93, 146, 189, 131, 181, 218, 49, 149, 194, 112, 251, 217, 36, 228, 46, 193, 23, 154, 127, 81, 72, 184 }, new byte[] { 91, 24, 45, 141, 112, 112, 246, 43, 144, 144, 1, 17, 186, 239, 3, 29, 168, 191, 251, 85, 167, 208, 186, 65, 114, 137, 193, 169, 91, 29, 171, 128, 19, 183, 13, 154, 186, 221, 45, 198, 7, 39, 20, 178, 143, 184, 146, 133, 49, 60, 146, 191, 82, 9, 170, 104, 148, 23, 166, 24, 226, 166, 251, 43 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 14, 17, 778, DateTimeKind.Utc).AddTicks(7147), new byte[] { 13, 86, 33, 183, 57, 84, 3, 29, 170, 51, 93, 146, 189, 131, 181, 218, 49, 149, 194, 112, 251, 217, 36, 228, 46, 193, 23, 154, 127, 81, 72, 184 }, new byte[] { 91, 24, 45, 141, 112, 112, 246, 43, 144, 144, 1, 17, 186, 239, 3, 29, 168, 191, 251, 85, 167, 208, 186, 65, 114, 137, 193, 169, 91, 29, 171, 128, 19, 183, 13, 154, 186, 221, 45, 198, 7, 39, 20, 178, 143, 184, 146, 133, 49, 60, 146, 191, 82, 9, 170, 104, 148, 23, 166, 24, 226, 166, 251, 43 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 14, 17, 778, DateTimeKind.Utc).AddTicks(7199), new byte[] { 13, 86, 33, 183, 57, 84, 3, 29, 170, 51, 93, 146, 189, 131, 181, 218, 49, 149, 194, 112, 251, 217, 36, 228, 46, 193, 23, 154, 127, 81, 72, 184 }, new byte[] { 91, 24, 45, 141, 112, 112, 246, 43, 144, 144, 1, 17, 186, 239, 3, 29, 168, 191, 251, 85, 167, 208, 186, 65, 114, 137, 193, 169, 91, 29, 171, 128, 19, 183, 13, 154, 186, 221, 45, 198, 7, 39, 20, 178, 143, 184, 146, 133, 49, 60, 146, 191, 82, 9, 170, 104, 148, 23, 166, 24, 226, 166, 251, 43 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 14, 17, 778, DateTimeKind.Utc).AddTicks(7186), new byte[] { 13, 86, 33, 183, 57, 84, 3, 29, 170, 51, 93, 146, 189, 131, 181, 218, 49, 149, 194, 112, 251, 217, 36, 228, 46, 193, 23, 154, 127, 81, 72, 184 }, new byte[] { 91, 24, 45, 141, 112, 112, 246, 43, 144, 144, 1, 17, 186, 239, 3, 29, 168, 191, 251, 85, 167, 208, 186, 65, 114, 137, 193, 169, 91, 29, 171, 128, 19, 183, 13, 154, 186, 221, 45, 198, 7, 39, 20, 178, 143, 184, 146, 133, 49, 60, 146, 191, 82, 9, 170, 104, 148, 23, 166, 24, 226, 166, 251, 43 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "User",
                newName: "CreatedDay");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4770), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4747), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4729), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4781), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4759), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4803), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 8, 11, 372, DateTimeKind.Utc).AddTicks(4792), new byte[] { 227, 64, 67, 20, 169, 108, 108, 85, 170, 164, 98, 34, 111, 33, 180, 72, 219, 58, 50, 197, 8, 217, 69, 174, 227, 255, 204, 132, 5, 185, 76, 14 }, new byte[] { 138, 116, 55, 42, 208, 239, 154, 2, 249, 217, 165, 222, 191, 21, 252, 239, 41, 70, 11, 59, 145, 186, 160, 71, 92, 157, 107, 167, 13, 87, 84, 82, 227, 3, 242, 58, 16, 179, 127, 38, 235, 112, 183, 174, 73, 241, 67, 248, 154, 14, 48, 191, 111, 74, 240, 243, 135, 6, 37, 218, 94, 193, 161, 232 } });
        }
    }
}
