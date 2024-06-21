using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableMedicalSpecialty_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "MedicalSpecialties",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 55, 15, 648, DateTimeKind.Utc).AddTicks(6750), new byte[] { 14, 79, 154, 146, 159, 69, 53, 200, 107, 235, 163, 217, 130, 240, 27, 149, 216, 131, 30, 248, 225, 153, 119, 108, 136, 172, 122, 29, 196, 132, 207, 168 }, new byte[] { 162, 77, 225, 226, 253, 48, 5, 77, 42, 147, 100, 126, 237, 41, 109, 77, 226, 152, 33, 43, 249, 69, 203, 84, 189, 200, 37, 244, 220, 100, 232, 51, 66, 27, 215, 98, 131, 131, 215, 190, 81, 143, 176, 59, 236, 201, 189, 42, 120, 180, 74, 158, 143, 107, 113, 134, 16, 222, 99, 239, 115, 147, 60, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 55, 15, 648, DateTimeKind.Utc).AddTicks(6673), new byte[] { 14, 79, 154, 146, 159, 69, 53, 200, 107, 235, 163, 217, 130, 240, 27, 149, 216, 131, 30, 248, 225, 153, 119, 108, 136, 172, 122, 29, 196, 132, 207, 168 }, new byte[] { 162, 77, 225, 226, 253, 48, 5, 77, 42, 147, 100, 126, 237, 41, 109, 77, 226, 152, 33, 43, 249, 69, 203, 84, 189, 200, 37, 244, 220, 100, 232, 51, 66, 27, 215, 98, 131, 131, 215, 190, 81, 143, 176, 59, 236, 201, 189, 42, 120, 180, 74, 158, 143, 107, 113, 134, 16, 222, 99, 239, 115, 147, 60, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 55, 15, 648, DateTimeKind.Utc).AddTicks(6655), new byte[] { 14, 79, 154, 146, 159, 69, 53, 200, 107, 235, 163, 217, 130, 240, 27, 149, 216, 131, 30, 248, 225, 153, 119, 108, 136, 172, 122, 29, 196, 132, 207, 168 }, new byte[] { 162, 77, 225, 226, 253, 48, 5, 77, 42, 147, 100, 126, 237, 41, 109, 77, 226, 152, 33, 43, 249, 69, 203, 84, 189, 200, 37, 244, 220, 100, 232, 51, 66, 27, 215, 98, 131, 131, 215, 190, 81, 143, 176, 59, 236, 201, 189, 42, 120, 180, 74, 158, 143, 107, 113, 134, 16, 222, 99, 239, 115, 147, 60, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 55, 15, 648, DateTimeKind.Utc).AddTicks(6763), new byte[] { 14, 79, 154, 146, 159, 69, 53, 200, 107, 235, 163, 217, 130, 240, 27, 149, 216, 131, 30, 248, 225, 153, 119, 108, 136, 172, 122, 29, 196, 132, 207, 168 }, new byte[] { 162, 77, 225, 226, 253, 48, 5, 77, 42, 147, 100, 126, 237, 41, 109, 77, 226, 152, 33, 43, 249, 69, 203, 84, 189, 200, 37, 244, 220, 100, 232, 51, 66, 27, 215, 98, 131, 131, 215, 190, 81, 143, 176, 59, 236, 201, 189, 42, 120, 180, 74, 158, 143, 107, 113, 134, 16, 222, 99, 239, 115, 147, 60, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 55, 15, 648, DateTimeKind.Utc).AddTicks(6736), new byte[] { 14, 79, 154, 146, 159, 69, 53, 200, 107, 235, 163, 217, 130, 240, 27, 149, 216, 131, 30, 248, 225, 153, 119, 108, 136, 172, 122, 29, 196, 132, 207, 168 }, new byte[] { 162, 77, 225, 226, 253, 48, 5, 77, 42, 147, 100, 126, 237, 41, 109, 77, 226, 152, 33, 43, 249, 69, 203, 84, 189, 200, 37, 244, 220, 100, 232, 51, 66, 27, 215, 98, 131, 131, 215, 190, 81, 143, 176, 59, 236, 201, 189, 42, 120, 180, 74, 158, 143, 107, 113, 134, 16, 222, 99, 239, 115, 147, 60, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 55, 15, 648, DateTimeKind.Utc).AddTicks(6776), new byte[] { 14, 79, 154, 146, 159, 69, 53, 200, 107, 235, 163, 217, 130, 240, 27, 149, 216, 131, 30, 248, 225, 153, 119, 108, 136, 172, 122, 29, 196, 132, 207, 168 }, new byte[] { 162, 77, 225, 226, 253, 48, 5, 77, 42, 147, 100, 126, 237, 41, 109, 77, 226, 152, 33, 43, 249, 69, 203, 84, 189, 200, 37, 244, 220, 100, 232, 51, 66, 27, 215, 98, 131, 131, 215, 190, 81, 143, 176, 59, 236, 201, 189, 42, 120, 180, 74, 158, 143, 107, 113, 134, 16, 222, 99, 239, 115, 147, 60, 2 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "MedicalSpecialties");

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
    }
}
