using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableDoctor_v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WorkingTimeStart",
                table: "Doctors",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "WorkingTimeEnd",
                table: "Doctors",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "DurationPerAppointment",
                table: "Doctors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "StatusVerified",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "StatusVerified",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "StatusVerified",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "StatusVerified",
                value: 1);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 39, 9, 911, DateTimeKind.Utc).AddTicks(2018), new byte[] { 173, 100, 230, 133, 173, 38, 166, 207, 101, 20, 144, 222, 80, 37, 166, 240, 216, 99, 145, 60, 15, 175, 240, 160, 204, 154, 248, 87, 21, 251, 142, 195 }, new byte[] { 225, 51, 191, 189, 136, 65, 95, 4, 15, 231, 75, 137, 246, 219, 225, 249, 222, 205, 228, 20, 116, 37, 186, 55, 154, 243, 25, 90, 100, 81, 206, 128, 15, 8, 246, 104, 136, 184, 219, 31, 107, 196, 167, 201, 46, 198, 35, 12, 182, 190, 223, 148, 111, 45, 109, 11, 57, 244, 250, 158, 101, 101, 138, 84 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 39, 9, 911, DateTimeKind.Utc).AddTicks(1991), new byte[] { 173, 100, 230, 133, 173, 38, 166, 207, 101, 20, 144, 222, 80, 37, 166, 240, 216, 99, 145, 60, 15, 175, 240, 160, 204, 154, 248, 87, 21, 251, 142, 195 }, new byte[] { 225, 51, 191, 189, 136, 65, 95, 4, 15, 231, 75, 137, 246, 219, 225, 249, 222, 205, 228, 20, 116, 37, 186, 55, 154, 243, 25, 90, 100, 81, 206, 128, 15, 8, 246, 104, 136, 184, 219, 31, 107, 196, 167, 201, 46, 198, 35, 12, 182, 190, 223, 148, 111, 45, 109, 11, 57, 244, 250, 158, 101, 101, 138, 84 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 39, 9, 911, DateTimeKind.Utc).AddTicks(1971), new byte[] { 173, 100, 230, 133, 173, 38, 166, 207, 101, 20, 144, 222, 80, 37, 166, 240, 216, 99, 145, 60, 15, 175, 240, 160, 204, 154, 248, 87, 21, 251, 142, 195 }, new byte[] { 225, 51, 191, 189, 136, 65, 95, 4, 15, 231, 75, 137, 246, 219, 225, 249, 222, 205, 228, 20, 116, 37, 186, 55, 154, 243, 25, 90, 100, 81, 206, 128, 15, 8, 246, 104, 136, 184, 219, 31, 107, 196, 167, 201, 46, 198, 35, 12, 182, 190, 223, 148, 111, 45, 109, 11, 57, 244, 250, 158, 101, 101, 138, 84 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 39, 9, 911, DateTimeKind.Utc).AddTicks(2031), new byte[] { 173, 100, 230, 133, 173, 38, 166, 207, 101, 20, 144, 222, 80, 37, 166, 240, 216, 99, 145, 60, 15, 175, 240, 160, 204, 154, 248, 87, 21, 251, 142, 195 }, new byte[] { 225, 51, 191, 189, 136, 65, 95, 4, 15, 231, 75, 137, 246, 219, 225, 249, 222, 205, 228, 20, 116, 37, 186, 55, 154, 243, 25, 90, 100, 81, 206, 128, 15, 8, 246, 104, 136, 184, 219, 31, 107, 196, 167, 201, 46, 198, 35, 12, 182, 190, 223, 148, 111, 45, 109, 11, 57, 244, 250, 158, 101, 101, 138, 84 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 39, 9, 911, DateTimeKind.Utc).AddTicks(2004), new byte[] { 173, 100, 230, 133, 173, 38, 166, 207, 101, 20, 144, 222, 80, 37, 166, 240, 216, 99, 145, 60, 15, 175, 240, 160, 204, 154, 248, 87, 21, 251, 142, 195 }, new byte[] { 225, 51, 191, 189, 136, 65, 95, 4, 15, 231, 75, 137, 246, 219, 225, 249, 222, 205, 228, 20, 116, 37, 186, 55, 154, 243, 25, 90, 100, 81, 206, 128, 15, 8, 246, 104, 136, 184, 219, 31, 107, 196, 167, 201, 46, 198, 35, 12, 182, 190, 223, 148, 111, 45, 109, 11, 57, 244, 250, 158, 101, 101, 138, 84 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 39, 9, 911, DateTimeKind.Utc).AddTicks(2043), new byte[] { 173, 100, 230, 133, 173, 38, 166, 207, 101, 20, 144, 222, 80, 37, 166, 240, 216, 99, 145, 60, 15, 175, 240, 160, 204, 154, 248, 87, 21, 251, 142, 195 }, new byte[] { 225, 51, 191, 189, 136, 65, 95, 4, 15, 231, 75, 137, 246, 219, 225, 249, 222, 205, 228, 20, 116, 37, 186, 55, 154, 243, 25, 90, 100, 81, 206, 128, 15, 8, 246, 104, 136, 184, 219, 31, 107, 196, 167, 201, 46, 198, 35, 12, 182, 190, 223, 148, 111, 45, 109, 11, 57, 244, 250, 158, 101, 101, 138, 84 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusVerified",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "WorkingTimeStart",
                keyValue: null,
                column: "WorkingTimeStart",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "WorkingTimeStart",
                table: "Doctors",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "WorkingTimeEnd",
                keyValue: null,
                column: "WorkingTimeEnd",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "WorkingTimeEnd",
                table: "Doctors",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "DurationPerAppointment",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
