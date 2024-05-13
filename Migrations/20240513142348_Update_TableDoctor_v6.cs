using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableDoctor_v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Doctors",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "BusinessLicense",
                table: "Doctors",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "BusinessLicense",
                value: null);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "BusinessLicense",
                value: null);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "BusinessLicense",
                value: null);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessLicense",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Description",
                keyValue: null,
                column: "Description",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Doctors",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
    }
}
