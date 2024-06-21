using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_Dataset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "IdAppointment", "Date", "EndTime", "IdDoctor", "IdUser", "Issue", "StartTime", "Status", "Type" },
                values: new object[,]
                {
                    { 7, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "16:00", new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), new Guid("9117c626-c3d0-4d14-b345-d70d85268623"), "Toi bi dau bung", "15:00", 1, false },
                    { 8, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "17:00", new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), new Guid("9117c626-c3d0-4d14-b345-d70d85268623"), "Toi bi dau bung non", "16:00", 1, false },
                    { 9, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "9:00", new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), new Guid("9117c626-c3d0-4d14-b345-d70d85268623"), "Toi bi dau bung non", "8:00", 1, false }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
