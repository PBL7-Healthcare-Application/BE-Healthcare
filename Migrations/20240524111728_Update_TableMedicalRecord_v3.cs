using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableMedicalRecord_v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_Appointments_AppointmentIdAppointment",
                table: "MedicalRecords");

            migrationBuilder.DropIndex(
                name: "IX_MedicalRecords_AppointmentIdAppointment",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "AppointmentIdAppointment",
                table: "MedicalRecords");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9050), new DateTime(2024, 5, 24, 11, 17, 27, 748, DateTimeKind.Utc).AddTicks(9064), new byte[] { 246, 237, 154, 68, 11, 56, 188, 200, 201, 153, 94, 19, 226, 190, 112, 143, 5, 216, 235, 109, 59, 37, 161, 98, 76, 20, 44, 151, 52, 255, 131, 241 }, new byte[] { 100, 183, 250, 237, 232, 218, 172, 63, 57, 60, 151, 220, 14, 246, 94, 107, 213, 178, 131, 184, 51, 254, 173, 7, 87, 76, 56, 88, 46, 205, 29, 141, 55, 84, 247, 143, 119, 181, 251, 23, 174, 154, 170, 201, 169, 112, 227, 19, 84, 103, 193, 137, 221, 80, 192, 251, 64, 55, 238, 128, 139, 163, 235, 76 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9016), new DateTime(2024, 5, 24, 11, 17, 27, 748, DateTimeKind.Utc).AddTicks(9033), new byte[] { 246, 237, 154, 68, 11, 56, 188, 200, 201, 153, 94, 19, 226, 190, 112, 143, 5, 216, 235, 109, 59, 37, 161, 98, 76, 20, 44, 151, 52, 255, 131, 241 }, new byte[] { 100, 183, 250, 237, 232, 218, 172, 63, 57, 60, 151, 220, 14, 246, 94, 107, 213, 178, 131, 184, 51, 254, 173, 7, 87, 76, 56, 88, 46, 205, 29, 141, 55, 84, 247, 143, 119, 181, 251, 23, 174, 154, 170, 201, 169, 112, 227, 19, 84, 103, 193, 137, 221, 80, 192, 251, 64, 55, 238, 128, 139, 163, 235, 76 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(8900), new DateTime(2024, 5, 24, 11, 17, 27, 748, DateTimeKind.Utc).AddTicks(9012), new byte[] { 246, 237, 154, 68, 11, 56, 188, 200, 201, 153, 94, 19, 226, 190, 112, 143, 5, 216, 235, 109, 59, 37, 161, 98, 76, 20, 44, 151, 52, 255, 131, 241 }, new byte[] { 100, 183, 250, 237, 232, 218, 172, 63, 57, 60, 151, 220, 14, 246, 94, 107, 213, 178, 131, 184, 51, 254, 173, 7, 87, 76, 56, 88, 46, 205, 29, 141, 55, 84, 247, 143, 119, 181, 251, 23, 174, 154, 170, 201, 169, 112, 227, 19, 84, 103, 193, 137, 221, 80, 192, 251, 64, 55, 238, 128, 139, 163, 235, 76 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9065), new DateTime(2024, 5, 24, 11, 17, 27, 748, DateTimeKind.Utc).AddTicks(9079), new byte[] { 246, 237, 154, 68, 11, 56, 188, 200, 201, 153, 94, 19, 226, 190, 112, 143, 5, 216, 235, 109, 59, 37, 161, 98, 76, 20, 44, 151, 52, 255, 131, 241 }, new byte[] { 100, 183, 250, 237, 232, 218, 172, 63, 57, 60, 151, 220, 14, 246, 94, 107, 213, 178, 131, 184, 51, 254, 173, 7, 87, 76, 56, 88, 46, 205, 29, 141, 55, 84, 247, 143, 119, 181, 251, 23, 174, 154, 170, 201, 169, 112, 227, 19, 84, 103, 193, 137, 221, 80, 192, 251, 64, 55, 238, 128, 139, 163, 235, 76 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9035), new DateTime(2024, 5, 24, 11, 17, 27, 748, DateTimeKind.Utc).AddTicks(9049), new byte[] { 246, 237, 154, 68, 11, 56, 188, 200, 201, 153, 94, 19, 226, 190, 112, 143, 5, 216, 235, 109, 59, 37, 161, 98, 76, 20, 44, 151, 52, 255, 131, 241 }, new byte[] { 100, 183, 250, 237, 232, 218, 172, 63, 57, 60, 151, 220, 14, 246, 94, 107, 213, 178, 131, 184, 51, 254, 173, 7, 87, 76, 56, 88, 46, 205, 29, 141, 55, 84, 247, 143, 119, 181, 251, 23, 174, 154, 170, 201, 169, 112, 227, 19, 84, 103, 193, 137, 221, 80, 192, 251, 64, 55, 238, 128, 139, 163, 235, 76 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9168), new DateTime(2024, 5, 24, 11, 17, 27, 748, DateTimeKind.Utc).AddTicks(9184), new byte[] { 246, 237, 154, 68, 11, 56, 188, 200, 201, 153, 94, 19, 226, 190, 112, 143, 5, 216, 235, 109, 59, 37, 161, 98, 76, 20, 44, 151, 52, 255, 131, 241 }, new byte[] { 100, 183, 250, 237, 232, 218, 172, 63, 57, 60, 151, 220, 14, 246, 94, 107, 213, 178, 131, 184, 51, 254, 173, 7, 87, 76, 56, 88, 46, 205, 29, 141, 55, 84, 247, 143, 119, 181, 251, 23, 174, 154, 170, 201, 169, 112, 227, 19, 84, 103, 193, 137, 221, 80, 192, 251, 64, 55, 238, 128, 139, 163, 235, 76 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9148), new DateTime(2024, 5, 24, 11, 17, 27, 748, DateTimeKind.Utc).AddTicks(9165), new byte[] { 246, 237, 154, 68, 11, 56, 188, 200, 201, 153, 94, 19, 226, 190, 112, 143, 5, 216, 235, 109, 59, 37, 161, 98, 76, 20, 44, 151, 52, 255, 131, 241 }, new byte[] { 100, 183, 250, 237, 232, 218, 172, 63, 57, 60, 151, 220, 14, 246, 94, 107, 213, 178, 131, 184, 51, 254, 173, 7, 87, 76, 56, 88, 46, 205, 29, 141, 55, 84, 247, 143, 119, 181, 251, 23, 174, 154, 170, 201, 169, 112, 227, 19, 84, 103, 193, 137, 221, 80, 192, 251, 64, 55, 238, 128, 139, 163, 235, 76 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 18, 17, 27, 748, DateTimeKind.Local).AddTicks(9394));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentIdAppointment",
                table: "MedicalRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_AppointmentIdAppointment",
                table: "MedicalRecords",
                column: "AppointmentIdAppointment");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_Appointments_AppointmentIdAppointment",
                table: "MedicalRecords",
                column: "AppointmentIdAppointment",
                principalTable: "Appointments",
                principalColumn: "IdAppointment",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
