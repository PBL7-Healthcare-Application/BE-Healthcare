using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableDoctorUser_AddFieldUpdatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "User",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Doctors",
                type: "datetime(6)",
                nullable: true);

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3113), null });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3093), null });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3109), null });

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
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2964), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(2976), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 }, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2935), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(2950), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 }, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2844), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(2932), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 }, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3023), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(3037), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 }, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(2951), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(2963), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 }, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3051), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(3063), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 }, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 7, 3, 654, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 5, 25, 8, 7, 3, 654, DateTimeKind.Utc).AddTicks(3050), new byte[] { 53, 179, 120, 77, 127, 199, 28, 196, 227, 146, 51, 20, 215, 15, 51, 232, 13, 172, 167, 160, 237, 20, 194, 230, 42, 84, 243, 248, 5, 71, 107, 17 }, new byte[] { 106, 226, 172, 203, 252, 104, 69, 122, 21, 173, 175, 183, 25, 11, 180, 160, 151, 189, 67, 149, 172, 146, 49, 247, 234, 137, 63, 78, 155, 105, 67, 168, 250, 14, 212, 166, 83, 158, 32, 161, 62, 209, 55, 243, 60, 70, 219, 219, 143, 100, 212, 66, 235, 71, 227, 47, 245, 88, 177, 237, 78, 121, 237, 159 }, null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Doctors");

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
    }
}
