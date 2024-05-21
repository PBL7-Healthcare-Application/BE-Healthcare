using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableDoctor_v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVerifiedAllInfo",
                table: "Doctors",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "IsVerifiedAt",
                table: "Doctors",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                columns: new[] { "CreatedAt", "IsVerifiedAllInfo", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2924), true, null });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                columns: new[] { "CreatedAt", "IsVerifiedAllInfo", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2903), true, null });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                columns: new[] { "CreatedAt", "IsVerifiedAllInfo", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2918), true, null });

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2758), new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2778), new byte[] { 117, 47, 97, 143, 42, 83, 142, 131, 177, 140, 124, 166, 44, 68, 247, 45, 67, 149, 179, 8, 28, 35, 40, 242, 140, 89, 136, 7, 103, 92, 25, 173 }, new byte[] { 154, 116, 83, 37, 251, 173, 73, 113, 99, 63, 52, 167, 40, 99, 85, 90, 92, 148, 240, 58, 20, 170, 235, 121, 85, 72, 39, 122, 220, 150, 247, 48, 23, 187, 169, 230, 73, 110, 55, 6, 159, 188, 103, 99, 120, 108, 166, 109, 253, 221, 40, 192, 132, 151, 14, 225, 80, 149, 127, 185, 162, 167, 131, 18 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2653), new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2679), new byte[] { 117, 47, 97, 143, 42, 83, 142, 131, 177, 140, 124, 166, 44, 68, 247, 45, 67, 149, 179, 8, 28, 35, 40, 242, 140, 89, 136, 7, 103, 92, 25, 173 }, new byte[] { 154, 116, 83, 37, 251, 173, 73, 113, 99, 63, 52, 167, 40, 99, 85, 90, 92, 148, 240, 58, 20, 170, 235, 121, 85, 72, 39, 122, 220, 150, 247, 48, 23, 187, 169, 230, 73, 110, 55, 6, 159, 188, 103, 99, 120, 108, 166, 109, 253, 221, 40, 192, 132, 151, 14, 225, 80, 149, 127, 185, 162, 167, 131, 18 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2520), new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2649), new byte[] { 117, 47, 97, 143, 42, 83, 142, 131, 177, 140, 124, 166, 44, 68, 247, 45, 67, 149, 179, 8, 28, 35, 40, 242, 140, 89, 136, 7, 103, 92, 25, 173 }, new byte[] { 154, 116, 83, 37, 251, 173, 73, 113, 99, 63, 52, 167, 40, 99, 85, 90, 92, 148, 240, 58, 20, 170, 235, 121, 85, 72, 39, 122, 220, 150, 247, 48, 23, 187, 169, 230, 73, 110, 55, 6, 159, 188, 103, 99, 120, 108, 166, 109, 253, 221, 40, 192, 132, 151, 14, 225, 80, 149, 127, 185, 162, 167, 131, 18 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2780), new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2803), new byte[] { 117, 47, 97, 143, 42, 83, 142, 131, 177, 140, 124, 166, 44, 68, 247, 45, 67, 149, 179, 8, 28, 35, 40, 242, 140, 89, 136, 7, 103, 92, 25, 173 }, new byte[] { 154, 116, 83, 37, 251, 173, 73, 113, 99, 63, 52, 167, 40, 99, 85, 90, 92, 148, 240, 58, 20, 170, 235, 121, 85, 72, 39, 122, 220, 150, 247, 48, 23, 187, 169, 230, 73, 110, 55, 6, 159, 188, 103, 99, 120, 108, 166, 109, 253, 221, 40, 192, 132, 151, 14, 225, 80, 149, 127, 185, 162, 167, 131, 18 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2732), new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2756), new byte[] { 117, 47, 97, 143, 42, 83, 142, 131, 177, 140, 124, 166, 44, 68, 247, 45, 67, 149, 179, 8, 28, 35, 40, 242, 140, 89, 136, 7, 103, 92, 25, 173 }, new byte[] { 154, 116, 83, 37, 251, 173, 73, 113, 99, 63, 52, 167, 40, 99, 85, 90, 92, 148, 240, 58, 20, 170, 235, 121, 85, 72, 39, 122, 220, 150, 247, 48, 23, 187, 169, 230, 73, 110, 55, 6, 159, 188, 103, 99, 120, 108, 166, 109, 253, 221, 40, 192, 132, 151, 14, 225, 80, 149, 127, 185, 162, 167, 131, 18 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2827), new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2847), new byte[] { 117, 47, 97, 143, 42, 83, 142, 131, 177, 140, 124, 166, 44, 68, 247, 45, 67, 149, 179, 8, 28, 35, 40, 242, 140, 89, 136, 7, 103, 92, 25, 173 }, new byte[] { 154, 116, 83, 37, 251, 173, 73, 113, 99, 63, 52, 167, 40, 99, 85, 90, 92, 148, 240, 58, 20, 170, 235, 121, 85, 72, 39, 122, 220, 150, 247, 48, 23, 187, 169, 230, 73, 110, 55, 6, 159, 188, 103, 99, 120, 108, 166, 109, 253, 221, 40, 192, 132, 151, 14, 225, 80, 149, 127, 185, 162, 167, 131, 18 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2805), new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2825), new byte[] { 117, 47, 97, 143, 42, 83, 142, 131, 177, 140, 124, 166, 44, 68, 247, 45, 67, 149, 179, 8, 28, 35, 40, 242, 140, 89, 136, 7, 103, 92, 25, 173 }, new byte[] { 154, 116, 83, 37, 251, 173, 73, 113, 99, 63, 52, 167, 40, 99, 85, 90, 92, 148, 240, 58, 20, 170, 235, 121, 85, 72, 39, 122, 220, 150, 247, 48, 23, 187, 169, 230, 73, 110, 55, 6, 159, 188, 103, 99, 120, 108, 166, 109, 253, 221, 40, 192, 132, 151, 14, 225, 80, 149, 127, 185, 162, 167, 131, 18 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(3101));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerifiedAllInfo",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "IsVerifiedAt",
                table: "Doctors");

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
    }
}
