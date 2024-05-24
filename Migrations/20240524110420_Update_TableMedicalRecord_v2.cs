using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableMedicalRecord_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6224), new DateTime(2024, 5, 24, 11, 4, 19, 992, DateTimeKind.Utc).AddTicks(6236), new byte[] { 144, 62, 240, 18, 145, 8, 137, 115, 13, 163, 12, 152, 38, 157, 75, 233, 23, 209, 99, 162, 237, 96, 13, 56, 5, 135, 125, 8, 149, 142, 195, 124 }, new byte[] { 140, 188, 223, 224, 29, 170, 142, 209, 216, 203, 234, 232, 181, 59, 63, 170, 106, 67, 54, 222, 213, 69, 22, 27, 173, 224, 200, 240, 116, 220, 123, 219, 117, 92, 88, 217, 119, 40, 240, 130, 197, 77, 118, 237, 5, 152, 198, 71, 120, 73, 202, 15, 178, 96, 187, 238, 113, 83, 81, 214, 27, 72, 85, 245 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6194), new DateTime(2024, 5, 24, 11, 4, 19, 992, DateTimeKind.Utc).AddTicks(6208), new byte[] { 144, 62, 240, 18, 145, 8, 137, 115, 13, 163, 12, 152, 38, 157, 75, 233, 23, 209, 99, 162, 237, 96, 13, 56, 5, 135, 125, 8, 149, 142, 195, 124 }, new byte[] { 140, 188, 223, 224, 29, 170, 142, 209, 216, 203, 234, 232, 181, 59, 63, 170, 106, 67, 54, 222, 213, 69, 22, 27, 173, 224, 200, 240, 116, 220, 123, 219, 117, 92, 88, 217, 119, 40, 240, 130, 197, 77, 118, 237, 5, 152, 198, 71, 120, 73, 202, 15, 178, 96, 187, 238, 113, 83, 81, 214, 27, 72, 85, 245 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6104), new DateTime(2024, 5, 24, 11, 4, 19, 992, DateTimeKind.Utc).AddTicks(6191), new byte[] { 144, 62, 240, 18, 145, 8, 137, 115, 13, 163, 12, 152, 38, 157, 75, 233, 23, 209, 99, 162, 237, 96, 13, 56, 5, 135, 125, 8, 149, 142, 195, 124 }, new byte[] { 140, 188, 223, 224, 29, 170, 142, 209, 216, 203, 234, 232, 181, 59, 63, 170, 106, 67, 54, 222, 213, 69, 22, 27, 173, 224, 200, 240, 116, 220, 123, 219, 117, 92, 88, 217, 119, 40, 240, 130, 197, 77, 118, 237, 5, 152, 198, 71, 120, 73, 202, 15, 178, 96, 187, 238, 113, 83, 81, 214, 27, 72, 85, 245 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6237), new DateTime(2024, 5, 24, 11, 4, 19, 992, DateTimeKind.Utc).AddTicks(6250), new byte[] { 144, 62, 240, 18, 145, 8, 137, 115, 13, 163, 12, 152, 38, 157, 75, 233, 23, 209, 99, 162, 237, 96, 13, 56, 5, 135, 125, 8, 149, 142, 195, 124 }, new byte[] { 140, 188, 223, 224, 29, 170, 142, 209, 216, 203, 234, 232, 181, 59, 63, 170, 106, 67, 54, 222, 213, 69, 22, 27, 173, 224, 200, 240, 116, 220, 123, 219, 117, 92, 88, 217, 119, 40, 240, 130, 197, 77, 118, 237, 5, 152, 198, 71, 120, 73, 202, 15, 178, 96, 187, 238, 113, 83, 81, 214, 27, 72, 85, 245 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6210), new DateTime(2024, 5, 24, 11, 4, 19, 992, DateTimeKind.Utc).AddTicks(6222), new byte[] { 144, 62, 240, 18, 145, 8, 137, 115, 13, 163, 12, 152, 38, 157, 75, 233, 23, 209, 99, 162, 237, 96, 13, 56, 5, 135, 125, 8, 149, 142, 195, 124 }, new byte[] { 140, 188, 223, 224, 29, 170, 142, 209, 216, 203, 234, 232, 181, 59, 63, 170, 106, 67, 54, 222, 213, 69, 22, 27, 173, 224, 200, 240, 116, 220, 123, 219, 117, 92, 88, 217, 119, 40, 240, 130, 197, 77, 118, 237, 5, 152, 198, 71, 120, 73, 202, 15, 178, 96, 187, 238, 113, 83, 81, 214, 27, 72, 85, 245 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6324), new DateTime(2024, 5, 24, 11, 4, 19, 992, DateTimeKind.Utc).AddTicks(6336), new byte[] { 144, 62, 240, 18, 145, 8, 137, 115, 13, 163, 12, 152, 38, 157, 75, 233, 23, 209, 99, 162, 237, 96, 13, 56, 5, 135, 125, 8, 149, 142, 195, 124 }, new byte[] { 140, 188, 223, 224, 29, 170, 142, 209, 216, 203, 234, 232, 181, 59, 63, 170, 106, 67, 54, 222, 213, 69, 22, 27, 173, 224, 200, 240, 116, 220, 123, 219, 117, 92, 88, 217, 119, 40, 240, 130, 197, 77, 118, 237, 5, 152, 198, 71, 120, 73, 202, 15, 178, 96, 187, 238, 113, 83, 81, 214, 27, 72, 85, 245 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6307), new DateTime(2024, 5, 24, 11, 4, 19, 992, DateTimeKind.Utc).AddTicks(6322), new byte[] { 144, 62, 240, 18, 145, 8, 137, 115, 13, 163, 12, 152, 38, 157, 75, 233, 23, 209, 99, 162, 237, 96, 13, 56, 5, 135, 125, 8, 149, 142, 195, 124 }, new byte[] { 140, 188, 223, 224, 29, 170, 142, 209, 216, 203, 234, 232, 181, 59, 63, 170, 106, 67, 54, 222, 213, 69, 22, 27, 173, 224, 200, 240, 116, 220, 123, 219, 117, 92, 88, 217, 119, 40, 240, 130, 197, 77, 118, 237, 5, 152, 198, 71, 120, 73, 202, 15, 178, 96, 187, 238, 113, 83, 81, 214, 27, 72, 85, 245 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 4, 19, 992, DateTimeKind.Local).AddTicks(6490));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
