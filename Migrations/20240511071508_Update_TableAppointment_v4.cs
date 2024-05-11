using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableAppointment_v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDoctorCancel",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "isUserCancel",
                table: "Appointments");

            migrationBuilder.AddColumn<Guid>(
                name: "idDoctorCancel",
                table: "Appointments",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "idUserCancel",
                table: "Appointments",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                columns: new[] { "idDoctorCancel", "idUserCancel" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                columns: new[] { "idDoctorCancel", "idUserCancel" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                columns: new[] { "idDoctorCancel", "idUserCancel" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                columns: new[] { "idDoctorCancel", "idUserCancel" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                columns: new[] { "idDoctorCancel", "idUserCancel" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 7, 15, 7, 906, DateTimeKind.Utc).AddTicks(3364), new byte[] { 171, 41, 190, 13, 92, 19, 161, 126, 163, 132, 5, 45, 26, 109, 1, 176, 92, 89, 180, 100, 3, 170, 206, 72, 215, 236, 238, 106, 162, 7, 42, 4 }, new byte[] { 22, 36, 86, 150, 197, 60, 86, 177, 190, 89, 86, 20, 214, 239, 163, 213, 164, 157, 12, 219, 109, 106, 217, 249, 63, 198, 153, 200, 244, 72, 15, 217, 228, 252, 100, 206, 236, 82, 60, 161, 177, 129, 154, 159, 10, 176, 210, 139, 132, 109, 13, 200, 57, 79, 106, 226, 179, 5, 149, 105, 115, 43, 49, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 7, 15, 7, 906, DateTimeKind.Utc).AddTicks(3335), new byte[] { 171, 41, 190, 13, 92, 19, 161, 126, 163, 132, 5, 45, 26, 109, 1, 176, 92, 89, 180, 100, 3, 170, 206, 72, 215, 236, 238, 106, 162, 7, 42, 4 }, new byte[] { 22, 36, 86, 150, 197, 60, 86, 177, 190, 89, 86, 20, 214, 239, 163, 213, 164, 157, 12, 219, 109, 106, 217, 249, 63, 198, 153, 200, 244, 72, 15, 217, 228, 252, 100, 206, 236, 82, 60, 161, 177, 129, 154, 159, 10, 176, 210, 139, 132, 109, 13, 200, 57, 79, 106, 226, 179, 5, 149, 105, 115, 43, 49, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 7, 15, 7, 906, DateTimeKind.Utc).AddTicks(3317), new byte[] { 171, 41, 190, 13, 92, 19, 161, 126, 163, 132, 5, 45, 26, 109, 1, 176, 92, 89, 180, 100, 3, 170, 206, 72, 215, 236, 238, 106, 162, 7, 42, 4 }, new byte[] { 22, 36, 86, 150, 197, 60, 86, 177, 190, 89, 86, 20, 214, 239, 163, 213, 164, 157, 12, 219, 109, 106, 217, 249, 63, 198, 153, 200, 244, 72, 15, 217, 228, 252, 100, 206, 236, 82, 60, 161, 177, 129, 154, 159, 10, 176, 210, 139, 132, 109, 13, 200, 57, 79, 106, 226, 179, 5, 149, 105, 115, 43, 49, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 7, 15, 7, 906, DateTimeKind.Utc).AddTicks(3376), new byte[] { 171, 41, 190, 13, 92, 19, 161, 126, 163, 132, 5, 45, 26, 109, 1, 176, 92, 89, 180, 100, 3, 170, 206, 72, 215, 236, 238, 106, 162, 7, 42, 4 }, new byte[] { 22, 36, 86, 150, 197, 60, 86, 177, 190, 89, 86, 20, 214, 239, 163, 213, 164, 157, 12, 219, 109, 106, 217, 249, 63, 198, 153, 200, 244, 72, 15, 217, 228, 252, 100, 206, 236, 82, 60, 161, 177, 129, 154, 159, 10, 176, 210, 139, 132, 109, 13, 200, 57, 79, 106, 226, 179, 5, 149, 105, 115, 43, 49, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 7, 15, 7, 906, DateTimeKind.Utc).AddTicks(3349), new byte[] { 171, 41, 190, 13, 92, 19, 161, 126, 163, 132, 5, 45, 26, 109, 1, 176, 92, 89, 180, 100, 3, 170, 206, 72, 215, 236, 238, 106, 162, 7, 42, 4 }, new byte[] { 22, 36, 86, 150, 197, 60, 86, 177, 190, 89, 86, 20, 214, 239, 163, 213, 164, 157, 12, 219, 109, 106, 217, 249, 63, 198, 153, 200, 244, 72, 15, 217, 228, 252, 100, 206, 236, 82, 60, 161, 177, 129, 154, 159, 10, 176, 210, 139, 132, 109, 13, 200, 57, 79, 106, 226, 179, 5, 149, 105, 115, 43, 49, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 11, 7, 15, 7, 906, DateTimeKind.Utc).AddTicks(3388), new byte[] { 171, 41, 190, 13, 92, 19, 161, 126, 163, 132, 5, 45, 26, 109, 1, 176, 92, 89, 180, 100, 3, 170, 206, 72, 215, 236, 238, 106, 162, 7, 42, 4 }, new byte[] { 22, 36, 86, 150, 197, 60, 86, 177, 190, 89, 86, 20, 214, 239, 163, 213, 164, 157, 12, 219, 109, 106, 217, 249, 63, 198, 153, 200, 244, 72, 15, 217, 228, 252, 100, 206, 236, 82, 60, 161, 177, 129, 154, 159, 10, 176, 210, 139, 132, 109, 13, 200, 57, 79, 106, 226, 179, 5, 149, 105, 115, 43, 49, 40 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idDoctorCancel",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "idUserCancel",
                table: "Appointments");

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
    }
}
