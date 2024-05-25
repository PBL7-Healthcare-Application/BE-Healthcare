using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableDoctor_v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumberOfComment",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9498), new DateTime(2024, 5, 25, 8, 51, 15, 868, DateTimeKind.Utc).AddTicks(9512), new byte[] { 214, 4, 62, 59, 113, 247, 25, 14, 155, 207, 244, 149, 202, 125, 200, 59, 95, 219, 107, 196, 215, 221, 246, 163, 253, 52, 158, 229, 12, 41, 158, 76 }, new byte[] { 142, 39, 147, 10, 83, 63, 70, 181, 251, 61, 152, 4, 238, 124, 167, 162, 244, 60, 183, 209, 55, 143, 54, 162, 58, 183, 200, 220, 50, 205, 167, 155, 203, 151, 205, 88, 65, 124, 16, 39, 220, 167, 113, 70, 125, 160, 164, 157, 92, 225, 135, 25, 218, 51, 9, 252, 175, 0, 175, 30, 124, 62, 141, 100 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9466), new DateTime(2024, 5, 25, 8, 51, 15, 868, DateTimeKind.Utc).AddTicks(9482), new byte[] { 214, 4, 62, 59, 113, 247, 25, 14, 155, 207, 244, 149, 202, 125, 200, 59, 95, 219, 107, 196, 215, 221, 246, 163, 253, 52, 158, 229, 12, 41, 158, 76 }, new byte[] { 142, 39, 147, 10, 83, 63, 70, 181, 251, 61, 152, 4, 238, 124, 167, 162, 244, 60, 183, 209, 55, 143, 54, 162, 58, 183, 200, 220, 50, 205, 167, 155, 203, 151, 205, 88, 65, 124, 16, 39, 220, 167, 113, 70, 125, 160, 164, 157, 92, 225, 135, 25, 218, 51, 9, 252, 175, 0, 175, 30, 124, 62, 141, 100 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9358), new DateTime(2024, 5, 25, 8, 51, 15, 868, DateTimeKind.Utc).AddTicks(9463), new byte[] { 214, 4, 62, 59, 113, 247, 25, 14, 155, 207, 244, 149, 202, 125, 200, 59, 95, 219, 107, 196, 215, 221, 246, 163, 253, 52, 158, 229, 12, 41, 158, 76 }, new byte[] { 142, 39, 147, 10, 83, 63, 70, 181, 251, 61, 152, 4, 238, 124, 167, 162, 244, 60, 183, 209, 55, 143, 54, 162, 58, 183, 200, 220, 50, 205, 167, 155, 203, 151, 205, 88, 65, 124, 16, 39, 220, 167, 113, 70, 125, 160, 164, 157, 92, 225, 135, 25, 218, 51, 9, 252, 175, 0, 175, 30, 124, 62, 141, 100 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9513), new DateTime(2024, 5, 25, 8, 51, 15, 868, DateTimeKind.Utc).AddTicks(9526), new byte[] { 214, 4, 62, 59, 113, 247, 25, 14, 155, 207, 244, 149, 202, 125, 200, 59, 95, 219, 107, 196, 215, 221, 246, 163, 253, 52, 158, 229, 12, 41, 158, 76 }, new byte[] { 142, 39, 147, 10, 83, 63, 70, 181, 251, 61, 152, 4, 238, 124, 167, 162, 244, 60, 183, 209, 55, 143, 54, 162, 58, 183, 200, 220, 50, 205, 167, 155, 203, 151, 205, 88, 65, 124, 16, 39, 220, 167, 113, 70, 125, 160, 164, 157, 92, 225, 135, 25, 218, 51, 9, 252, 175, 0, 175, 30, 124, 62, 141, 100 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 25, 8, 51, 15, 868, DateTimeKind.Utc).AddTicks(9497), new byte[] { 214, 4, 62, 59, 113, 247, 25, 14, 155, 207, 244, 149, 202, 125, 200, 59, 95, 219, 107, 196, 215, 221, 246, 163, 253, 52, 158, 229, 12, 41, 158, 76 }, new byte[] { 142, 39, 147, 10, 83, 63, 70, 181, 251, 61, 152, 4, 238, 124, 167, 162, 244, 60, 183, 209, 55, 143, 54, 162, 58, 183, 200, 220, 50, 205, 167, 155, 203, 151, 205, 88, 65, 124, 16, 39, 220, 167, 113, 70, 125, 160, 164, 157, 92, 225, 135, 25, 218, 51, 9, 252, 175, 0, 175, 30, 124, 62, 141, 100 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9541), new DateTime(2024, 5, 25, 8, 51, 15, 868, DateTimeKind.Utc).AddTicks(9554), new byte[] { 214, 4, 62, 59, 113, 247, 25, 14, 155, 207, 244, 149, 202, 125, 200, 59, 95, 219, 107, 196, 215, 221, 246, 163, 253, 52, 158, 229, 12, 41, 158, 76 }, new byte[] { 142, 39, 147, 10, 83, 63, 70, 181, 251, 61, 152, 4, 238, 124, 167, 162, 244, 60, 183, 209, 55, 143, 54, 162, 58, 183, 200, 220, 50, 205, 167, 155, 203, 151, 205, 88, 65, 124, 16, 39, 220, 167, 113, 70, 125, 160, 164, 157, 92, 225, 135, 25, 218, 51, 9, 252, 175, 0, 175, 30, 124, 62, 141, 100 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9527), new DateTime(2024, 5, 25, 8, 51, 15, 868, DateTimeKind.Utc).AddTicks(9540), new byte[] { 214, 4, 62, 59, 113, 247, 25, 14, 155, 207, 244, 149, 202, 125, 200, 59, 95, 219, 107, 196, 215, 221, 246, 163, 253, 52, 158, 229, 12, 41, 158, 76 }, new byte[] { 142, 39, 147, 10, 83, 63, 70, 181, 251, 61, 152, 4, 238, 124, 167, 162, 244, 60, 183, 209, 55, 143, 54, 162, 58, 183, 200, 220, 50, 205, 167, 155, 203, 151, 205, 88, 65, 124, 16, 39, 220, 167, 113, 70, 125, 160, 164, 157, 92, 225, 135, 25, 218, 51, 9, 252, 175, 0, 175, 30, 124, 62, 141, 100 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 51, 15, 868, DateTimeKind.Local).AddTicks(9733));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumberOfComment",
                table: "Doctors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2964), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(2976), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2935), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(2950), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2844), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(2932), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3023), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(3037), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2951), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(2963), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3051), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(3063), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(3050), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3219));
        }
    }
}
