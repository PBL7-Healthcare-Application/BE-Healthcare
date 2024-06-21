using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_DB_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusVerified",
                table: "WorkingProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusVerified",
                table: "TrainingProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusVerified",
                table: "Certificates",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "StatusVerified",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "StatusVerified",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "StatusVerified",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "StatusVerified",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "StatusVerified",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "StatusVerified",
                value: 1);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 10, 38, 32, 118, DateTimeKind.Utc).AddTicks(3726), new byte[] { 186, 123, 86, 24, 109, 1, 35, 147, 194, 0, 56, 236, 57, 227, 250, 119, 225, 244, 24, 220, 176, 229, 5, 64, 23, 223, 143, 220, 186, 203, 27, 28 }, new byte[] { 163, 143, 241, 88, 64, 215, 163, 138, 156, 77, 185, 145, 81, 170, 93, 120, 74, 150, 180, 112, 143, 182, 146, 40, 179, 176, 38, 136, 53, 93, 143, 222, 191, 123, 114, 159, 82, 164, 48, 141, 192, 93, 36, 34, 129, 152, 24, 78, 60, 219, 243, 60, 144, 132, 181, 185, 125, 125, 118, 137, 33, 112, 155, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 10, 38, 32, 118, DateTimeKind.Utc).AddTicks(3699), new byte[] { 186, 123, 86, 24, 109, 1, 35, 147, 194, 0, 56, 236, 57, 227, 250, 119, 225, 244, 24, 220, 176, 229, 5, 64, 23, 223, 143, 220, 186, 203, 27, 28 }, new byte[] { 163, 143, 241, 88, 64, 215, 163, 138, 156, 77, 185, 145, 81, 170, 93, 120, 74, 150, 180, 112, 143, 182, 146, 40, 179, 176, 38, 136, 53, 93, 143, 222, 191, 123, 114, 159, 82, 164, 48, 141, 192, 93, 36, 34, 129, 152, 24, 78, 60, 219, 243, 60, 144, 132, 181, 185, 125, 125, 118, 137, 33, 112, 155, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 10, 38, 32, 118, DateTimeKind.Utc).AddTicks(3681), new byte[] { 186, 123, 86, 24, 109, 1, 35, 147, 194, 0, 56, 236, 57, 227, 250, 119, 225, 244, 24, 220, 176, 229, 5, 64, 23, 223, 143, 220, 186, 203, 27, 28 }, new byte[] { 163, 143, 241, 88, 64, 215, 163, 138, 156, 77, 185, 145, 81, 170, 93, 120, 74, 150, 180, 112, 143, 182, 146, 40, 179, 176, 38, 136, 53, 93, 143, 222, 191, 123, 114, 159, 82, 164, 48, 141, 192, 93, 36, 34, 129, 152, 24, 78, 60, 219, 243, 60, 144, 132, 181, 185, 125, 125, 118, 137, 33, 112, 155, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 10, 38, 32, 118, DateTimeKind.Utc).AddTicks(3737), new byte[] { 186, 123, 86, 24, 109, 1, 35, 147, 194, 0, 56, 236, 57, 227, 250, 119, 225, 244, 24, 220, 176, 229, 5, 64, 23, 223, 143, 220, 186, 203, 27, 28 }, new byte[] { 163, 143, 241, 88, 64, 215, 163, 138, 156, 77, 185, 145, 81, 170, 93, 120, 74, 150, 180, 112, 143, 182, 146, 40, 179, 176, 38, 136, 53, 93, 143, 222, 191, 123, 114, 159, 82, 164, 48, 141, 192, 93, 36, 34, 129, 152, 24, 78, 60, 219, 243, 60, 144, 132, 181, 185, 125, 125, 118, 137, 33, 112, 155, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 10, 38, 32, 118, DateTimeKind.Utc).AddTicks(3712), new byte[] { 186, 123, 86, 24, 109, 1, 35, 147, 194, 0, 56, 236, 57, 227, 250, 119, 225, 244, 24, 220, 176, 229, 5, 64, 23, 223, 143, 220, 186, 203, 27, 28 }, new byte[] { 163, 143, 241, 88, 64, 215, 163, 138, 156, 77, 185, 145, 81, 170, 93, 120, 74, 150, 180, 112, 143, 182, 146, 40, 179, 176, 38, 136, 53, 93, 143, 222, 191, 123, 114, 159, 82, 164, 48, 141, 192, 93, 36, 34, 129, 152, 24, 78, 60, 219, 243, 60, 144, 132, 181, 185, 125, 125, 118, 137, 33, 112, 155, 40 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 10, 38, 32, 118, DateTimeKind.Utc).AddTicks(3748), new byte[] { 186, 123, 86, 24, 109, 1, 35, 147, 194, 0, 56, 236, 57, 227, 250, 119, 225, 244, 24, 220, 176, 229, 5, 64, 23, 223, 143, 220, 186, 203, 27, 28 }, new byte[] { 163, 143, 241, 88, 64, 215, 163, 138, 156, 77, 185, 145, 81, 170, 93, 120, 74, 150, 180, 112, 143, 182, 146, 40, 179, 176, 38, 136, 53, 93, 143, 222, 191, 123, 114, 159, 82, 164, 48, 141, 192, 93, 36, 34, 129, 152, 24, 78, 60, 219, 243, 60, 144, 132, 181, 185, 125, 125, 118, 137, 33, 112, 155, 40 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "StatusVerified",
                value: 1);

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "StatusVerified",
                value: 1);

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "StatusVerified",
                value: 1);

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "StatusVerified",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusVerified",
                table: "WorkingProcesses");

            migrationBuilder.DropColumn(
                name: "StatusVerified",
                table: "TrainingProcesses");

            migrationBuilder.DropColumn(
                name: "StatusVerified",
                table: "Certificates");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 8, 16, 51, 623, DateTimeKind.Utc).AddTicks(380), new byte[] { 85, 238, 143, 4, 49, 172, 180, 98, 111, 57, 5, 218, 198, 95, 202, 16, 58, 212, 42, 208, 67, 208, 176, 92, 125, 69, 99, 174, 142, 215, 58, 80 }, new byte[] { 245, 126, 211, 17, 216, 9, 108, 46, 188, 181, 58, 206, 28, 118, 242, 46, 102, 27, 114, 95, 254, 15, 42, 38, 90, 90, 252, 52, 157, 196, 219, 90, 205, 251, 78, 204, 127, 182, 119, 219, 85, 162, 8, 199, 18, 92, 246, 222, 174, 154, 89, 57, 100, 46, 111, 44, 16, 191, 46, 58, 243, 162, 243, 139 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 8, 16, 51, 623, DateTimeKind.Utc).AddTicks(354), new byte[] { 85, 238, 143, 4, 49, 172, 180, 98, 111, 57, 5, 218, 198, 95, 202, 16, 58, 212, 42, 208, 67, 208, 176, 92, 125, 69, 99, 174, 142, 215, 58, 80 }, new byte[] { 245, 126, 211, 17, 216, 9, 108, 46, 188, 181, 58, 206, 28, 118, 242, 46, 102, 27, 114, 95, 254, 15, 42, 38, 90, 90, 252, 52, 157, 196, 219, 90, 205, 251, 78, 204, 127, 182, 119, 219, 85, 162, 8, 199, 18, 92, 246, 222, 174, 154, 89, 57, 100, 46, 111, 44, 16, 191, 46, 58, 243, 162, 243, 139 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 8, 16, 51, 623, DateTimeKind.Utc).AddTicks(335), new byte[] { 85, 238, 143, 4, 49, 172, 180, 98, 111, 57, 5, 218, 198, 95, 202, 16, 58, 212, 42, 208, 67, 208, 176, 92, 125, 69, 99, 174, 142, 215, 58, 80 }, new byte[] { 245, 126, 211, 17, 216, 9, 108, 46, 188, 181, 58, 206, 28, 118, 242, 46, 102, 27, 114, 95, 254, 15, 42, 38, 90, 90, 252, 52, 157, 196, 219, 90, 205, 251, 78, 204, 127, 182, 119, 219, 85, 162, 8, 199, 18, 92, 246, 222, 174, 154, 89, 57, 100, 46, 111, 44, 16, 191, 46, 58, 243, 162, 243, 139 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 8, 16, 51, 623, DateTimeKind.Utc).AddTicks(392), new byte[] { 85, 238, 143, 4, 49, 172, 180, 98, 111, 57, 5, 218, 198, 95, 202, 16, 58, 212, 42, 208, 67, 208, 176, 92, 125, 69, 99, 174, 142, 215, 58, 80 }, new byte[] { 245, 126, 211, 17, 216, 9, 108, 46, 188, 181, 58, 206, 28, 118, 242, 46, 102, 27, 114, 95, 254, 15, 42, 38, 90, 90, 252, 52, 157, 196, 219, 90, 205, 251, 78, 204, 127, 182, 119, 219, 85, 162, 8, 199, 18, 92, 246, 222, 174, 154, 89, 57, 100, 46, 111, 44, 16, 191, 46, 58, 243, 162, 243, 139 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 8, 16, 51, 623, DateTimeKind.Utc).AddTicks(367), new byte[] { 85, 238, 143, 4, 49, 172, 180, 98, 111, 57, 5, 218, 198, 95, 202, 16, 58, 212, 42, 208, 67, 208, 176, 92, 125, 69, 99, 174, 142, 215, 58, 80 }, new byte[] { 245, 126, 211, 17, 216, 9, 108, 46, 188, 181, 58, 206, 28, 118, 242, 46, 102, 27, 114, 95, 254, 15, 42, 38, 90, 90, 252, 52, 157, 196, 219, 90, 205, 251, 78, 204, 127, 182, 119, 219, 85, 162, 8, 199, 18, 92, 246, 222, 174, 154, 89, 57, 100, 46, 111, 44, 16, 191, 46, 58, 243, 162, 243, 139 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 4, 8, 16, 51, 623, DateTimeKind.Utc).AddTicks(404), new byte[] { 85, 238, 143, 4, 49, 172, 180, 98, 111, 57, 5, 218, 198, 95, 202, 16, 58, 212, 42, 208, 67, 208, 176, 92, 125, 69, 99, 174, 142, 215, 58, 80 }, new byte[] { 245, 126, 211, 17, 216, 9, 108, 46, 188, 181, 58, 206, 28, 118, 242, 46, 102, 27, 114, 95, 254, 15, 42, 38, 90, 90, 252, 52, 157, 196, 219, 90, 205, 251, 78, 204, 127, 182, 119, 219, 85, 162, 8, 199, 18, 92, 246, 222, 174, 154, 89, 57, 100, 46, 111, 44, 16, 191, 46, 58, 243, 162, 243, 139 } });
        }
    }
}
