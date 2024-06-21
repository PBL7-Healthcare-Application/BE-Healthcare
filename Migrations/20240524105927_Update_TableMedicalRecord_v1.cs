using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableMedicalRecord_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "MedicalRecords",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2042), new DateTime(2024, 5, 24, 10, 59, 27, 293, DateTimeKind.Utc).AddTicks(2054), new byte[] { 66, 28, 157, 115, 239, 237, 172, 87, 235, 67, 125, 190, 163, 196, 138, 85, 114, 63, 235, 83, 55, 183, 234, 212, 11, 152, 37, 163, 160, 254, 49, 54 }, new byte[] { 44, 209, 229, 106, 185, 78, 132, 21, 159, 247, 206, 153, 221, 81, 234, 176, 44, 187, 83, 14, 125, 157, 156, 49, 49, 15, 4, 76, 241, 69, 13, 238, 183, 197, 238, 252, 253, 35, 123, 28, 132, 65, 105, 145, 20, 75, 226, 188, 2, 227, 65, 149, 235, 176, 229, 139, 137, 31, 37, 148, 88, 118, 37, 161 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2012), new DateTime(2024, 5, 24, 10, 59, 27, 293, DateTimeKind.Utc).AddTicks(2026), new byte[] { 66, 28, 157, 115, 239, 237, 172, 87, 235, 67, 125, 190, 163, 196, 138, 85, 114, 63, 235, 83, 55, 183, 234, 212, 11, 152, 37, 163, 160, 254, 49, 54 }, new byte[] { 44, 209, 229, 106, 185, 78, 132, 21, 159, 247, 206, 153, 221, 81, 234, 176, 44, 187, 83, 14, 125, 157, 156, 49, 49, 15, 4, 76, 241, 69, 13, 238, 183, 197, 238, 252, 253, 35, 123, 28, 132, 65, 105, 145, 20, 75, 226, 188, 2, 227, 65, 149, 235, 176, 229, 139, 137, 31, 37, 148, 88, 118, 37, 161 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(1916), new DateTime(2024, 5, 24, 10, 59, 27, 293, DateTimeKind.Utc).AddTicks(2009), new byte[] { 66, 28, 157, 115, 239, 237, 172, 87, 235, 67, 125, 190, 163, 196, 138, 85, 114, 63, 235, 83, 55, 183, 234, 212, 11, 152, 37, 163, 160, 254, 49, 54 }, new byte[] { 44, 209, 229, 106, 185, 78, 132, 21, 159, 247, 206, 153, 221, 81, 234, 176, 44, 187, 83, 14, 125, 157, 156, 49, 49, 15, 4, 76, 241, 69, 13, 238, 183, 197, 238, 252, 253, 35, 123, 28, 132, 65, 105, 145, 20, 75, 226, 188, 2, 227, 65, 149, 235, 176, 229, 139, 137, 31, 37, 148, 88, 118, 37, 161 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2055), new DateTime(2024, 5, 24, 10, 59, 27, 293, DateTimeKind.Utc).AddTicks(2068), new byte[] { 66, 28, 157, 115, 239, 237, 172, 87, 235, 67, 125, 190, 163, 196, 138, 85, 114, 63, 235, 83, 55, 183, 234, 212, 11, 152, 37, 163, 160, 254, 49, 54 }, new byte[] { 44, 209, 229, 106, 185, 78, 132, 21, 159, 247, 206, 153, 221, 81, 234, 176, 44, 187, 83, 14, 125, 157, 156, 49, 49, 15, 4, 76, 241, 69, 13, 238, 183, 197, 238, 252, 253, 35, 123, 28, 132, 65, 105, 145, 20, 75, 226, 188, 2, 227, 65, 149, 235, 176, 229, 139, 137, 31, 37, 148, 88, 118, 37, 161 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2028), new DateTime(2024, 5, 24, 10, 59, 27, 293, DateTimeKind.Utc).AddTicks(2040), new byte[] { 66, 28, 157, 115, 239, 237, 172, 87, 235, 67, 125, 190, 163, 196, 138, 85, 114, 63, 235, 83, 55, 183, 234, 212, 11, 152, 37, 163, 160, 254, 49, 54 }, new byte[] { 44, 209, 229, 106, 185, 78, 132, 21, 159, 247, 206, 153, 221, 81, 234, 176, 44, 187, 83, 14, 125, 157, 156, 49, 49, 15, 4, 76, 241, 69, 13, 238, 183, 197, 238, 252, 253, 35, 123, 28, 132, 65, 105, 145, 20, 75, 226, 188, 2, 227, 65, 149, 235, 176, 229, 139, 137, 31, 37, 148, 88, 118, 37, 161 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2082), new DateTime(2024, 5, 24, 10, 59, 27, 293, DateTimeKind.Utc).AddTicks(2094), new byte[] { 66, 28, 157, 115, 239, 237, 172, 87, 235, 67, 125, 190, 163, 196, 138, 85, 114, 63, 235, 83, 55, 183, 234, 212, 11, 152, 37, 163, 160, 254, 49, 54 }, new byte[] { 44, 209, 229, 106, 185, 78, 132, 21, 159, 247, 206, 153, 221, 81, 234, 176, 44, 187, 83, 14, 125, 157, 156, 49, 49, 15, 4, 76, 241, 69, 13, 238, 183, 197, 238, 252, 253, 35, 123, 28, 132, 65, 105, 145, 20, 75, 226, 188, 2, 227, 65, 149, 235, 176, 229, 139, 137, 31, 37, 148, 88, 118, 37, 161 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2069), new DateTime(2024, 5, 24, 10, 59, 27, 293, DateTimeKind.Utc).AddTicks(2081), new byte[] { 66, 28, 157, 115, 239, 237, 172, 87, 235, 67, 125, 190, 163, 196, 138, 85, 114, 63, 235, 83, 55, 183, 234, 212, 11, 152, 37, 163, 160, 254, 49, 54 }, new byte[] { 44, 209, 229, 106, 185, 78, 132, 21, 159, 247, 206, 153, 221, 81, 234, 176, 44, 187, 83, 14, 125, 157, 156, 49, 49, 15, 4, 76, 241, 69, 13, 238, 183, 197, 238, 252, 253, 35, 123, 28, 132, 65, 105, 145, 20, 75, 226, 188, 2, 227, 65, 149, 235, 176, 229, 139, 137, 31, 37, 148, 88, 118, 37, 161 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 17, 59, 27, 293, DateTimeKind.Local).AddTicks(2253));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "MedicalRecords");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6001), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(6013), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5971), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(5986), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5862), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(5968), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6014), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(6026), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5987), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(6000), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6042), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(6054), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6027), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(6040), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6263));
        }
    }
}
