using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableDoctor_v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalFreeSlot",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "TotalFreeSlot",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "TotalFreeSlot",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "TotalFreeSlot",
                value: 10);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 22, 52, 31, 551, DateTimeKind.Utc).AddTicks(6909), new byte[] { 104, 160, 152, 165, 255, 72, 108, 215, 226, 76, 254, 130, 254, 230, 91, 253, 66, 86, 74, 204, 89, 95, 117, 107, 110, 167, 180, 168, 6, 79, 255, 37 }, new byte[] { 1, 247, 213, 6, 129, 72, 216, 16, 234, 172, 173, 235, 20, 85, 50, 244, 25, 115, 39, 106, 236, 70, 224, 74, 126, 181, 172, 188, 128, 48, 64, 96, 219, 78, 228, 100, 50, 105, 64, 208, 166, 74, 154, 244, 119, 52, 200, 123, 224, 241, 202, 153, 91, 180, 25, 153, 160, 175, 61, 10, 222, 120, 169, 19 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 22, 52, 31, 551, DateTimeKind.Utc).AddTicks(6885), new byte[] { 104, 160, 152, 165, 255, 72, 108, 215, 226, 76, 254, 130, 254, 230, 91, 253, 66, 86, 74, 204, 89, 95, 117, 107, 110, 167, 180, 168, 6, 79, 255, 37 }, new byte[] { 1, 247, 213, 6, 129, 72, 216, 16, 234, 172, 173, 235, 20, 85, 50, 244, 25, 115, 39, 106, 236, 70, 224, 74, 126, 181, 172, 188, 128, 48, 64, 96, 219, 78, 228, 100, 50, 105, 64, 208, 166, 74, 154, 244, 119, 52, 200, 123, 224, 241, 202, 153, 91, 180, 25, 153, 160, 175, 61, 10, 222, 120, 169, 19 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 22, 52, 31, 551, DateTimeKind.Utc).AddTicks(6867), new byte[] { 104, 160, 152, 165, 255, 72, 108, 215, 226, 76, 254, 130, 254, 230, 91, 253, 66, 86, 74, 204, 89, 95, 117, 107, 110, 167, 180, 168, 6, 79, 255, 37 }, new byte[] { 1, 247, 213, 6, 129, 72, 216, 16, 234, 172, 173, 235, 20, 85, 50, 244, 25, 115, 39, 106, 236, 70, 224, 74, 126, 181, 172, 188, 128, 48, 64, 96, 219, 78, 228, 100, 50, 105, 64, 208, 166, 74, 154, 244, 119, 52, 200, 123, 224, 241, 202, 153, 91, 180, 25, 153, 160, 175, 61, 10, 222, 120, 169, 19 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 22, 52, 31, 551, DateTimeKind.Utc).AddTicks(6922), new byte[] { 104, 160, 152, 165, 255, 72, 108, 215, 226, 76, 254, 130, 254, 230, 91, 253, 66, 86, 74, 204, 89, 95, 117, 107, 110, 167, 180, 168, 6, 79, 255, 37 }, new byte[] { 1, 247, 213, 6, 129, 72, 216, 16, 234, 172, 173, 235, 20, 85, 50, 244, 25, 115, 39, 106, 236, 70, 224, 74, 126, 181, 172, 188, 128, 48, 64, 96, 219, 78, 228, 100, 50, 105, 64, 208, 166, 74, 154, 244, 119, 52, 200, 123, 224, 241, 202, 153, 91, 180, 25, 153, 160, 175, 61, 10, 222, 120, 169, 19 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 22, 52, 31, 551, DateTimeKind.Utc).AddTicks(6896), new byte[] { 104, 160, 152, 165, 255, 72, 108, 215, 226, 76, 254, 130, 254, 230, 91, 253, 66, 86, 74, 204, 89, 95, 117, 107, 110, 167, 180, 168, 6, 79, 255, 37 }, new byte[] { 1, 247, 213, 6, 129, 72, 216, 16, 234, 172, 173, 235, 20, 85, 50, 244, 25, 115, 39, 106, 236, 70, 224, 74, 126, 181, 172, 188, 128, 48, 64, 96, 219, 78, 228, 100, 50, 105, 64, 208, 166, 74, 154, 244, 119, 52, 200, 123, 224, 241, 202, 153, 91, 180, 25, 153, 160, 175, 61, 10, 222, 120, 169, 19 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 22, 52, 31, 551, DateTimeKind.Utc).AddTicks(6934), new byte[] { 104, 160, 152, 165, 255, 72, 108, 215, 226, 76, 254, 130, 254, 230, 91, 253, 66, 86, 74, 204, 89, 95, 117, 107, 110, 167, 180, 168, 6, 79, 255, 37 }, new byte[] { 1, 247, 213, 6, 129, 72, 216, 16, 234, 172, 173, 235, 20, 85, 50, 244, 25, 115, 39, 106, 236, 70, 224, 74, 126, 181, 172, 188, 128, 48, 64, 96, 219, 78, 228, 100, 50, 105, 64, 208, 166, 74, 154, 244, 119, 52, 200, 123, 224, 241, 202, 153, 91, 180, 25, 153, 160, 175, 61, 10, 222, 120, 169, 19 } });
        }
    }
}
