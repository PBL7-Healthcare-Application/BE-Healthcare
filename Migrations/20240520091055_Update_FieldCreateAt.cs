using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_FieldCreateAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkingProcesses",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "User",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingProcesses",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "TimeOffs",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "RefreshToken",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "MedicalSpecialties",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Doctors",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Certificates",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Appointments",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5688), new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5701), new byte[] { 191, 42, 79, 209, 83, 254, 54, 74, 116, 63, 123, 69, 91, 47, 77, 174, 219, 137, 2, 247, 72, 85, 55, 44, 227, 231, 56, 72, 60, 102, 239, 99 }, new byte[] { 44, 199, 213, 23, 134, 10, 19, 240, 37, 30, 71, 87, 134, 189, 226, 63, 236, 236, 99, 28, 77, 148, 176, 3, 199, 58, 93, 10, 227, 59, 22, 203, 74, 154, 240, 18, 254, 171, 36, 240, 98, 235, 99, 96, 78, 43, 135, 57, 127, 38, 124, 228, 196, 94, 48, 68, 101, 209, 116, 242, 75, 192, 178, 206 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5621), new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5637), new byte[] { 191, 42, 79, 209, 83, 254, 54, 74, 116, 63, 123, 69, 91, 47, 77, 174, 219, 137, 2, 247, 72, 85, 55, 44, 227, 231, 56, 72, 60, 102, 239, 99 }, new byte[] { 44, 199, 213, 23, 134, 10, 19, 240, 37, 30, 71, 87, 134, 189, 226, 63, 236, 236, 99, 28, 77, 148, 176, 3, 199, 58, 93, 10, 227, 59, 22, 203, 74, 154, 240, 18, 254, 171, 36, 240, 98, 235, 99, 96, 78, 43, 135, 57, 127, 38, 124, 228, 196, 94, 48, 68, 101, 209, 116, 242, 75, 192, 178, 206 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5501), new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5619), new byte[] { 191, 42, 79, 209, 83, 254, 54, 74, 116, 63, 123, 69, 91, 47, 77, 174, 219, 137, 2, 247, 72, 85, 55, 44, 227, 231, 56, 72, 60, 102, 239, 99 }, new byte[] { 44, 199, 213, 23, 134, 10, 19, 240, 37, 30, 71, 87, 134, 189, 226, 63, 236, 236, 99, 28, 77, 148, 176, 3, 199, 58, 93, 10, 227, 59, 22, 203, 74, 154, 240, 18, 254, 171, 36, 240, 98, 235, 99, 96, 78, 43, 135, 57, 127, 38, 124, 228, 196, 94, 48, 68, 101, 209, 116, 242, 75, 192, 178, 206 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5702), new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5715), new byte[] { 191, 42, 79, 209, 83, 254, 54, 74, 116, 63, 123, 69, 91, 47, 77, 174, 219, 137, 2, 247, 72, 85, 55, 44, 227, 231, 56, 72, 60, 102, 239, 99 }, new byte[] { 44, 199, 213, 23, 134, 10, 19, 240, 37, 30, 71, 87, 134, 189, 226, 63, 236, 236, 99, 28, 77, 148, 176, 3, 199, 58, 93, 10, 227, 59, 22, 203, 74, 154, 240, 18, 254, 171, 36, 240, 98, 235, 99, 96, 78, 43, 135, 57, 127, 38, 124, 228, 196, 94, 48, 68, 101, 209, 116, 242, 75, 192, 178, 206 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5639), new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5655), new byte[] { 191, 42, 79, 209, 83, 254, 54, 74, 116, 63, 123, 69, 91, 47, 77, 174, 219, 137, 2, 247, 72, 85, 55, 44, 227, 231, 56, 72, 60, 102, 239, 99 }, new byte[] { 44, 199, 213, 23, 134, 10, 19, 240, 37, 30, 71, 87, 134, 189, 226, 63, 236, 236, 99, 28, 77, 148, 176, 3, 199, 58, 93, 10, 227, 59, 22, 203, 74, 154, 240, 18, 254, 171, 36, 240, 98, 235, 99, 96, 78, 43, 135, 57, 127, 38, 124, 228, 196, 94, 48, 68, 101, 209, 116, 242, 75, 192, 178, 206 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5730), new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5742), new byte[] { 191, 42, 79, 209, 83, 254, 54, 74, 116, 63, 123, 69, 91, 47, 77, 174, 219, 137, 2, 247, 72, 85, 55, 44, 227, 231, 56, 72, 60, 102, 239, 99 }, new byte[] { 44, 199, 213, 23, 134, 10, 19, 240, 37, 30, 71, 87, 134, 189, 226, 63, 236, 236, 99, 28, 77, 148, 176, 3, 199, 58, 93, 10, 227, 59, 22, 203, 74, 154, 240, 18, 254, 171, 36, 240, 98, 235, 99, 96, 78, 43, 135, 57, 127, 38, 124, 228, 196, 94, 48, 68, 101, 209, 116, 242, 75, 192, 178, 206 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5716), new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5729), new byte[] { 191, 42, 79, 209, 83, 254, 54, 74, 116, 63, 123, 69, 91, 47, 77, 174, 219, 137, 2, 247, 72, 85, 55, 44, 227, 231, 56, 72, 60, 102, 239, 99 }, new byte[] { 44, 199, 213, 23, 134, 10, 19, 240, 37, 30, 71, 87, 134, 189, 226, 63, 236, 236, 99, 28, 77, 148, 176, 3, 199, 58, 93, 10, 227, 59, 22, 203, 74, 154, 240, 18, 254, 171, 36, 240, 98, 235, 99, 96, 78, 43, 135, 57, 127, 38, 124, 228, 196, 94, 48, 68, 101, 209, 116, 242, 75, 192, 178, 206 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 9, 10, 55, 264, DateTimeKind.Utc).AddTicks(5908));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "WorkingProcesses");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "TrainingProcesses");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "TimeOffs");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "RefreshToken");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "MedicalSpecialties");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8853), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8830), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8814), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8864), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8842), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8885), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 41, 56, 780, DateTimeKind.Utc).AddTicks(8875), new byte[] { 82, 241, 252, 141, 231, 60, 193, 121, 186, 26, 112, 26, 121, 0, 244, 235, 134, 34, 251, 236, 8, 203, 118, 200, 136, 22, 222, 106, 199, 255, 10, 244 }, new byte[] { 75, 153, 193, 64, 64, 117, 42, 36, 168, 46, 68, 30, 107, 50, 31, 167, 226, 183, 4, 78, 9, 47, 197, 89, 179, 111, 244, 33, 38, 71, 9, 245, 153, 96, 8, 54, 66, 157, 83, 26, 120, 129, 241, 226, 112, 114, 161, 63, 25, 33, 209, 187, 197, 143, 220, 231, 13, 97, 35, 172, 171, 86, 178, 175 } });
        }
    }
}
