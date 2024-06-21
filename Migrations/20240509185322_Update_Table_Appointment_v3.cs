using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_Table_Appointment_v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDoctorCancel",
                table: "Appointments",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isUserCancel",
                table: "Appointments",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                columns: new[] { "isDoctorCancel", "isUserCancel" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                columns: new[] { "isDoctorCancel", "isUserCancel" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                columns: new[] { "isDoctorCancel", "isUserCancel" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                columns: new[] { "isDoctorCancel", "isUserCancel" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                columns: new[] { "isDoctorCancel", "isUserCancel" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 53, 21, 891, DateTimeKind.Utc).AddTicks(5732), new byte[] { 241, 184, 9, 204, 85, 191, 111, 81, 144, 141, 154, 53, 61, 79, 206, 30, 94, 54, 119, 44, 158, 152, 238, 158, 41, 200, 68, 19, 23, 7, 212, 249 }, new byte[] { 228, 62, 240, 204, 152, 236, 46, 204, 225, 195, 192, 205, 180, 128, 207, 198, 74, 12, 41, 161, 165, 74, 22, 229, 88, 144, 120, 199, 215, 126, 75, 250, 26, 82, 141, 7, 194, 124, 132, 247, 113, 177, 227, 247, 180, 58, 240, 252, 5, 118, 216, 219, 43, 111, 32, 27, 162, 239, 137, 113, 183, 34, 199, 83 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 53, 21, 891, DateTimeKind.Utc).AddTicks(5703), new byte[] { 241, 184, 9, 204, 85, 191, 111, 81, 144, 141, 154, 53, 61, 79, 206, 30, 94, 54, 119, 44, 158, 152, 238, 158, 41, 200, 68, 19, 23, 7, 212, 249 }, new byte[] { 228, 62, 240, 204, 152, 236, 46, 204, 225, 195, 192, 205, 180, 128, 207, 198, 74, 12, 41, 161, 165, 74, 22, 229, 88, 144, 120, 199, 215, 126, 75, 250, 26, 82, 141, 7, 194, 124, 132, 247, 113, 177, 227, 247, 180, 58, 240, 252, 5, 118, 216, 219, 43, 111, 32, 27, 162, 239, 137, 113, 183, 34, 199, 83 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 53, 21, 891, DateTimeKind.Utc).AddTicks(5682), new byte[] { 241, 184, 9, 204, 85, 191, 111, 81, 144, 141, 154, 53, 61, 79, 206, 30, 94, 54, 119, 44, 158, 152, 238, 158, 41, 200, 68, 19, 23, 7, 212, 249 }, new byte[] { 228, 62, 240, 204, 152, 236, 46, 204, 225, 195, 192, 205, 180, 128, 207, 198, 74, 12, 41, 161, 165, 74, 22, 229, 88, 144, 120, 199, 215, 126, 75, 250, 26, 82, 141, 7, 194, 124, 132, 247, 113, 177, 227, 247, 180, 58, 240, 252, 5, 118, 216, 219, 43, 111, 32, 27, 162, 239, 137, 113, 183, 34, 199, 83 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 53, 21, 891, DateTimeKind.Utc).AddTicks(5745), new byte[] { 241, 184, 9, 204, 85, 191, 111, 81, 144, 141, 154, 53, 61, 79, 206, 30, 94, 54, 119, 44, 158, 152, 238, 158, 41, 200, 68, 19, 23, 7, 212, 249 }, new byte[] { 228, 62, 240, 204, 152, 236, 46, 204, 225, 195, 192, 205, 180, 128, 207, 198, 74, 12, 41, 161, 165, 74, 22, 229, 88, 144, 120, 199, 215, 126, 75, 250, 26, 82, 141, 7, 194, 124, 132, 247, 113, 177, 227, 247, 180, 58, 240, 252, 5, 118, 216, 219, 43, 111, 32, 27, 162, 239, 137, 113, 183, 34, 199, 83 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 53, 21, 891, DateTimeKind.Utc).AddTicks(5718), new byte[] { 241, 184, 9, 204, 85, 191, 111, 81, 144, 141, 154, 53, 61, 79, 206, 30, 94, 54, 119, 44, 158, 152, 238, 158, 41, 200, 68, 19, 23, 7, 212, 249 }, new byte[] { 228, 62, 240, 204, 152, 236, 46, 204, 225, 195, 192, 205, 180, 128, 207, 198, 74, 12, 41, 161, 165, 74, 22, 229, 88, 144, 120, 199, 215, 126, 75, 250, 26, 82, 141, 7, 194, 124, 132, 247, 113, 177, 227, 247, 180, 58, 240, 252, 5, 118, 216, 219, 43, 111, 32, 27, 162, 239, 137, 113, 183, 34, 199, 83 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 53, 21, 891, DateTimeKind.Utc).AddTicks(5758), new byte[] { 241, 184, 9, 204, 85, 191, 111, 81, 144, 141, 154, 53, 61, 79, 206, 30, 94, 54, 119, 44, 158, 152, 238, 158, 41, 200, 68, 19, 23, 7, 212, 249 }, new byte[] { 228, 62, 240, 204, 152, 236, 46, 204, 225, 195, 192, 205, 180, 128, 207, 198, 74, 12, 41, 161, 165, 74, 22, 229, 88, 144, 120, 199, 215, 126, 75, 250, 26, 82, 141, 7, 194, 124, 132, 247, 113, 177, 227, 247, 180, 58, 240, 252, 5, 118, 216, 219, 43, 111, 32, 27, 162, 239, 137, 113, 183, 34, 199, 83 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDoctorCancel",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "isUserCancel",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 7, 6, 46, 34, 921, DateTimeKind.Utc).AddTicks(7706), new byte[] { 74, 184, 239, 78, 241, 80, 43, 96, 219, 151, 116, 33, 222, 190, 200, 221, 3, 146, 6, 240, 221, 76, 26, 128, 60, 173, 229, 171, 53, 112, 180, 65 }, new byte[] { 35, 246, 10, 86, 34, 92, 123, 80, 90, 108, 138, 186, 57, 115, 36, 217, 141, 190, 154, 58, 38, 163, 178, 21, 169, 157, 195, 207, 161, 210, 50, 253, 229, 27, 3, 115, 21, 92, 246, 90, 208, 31, 7, 6, 112, 132, 187, 126, 137, 160, 49, 205, 172, 165, 72, 14, 45, 119, 221, 162, 126, 235, 148, 191 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 7, 6, 46, 34, 921, DateTimeKind.Utc).AddTicks(7631), new byte[] { 74, 184, 239, 78, 241, 80, 43, 96, 219, 151, 116, 33, 222, 190, 200, 221, 3, 146, 6, 240, 221, 76, 26, 128, 60, 173, 229, 171, 53, 112, 180, 65 }, new byte[] { 35, 246, 10, 86, 34, 92, 123, 80, 90, 108, 138, 186, 57, 115, 36, 217, 141, 190, 154, 58, 38, 163, 178, 21, 169, 157, 195, 207, 161, 210, 50, 253, 229, 27, 3, 115, 21, 92, 246, 90, 208, 31, 7, 6, 112, 132, 187, 126, 137, 160, 49, 205, 172, 165, 72, 14, 45, 119, 221, 162, 126, 235, 148, 191 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 7, 6, 46, 34, 921, DateTimeKind.Utc).AddTicks(7612), new byte[] { 74, 184, 239, 78, 241, 80, 43, 96, 219, 151, 116, 33, 222, 190, 200, 221, 3, 146, 6, 240, 221, 76, 26, 128, 60, 173, 229, 171, 53, 112, 180, 65 }, new byte[] { 35, 246, 10, 86, 34, 92, 123, 80, 90, 108, 138, 186, 57, 115, 36, 217, 141, 190, 154, 58, 38, 163, 178, 21, 169, 157, 195, 207, 161, 210, 50, 253, 229, 27, 3, 115, 21, 92, 246, 90, 208, 31, 7, 6, 112, 132, 187, 126, 137, 160, 49, 205, 172, 165, 72, 14, 45, 119, 221, 162, 126, 235, 148, 191 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 7, 6, 46, 34, 921, DateTimeKind.Utc).AddTicks(7718), new byte[] { 74, 184, 239, 78, 241, 80, 43, 96, 219, 151, 116, 33, 222, 190, 200, 221, 3, 146, 6, 240, 221, 76, 26, 128, 60, 173, 229, 171, 53, 112, 180, 65 }, new byte[] { 35, 246, 10, 86, 34, 92, 123, 80, 90, 108, 138, 186, 57, 115, 36, 217, 141, 190, 154, 58, 38, 163, 178, 21, 169, 157, 195, 207, 161, 210, 50, 253, 229, 27, 3, 115, 21, 92, 246, 90, 208, 31, 7, 6, 112, 132, 187, 126, 137, 160, 49, 205, 172, 165, 72, 14, 45, 119, 221, 162, 126, 235, 148, 191 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 7, 6, 46, 34, 921, DateTimeKind.Utc).AddTicks(7665), new byte[] { 74, 184, 239, 78, 241, 80, 43, 96, 219, 151, 116, 33, 222, 190, 200, 221, 3, 146, 6, 240, 221, 76, 26, 128, 60, 173, 229, 171, 53, 112, 180, 65 }, new byte[] { 35, 246, 10, 86, 34, 92, 123, 80, 90, 108, 138, 186, 57, 115, 36, 217, 141, 190, 154, 58, 38, 163, 178, 21, 169, 157, 195, 207, 161, 210, 50, 253, 229, 27, 3, 115, 21, 92, 246, 90, 208, 31, 7, 6, 112, 132, 187, 126, 137, 160, 49, 205, 172, 165, 72, 14, 45, 119, 221, 162, 126, 235, 148, 191 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 7, 6, 46, 34, 921, DateTimeKind.Utc).AddTicks(7729), new byte[] { 74, 184, 239, 78, 241, 80, 43, 96, 219, 151, 116, 33, 222, 190, 200, 221, 3, 146, 6, 240, 221, 76, 26, 128, 60, 173, 229, 171, 53, 112, 180, 65 }, new byte[] { 35, 246, 10, 86, 34, 92, 123, 80, 90, 108, 138, 186, 57, 115, 36, 217, 141, 190, 154, 58, 38, 163, 178, 21, 169, 157, 195, 207, 161, 210, 50, 253, 229, 27, 3, 115, 21, 92, 246, 90, 208, 31, 7, 6, 112, 132, 187, 126, 137, 160, 49, 205, 172, 165, 72, 14, 45, 119, 221, 162, 126, 235, 148, 191 } });
        }
    }
}
