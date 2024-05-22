using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableUser_v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsVerifiedAllInfo",
                table: "Doctors",
                newName: "IsVerifiedInfoWorkingProcess");

            migrationBuilder.AddColumn<bool>(
                name: "IsVerifiedInfoCertificate",
                table: "Doctors",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerifiedInfoTrainingProcess",
                table: "Doctors",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                columns: new[] { "CreatedAt", "IsVerifiedInfoCertificate", "IsVerifiedInfoTrainingProcess" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7123), true, true });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                columns: new[] { "CreatedAt", "IsVerifiedInfoCertificate", "IsVerifiedInfoTrainingProcess" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7107), true, true });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                columns: new[] { "CreatedAt", "IsVerifiedInfoCertificate", "IsVerifiedInfoTrainingProcess" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7118), true, true });

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7030), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(7042), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7001), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(7016), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6915), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(6998), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7043), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(7055), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7017), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(7029), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7069), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(7082), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7056), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(7068), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7232));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerifiedInfoCertificate",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "IsVerifiedInfoTrainingProcess",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "IsVerifiedInfoWorkingProcess",
                table: "Doctors",
                newName: "IsVerifiedAllInfo");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5942), new DateTime(2024, 5, 22, 4, 20, 12, 183, DateTimeKind.Utc).AddTicks(5956), new byte[] { 200, 75, 56, 70, 196, 194, 209, 114, 243, 203, 224, 191, 190, 209, 187, 96, 236, 202, 1, 213, 226, 146, 198, 70, 174, 255, 76, 40, 219, 254, 229, 84 }, new byte[] { 25, 251, 208, 118, 50, 116, 0, 43, 25, 220, 110, 44, 192, 231, 1, 141, 68, 39, 90, 226, 85, 111, 70, 89, 107, 5, 173, 133, 77, 239, 22, 30, 69, 151, 184, 148, 250, 172, 187, 161, 135, 64, 207, 179, 85, 176, 39, 61, 190, 33, 240, 48, 167, 46, 78, 50, 19, 184, 61, 253, 178, 66, 91, 29 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5908), new DateTime(2024, 5, 22, 4, 20, 12, 183, DateTimeKind.Utc).AddTicks(5924), new byte[] { 200, 75, 56, 70, 196, 194, 209, 114, 243, 203, 224, 191, 190, 209, 187, 96, 236, 202, 1, 213, 226, 146, 198, 70, 174, 255, 76, 40, 219, 254, 229, 84 }, new byte[] { 25, 251, 208, 118, 50, 116, 0, 43, 25, 220, 110, 44, 192, 231, 1, 141, 68, 39, 90, 226, 85, 111, 70, 89, 107, 5, 173, 133, 77, 239, 22, 30, 69, 151, 184, 148, 250, 172, 187, 161, 135, 64, 207, 179, 85, 176, 39, 61, 190, 33, 240, 48, 167, 46, 78, 50, 19, 184, 61, 253, 178, 66, 91, 29 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5805), new DateTime(2024, 5, 22, 4, 20, 12, 183, DateTimeKind.Utc).AddTicks(5903), new byte[] { 200, 75, 56, 70, 196, 194, 209, 114, 243, 203, 224, 191, 190, 209, 187, 96, 236, 202, 1, 213, 226, 146, 198, 70, 174, 255, 76, 40, 219, 254, 229, 84 }, new byte[] { 25, 251, 208, 118, 50, 116, 0, 43, 25, 220, 110, 44, 192, 231, 1, 141, 68, 39, 90, 226, 85, 111, 70, 89, 107, 5, 173, 133, 77, 239, 22, 30, 69, 151, 184, 148, 250, 172, 187, 161, 135, 64, 207, 179, 85, 176, 39, 61, 190, 33, 240, 48, 167, 46, 78, 50, 19, 184, 61, 253, 178, 66, 91, 29 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5957), new DateTime(2024, 5, 22, 4, 20, 12, 183, DateTimeKind.Utc).AddTicks(5971), new byte[] { 200, 75, 56, 70, 196, 194, 209, 114, 243, 203, 224, 191, 190, 209, 187, 96, 236, 202, 1, 213, 226, 146, 198, 70, 174, 255, 76, 40, 219, 254, 229, 84 }, new byte[] { 25, 251, 208, 118, 50, 116, 0, 43, 25, 220, 110, 44, 192, 231, 1, 141, 68, 39, 90, 226, 85, 111, 70, 89, 107, 5, 173, 133, 77, 239, 22, 30, 69, 151, 184, 148, 250, 172, 187, 161, 135, 64, 207, 179, 85, 176, 39, 61, 190, 33, 240, 48, 167, 46, 78, 50, 19, 184, 61, 253, 178, 66, 91, 29 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5925), new DateTime(2024, 5, 22, 4, 20, 12, 183, DateTimeKind.Utc).AddTicks(5941), new byte[] { 200, 75, 56, 70, 196, 194, 209, 114, 243, 203, 224, 191, 190, 209, 187, 96, 236, 202, 1, 213, 226, 146, 198, 70, 174, 255, 76, 40, 219, 254, 229, 84 }, new byte[] { 25, 251, 208, 118, 50, 116, 0, 43, 25, 220, 110, 44, 192, 231, 1, 141, 68, 39, 90, 226, 85, 111, 70, 89, 107, 5, 173, 133, 77, 239, 22, 30, 69, 151, 184, 148, 250, 172, 187, 161, 135, 64, 207, 179, 85, 176, 39, 61, 190, 33, 240, 48, 167, 46, 78, 50, 19, 184, 61, 253, 178, 66, 91, 29 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5988), new DateTime(2024, 5, 22, 4, 20, 12, 183, DateTimeKind.Utc).AddTicks(6002), new byte[] { 200, 75, 56, 70, 196, 194, 209, 114, 243, 203, 224, 191, 190, 209, 187, 96, 236, 202, 1, 213, 226, 146, 198, 70, 174, 255, 76, 40, 219, 254, 229, 84 }, new byte[] { 25, 251, 208, 118, 50, 116, 0, 43, 25, 220, 110, 44, 192, 231, 1, 141, 68, 39, 90, 226, 85, 111, 70, 89, 107, 5, 173, 133, 77, 239, 22, 30, 69, 151, 184, 148, 250, 172, 187, 161, 135, 64, 207, 179, 85, 176, 39, 61, 190, 33, 240, 48, 167, 46, 78, 50, 19, 184, 61, 253, 178, 66, 91, 29 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(5972), new DateTime(2024, 5, 22, 4, 20, 12, 183, DateTimeKind.Utc).AddTicks(5986), new byte[] { 200, 75, 56, 70, 196, 194, 209, 114, 243, 203, 224, 191, 190, 209, 187, 96, 236, 202, 1, 213, 226, 146, 198, 70, 174, 255, 76, 40, 219, 254, 229, 84 }, new byte[] { 25, 251, 208, 118, 50, 116, 0, 43, 25, 220, 110, 44, 192, 231, 1, 141, 68, 39, 90, 226, 85, 111, 70, 89, 107, 5, 173, 133, 77, 239, 22, 30, 69, 151, 184, 148, 250, 172, 187, 161, 135, 64, 207, 179, 85, 176, 39, 61, 190, 33, 240, 48, 167, 46, 78, 50, 19, 184, 61, 253, 178, 66, 91, 29 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 11, 20, 12, 183, DateTimeKind.Local).AddTicks(6173));
        }
    }
}
