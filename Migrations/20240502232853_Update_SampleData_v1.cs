using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_SampleData_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TimeOffs",
                columns: new[] { "IdTimeOff", "Date", "EndTime", "IdDoctor", "Reason", "StartTime", "Status" },
                values: new object[] { 4, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "15:00", new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Busy with family", "13:00", 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 28, 53, 317, DateTimeKind.Utc).AddTicks(1220), new byte[] { 10, 145, 58, 69, 233, 73, 183, 231, 228, 2, 128, 234, 69, 139, 141, 246, 156, 109, 111, 78, 179, 108, 114, 74, 201, 2, 229, 71, 107, 142, 123, 112 }, new byte[] { 229, 156, 160, 114, 66, 204, 195, 233, 167, 58, 66, 44, 124, 187, 12, 128, 7, 69, 124, 18, 195, 8, 37, 233, 21, 192, 154, 82, 40, 24, 178, 10, 188, 123, 149, 192, 245, 246, 52, 80, 252, 195, 160, 102, 153, 67, 240, 43, 188, 73, 10, 91, 107, 59, 88, 116, 65, 25, 184, 123, 165, 45, 81, 97 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 28, 53, 317, DateTimeKind.Utc).AddTicks(1193), new byte[] { 10, 145, 58, 69, 233, 73, 183, 231, 228, 2, 128, 234, 69, 139, 141, 246, 156, 109, 111, 78, 179, 108, 114, 74, 201, 2, 229, 71, 107, 142, 123, 112 }, new byte[] { 229, 156, 160, 114, 66, 204, 195, 233, 167, 58, 66, 44, 124, 187, 12, 128, 7, 69, 124, 18, 195, 8, 37, 233, 21, 192, 154, 82, 40, 24, 178, 10, 188, 123, 149, 192, 245, 246, 52, 80, 252, 195, 160, 102, 153, 67, 240, 43, 188, 73, 10, 91, 107, 59, 88, 116, 65, 25, 184, 123, 165, 45, 81, 97 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 28, 53, 317, DateTimeKind.Utc).AddTicks(1176), new byte[] { 10, 145, 58, 69, 233, 73, 183, 231, 228, 2, 128, 234, 69, 139, 141, 246, 156, 109, 111, 78, 179, 108, 114, 74, 201, 2, 229, 71, 107, 142, 123, 112 }, new byte[] { 229, 156, 160, 114, 66, 204, 195, 233, 167, 58, 66, 44, 124, 187, 12, 128, 7, 69, 124, 18, 195, 8, 37, 233, 21, 192, 154, 82, 40, 24, 178, 10, 188, 123, 149, 192, 245, 246, 52, 80, 252, 195, 160, 102, 153, 67, 240, 43, 188, 73, 10, 91, 107, 59, 88, 116, 65, 25, 184, 123, 165, 45, 81, 97 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 28, 53, 317, DateTimeKind.Utc).AddTicks(1233), new byte[] { 10, 145, 58, 69, 233, 73, 183, 231, 228, 2, 128, 234, 69, 139, 141, 246, 156, 109, 111, 78, 179, 108, 114, 74, 201, 2, 229, 71, 107, 142, 123, 112 }, new byte[] { 229, 156, 160, 114, 66, 204, 195, 233, 167, 58, 66, 44, 124, 187, 12, 128, 7, 69, 124, 18, 195, 8, 37, 233, 21, 192, 154, 82, 40, 24, 178, 10, 188, 123, 149, 192, 245, 246, 52, 80, 252, 195, 160, 102, 153, 67, 240, 43, 188, 73, 10, 91, 107, 59, 88, 116, 65, 25, 184, 123, 165, 45, 81, 97 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 28, 53, 317, DateTimeKind.Utc).AddTicks(1207), new byte[] { 10, 145, 58, 69, 233, 73, 183, 231, 228, 2, 128, 234, 69, 139, 141, 246, 156, 109, 111, 78, 179, 108, 114, 74, 201, 2, 229, 71, 107, 142, 123, 112 }, new byte[] { 229, 156, 160, 114, 66, 204, 195, 233, 167, 58, 66, 44, 124, 187, 12, 128, 7, 69, 124, 18, 195, 8, 37, 233, 21, 192, 154, 82, 40, 24, 178, 10, 188, 123, 149, 192, 245, 246, 52, 80, 252, 195, 160, 102, 153, 67, 240, 43, 188, 73, 10, 91, 107, 59, 88, 116, 65, 25, 184, 123, 165, 45, 81, 97 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 28, 53, 317, DateTimeKind.Utc).AddTicks(1244), new byte[] { 10, 145, 58, 69, 233, 73, 183, 231, 228, 2, 128, 234, 69, 139, 141, 246, 156, 109, 111, 78, 179, 108, 114, 74, 201, 2, 229, 71, 107, 142, 123, 112 }, new byte[] { 229, 156, 160, 114, 66, 204, 195, 233, 167, 58, 66, 44, 124, 187, 12, 128, 7, 69, 124, 18, 195, 8, 37, 233, 21, 192, 154, 82, 40, 24, 178, 10, 188, 123, 149, 192, 245, 246, 52, 80, 252, 195, 160, 102, 153, 67, 240, 43, 188, 73, 10, 91, 107, 59, 88, 116, 65, 25, 184, 123, 165, 45, 81, 97 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 26, 10, 827, DateTimeKind.Utc).AddTicks(7820), new byte[] { 234, 114, 135, 126, 185, 120, 42, 68, 76, 158, 9, 244, 73, 39, 75, 47, 88, 246, 38, 103, 218, 129, 89, 115, 98, 239, 169, 13, 21, 152, 64, 253 }, new byte[] { 117, 187, 95, 165, 12, 165, 21, 92, 30, 190, 245, 130, 59, 33, 202, 114, 234, 31, 246, 195, 29, 154, 27, 98, 34, 240, 121, 22, 216, 135, 43, 170, 23, 157, 39, 34, 234, 123, 104, 191, 228, 200, 120, 208, 124, 169, 249, 106, 1, 166, 112, 114, 137, 41, 241, 102, 160, 43, 252, 176, 242, 245, 132, 242 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 26, 10, 827, DateTimeKind.Utc).AddTicks(7785), new byte[] { 234, 114, 135, 126, 185, 120, 42, 68, 76, 158, 9, 244, 73, 39, 75, 47, 88, 246, 38, 103, 218, 129, 89, 115, 98, 239, 169, 13, 21, 152, 64, 253 }, new byte[] { 117, 187, 95, 165, 12, 165, 21, 92, 30, 190, 245, 130, 59, 33, 202, 114, 234, 31, 246, 195, 29, 154, 27, 98, 34, 240, 121, 22, 216, 135, 43, 170, 23, 157, 39, 34, 234, 123, 104, 191, 228, 200, 120, 208, 124, 169, 249, 106, 1, 166, 112, 114, 137, 41, 241, 102, 160, 43, 252, 176, 242, 245, 132, 242 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 26, 10, 827, DateTimeKind.Utc).AddTicks(7703), new byte[] { 234, 114, 135, 126, 185, 120, 42, 68, 76, 158, 9, 244, 73, 39, 75, 47, 88, 246, 38, 103, 218, 129, 89, 115, 98, 239, 169, 13, 21, 152, 64, 253 }, new byte[] { 117, 187, 95, 165, 12, 165, 21, 92, 30, 190, 245, 130, 59, 33, 202, 114, 234, 31, 246, 195, 29, 154, 27, 98, 34, 240, 121, 22, 216, 135, 43, 170, 23, 157, 39, 34, 234, 123, 104, 191, 228, 200, 120, 208, 124, 169, 249, 106, 1, 166, 112, 114, 137, 41, 241, 102, 160, 43, 252, 176, 242, 245, 132, 242 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 26, 10, 827, DateTimeKind.Utc).AddTicks(7834), new byte[] { 234, 114, 135, 126, 185, 120, 42, 68, 76, 158, 9, 244, 73, 39, 75, 47, 88, 246, 38, 103, 218, 129, 89, 115, 98, 239, 169, 13, 21, 152, 64, 253 }, new byte[] { 117, 187, 95, 165, 12, 165, 21, 92, 30, 190, 245, 130, 59, 33, 202, 114, 234, 31, 246, 195, 29, 154, 27, 98, 34, 240, 121, 22, 216, 135, 43, 170, 23, 157, 39, 34, 234, 123, 104, 191, 228, 200, 120, 208, 124, 169, 249, 106, 1, 166, 112, 114, 137, 41, 241, 102, 160, 43, 252, 176, 242, 245, 132, 242 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 26, 10, 827, DateTimeKind.Utc).AddTicks(7806), new byte[] { 234, 114, 135, 126, 185, 120, 42, 68, 76, 158, 9, 244, 73, 39, 75, 47, 88, 246, 38, 103, 218, 129, 89, 115, 98, 239, 169, 13, 21, 152, 64, 253 }, new byte[] { 117, 187, 95, 165, 12, 165, 21, 92, 30, 190, 245, 130, 59, 33, 202, 114, 234, 31, 246, 195, 29, 154, 27, 98, 34, 240, 121, 22, 216, 135, 43, 170, 23, 157, 39, 34, 234, 123, 104, 191, 228, 200, 120, 208, 124, 169, 249, 106, 1, 166, 112, 114, 137, 41, 241, 102, 160, 43, 252, 176, 242, 245, 132, 242 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 26, 10, 827, DateTimeKind.Utc).AddTicks(7850), new byte[] { 234, 114, 135, 126, 185, 120, 42, 68, 76, 158, 9, 244, 73, 39, 75, 47, 88, 246, 38, 103, 218, 129, 89, 115, 98, 239, 169, 13, 21, 152, 64, 253 }, new byte[] { 117, 187, 95, 165, 12, 165, 21, 92, 30, 190, 245, 130, 59, 33, 202, 114, 234, 31, 246, 195, 29, 154, 27, 98, 34, 240, 121, 22, 216, 135, 43, 170, 23, 157, 39, 34, 234, 123, 104, 191, 228, 200, 120, 208, 124, 169, 249, 106, 1, 166, 112, 114, 137, 41, 241, 102, 160, 43, 252, 176, 242, 245, 132, 242 } });
        }
    }
}
