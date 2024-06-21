using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableTimeOff_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFixed",
                table: "TimeOffs",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsFixed" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2207), false });

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsFixed" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2215), false });

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsFixed" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2217), false });

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsFixed" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2220), false });

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2094), new DateTime(2024, 6, 10, 14, 20, 45, 659, DateTimeKind.Utc).AddTicks(2105), new byte[] { 144, 234, 68, 61, 188, 91, 246, 179, 211, 138, 185, 73, 23, 154, 133, 127, 40, 54, 222, 7, 94, 164, 172, 211, 212, 119, 101, 51, 16, 79, 231, 146 }, new byte[] { 132, 226, 152, 139, 225, 145, 140, 137, 94, 146, 121, 89, 98, 5, 38, 152, 72, 146, 252, 32, 213, 204, 140, 57, 101, 146, 199, 223, 129, 148, 113, 52, 75, 102, 47, 147, 78, 4, 156, 142, 189, 248, 121, 99, 225, 156, 188, 142, 207, 98, 186, 229, 183, 47, 120, 146, 47, 64, 35, 134, 206, 192, 73, 211 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2065), new DateTime(2024, 6, 10, 14, 20, 45, 659, DateTimeKind.Utc).AddTicks(2080), new byte[] { 144, 234, 68, 61, 188, 91, 246, 179, 211, 138, 185, 73, 23, 154, 133, 127, 40, 54, 222, 7, 94, 164, 172, 211, 212, 119, 101, 51, 16, 79, 231, 146 }, new byte[] { 132, 226, 152, 139, 225, 145, 140, 137, 94, 146, 121, 89, 98, 5, 38, 152, 72, 146, 252, 32, 213, 204, 140, 57, 101, 146, 199, 223, 129, 148, 113, 52, 75, 102, 47, 147, 78, 4, 156, 142, 189, 248, 121, 99, 225, 156, 188, 142, 207, 98, 186, 229, 183, 47, 120, 146, 47, 64, 35, 134, 206, 192, 73, 211 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(1825), new DateTime(2024, 6, 10, 14, 20, 45, 659, DateTimeKind.Utc).AddTicks(2063), new byte[] { 144, 234, 68, 61, 188, 91, 246, 179, 211, 138, 185, 73, 23, 154, 133, 127, 40, 54, 222, 7, 94, 164, 172, 211, 212, 119, 101, 51, 16, 79, 231, 146 }, new byte[] { 132, 226, 152, 139, 225, 145, 140, 137, 94, 146, 121, 89, 98, 5, 38, 152, 72, 146, 252, 32, 213, 204, 140, 57, 101, 146, 199, 223, 129, 148, 113, 52, 75, 102, 47, 147, 78, 4, 156, 142, 189, 248, 121, 99, 225, 156, 188, 142, 207, 98, 186, 229, 183, 47, 120, 146, 47, 64, 35, 134, 206, 192, 73, 211 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2106), new DateTime(2024, 6, 10, 14, 20, 45, 659, DateTimeKind.Utc).AddTicks(2118), new byte[] { 144, 234, 68, 61, 188, 91, 246, 179, 211, 138, 185, 73, 23, 154, 133, 127, 40, 54, 222, 7, 94, 164, 172, 211, 212, 119, 101, 51, 16, 79, 231, 146 }, new byte[] { 132, 226, 152, 139, 225, 145, 140, 137, 94, 146, 121, 89, 98, 5, 38, 152, 72, 146, 252, 32, 213, 204, 140, 57, 101, 146, 199, 223, 129, 148, 113, 52, 75, 102, 47, 147, 78, 4, 156, 142, 189, 248, 121, 99, 225, 156, 188, 142, 207, 98, 186, 229, 183, 47, 120, 146, 47, 64, 35, 134, 206, 192, 73, 211 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2081), new DateTime(2024, 6, 10, 14, 20, 45, 659, DateTimeKind.Utc).AddTicks(2093), new byte[] { 144, 234, 68, 61, 188, 91, 246, 179, 211, 138, 185, 73, 23, 154, 133, 127, 40, 54, 222, 7, 94, 164, 172, 211, 212, 119, 101, 51, 16, 79, 231, 146 }, new byte[] { 132, 226, 152, 139, 225, 145, 140, 137, 94, 146, 121, 89, 98, 5, 38, 152, 72, 146, 252, 32, 213, 204, 140, 57, 101, 146, 199, 223, 129, 148, 113, 52, 75, 102, 47, 147, 78, 4, 156, 142, 189, 248, 121, 99, 225, 156, 188, 142, 207, 98, 186, 229, 183, 47, 120, 146, 47, 64, 35, 134, 206, 192, 73, 211 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2131), new DateTime(2024, 6, 10, 14, 20, 45, 659, DateTimeKind.Utc).AddTicks(2142), new byte[] { 144, 234, 68, 61, 188, 91, 246, 179, 211, 138, 185, 73, 23, 154, 133, 127, 40, 54, 222, 7, 94, 164, 172, 211, 212, 119, 101, 51, 16, 79, 231, 146 }, new byte[] { 132, 226, 152, 139, 225, 145, 140, 137, 94, 146, 121, 89, 98, 5, 38, 152, 72, 146, 252, 32, 213, 204, 140, 57, 101, 146, 199, 223, 129, 148, 113, 52, 75, 102, 47, 147, 78, 4, 156, 142, 189, 248, 121, 99, 225, 156, 188, 142, 207, 98, 186, 229, 183, 47, 120, 146, 47, 64, 35, 134, 206, 192, 73, 211 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2119), new DateTime(2024, 6, 10, 14, 20, 45, 659, DateTimeKind.Utc).AddTicks(2130), new byte[] { 144, 234, 68, 61, 188, 91, 246, 179, 211, 138, 185, 73, 23, 154, 133, 127, 40, 54, 222, 7, 94, 164, 172, 211, 212, 119, 101, 51, 16, 79, 231, 146 }, new byte[] { 132, 226, 152, 139, 225, 145, 140, 137, 94, 146, 121, 89, 98, 5, 38, 152, 72, 146, 252, 32, 213, 204, 140, 57, 101, 146, 199, 223, 129, 148, 113, 52, 75, 102, 47, 147, 78, 4, 156, 142, 189, 248, 121, 99, 225, 156, 188, 142, 207, 98, 186, 229, 183, 47, 120, 146, 47, 64, 35, 134, 206, 192, 73, 211 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 21, 20, 45, 659, DateTimeKind.Local).AddTicks(2323));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFixed",
                table: "TimeOffs");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 6, 10, 7, 54, 34, 992, DateTimeKind.Utc).AddTicks(6987), new byte[] { 210, 212, 47, 30, 194, 247, 151, 79, 108, 73, 149, 82, 45, 126, 18, 95, 142, 157, 123, 93, 70, 207, 152, 215, 132, 78, 245, 15, 97, 26, 66, 171 }, new byte[] { 107, 160, 178, 96, 76, 50, 43, 102, 61, 176, 167, 216, 29, 92, 26, 240, 90, 124, 251, 251, 247, 117, 227, 54, 17, 110, 52, 199, 250, 35, 13, 20, 96, 12, 155, 85, 43, 77, 150, 83, 99, 181, 221, 254, 1, 78, 2, 129, 32, 91, 127, 253, 0, 47, 225, 104, 43, 204, 80, 122, 236, 139, 178, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6948), new DateTime(2024, 6, 10, 7, 54, 34, 992, DateTimeKind.Utc).AddTicks(6960), new byte[] { 210, 212, 47, 30, 194, 247, 151, 79, 108, 73, 149, 82, 45, 126, 18, 95, 142, 157, 123, 93, 70, 207, 152, 215, 132, 78, 245, 15, 97, 26, 66, 171 }, new byte[] { 107, 160, 178, 96, 76, 50, 43, 102, 61, 176, 167, 216, 29, 92, 26, 240, 90, 124, 251, 251, 247, 117, 227, 54, 17, 110, 52, 199, 250, 35, 13, 20, 96, 12, 155, 85, 43, 77, 150, 83, 99, 181, 221, 254, 1, 78, 2, 129, 32, 91, 127, 253, 0, 47, 225, 104, 43, 204, 80, 122, 236, 139, 178, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6855), new DateTime(2024, 6, 10, 7, 54, 34, 992, DateTimeKind.Utc).AddTicks(6946), new byte[] { 210, 212, 47, 30, 194, 247, 151, 79, 108, 73, 149, 82, 45, 126, 18, 95, 142, 157, 123, 93, 70, 207, 152, 215, 132, 78, 245, 15, 97, 26, 66, 171 }, new byte[] { 107, 160, 178, 96, 76, 50, 43, 102, 61, 176, 167, 216, 29, 92, 26, 240, 90, 124, 251, 251, 247, 117, 227, 54, 17, 110, 52, 199, 250, 35, 13, 20, 96, 12, 155, 85, 43, 77, 150, 83, 99, 181, 221, 254, 1, 78, 2, 129, 32, 91, 127, 253, 0, 47, 225, 104, 43, 204, 80, 122, 236, 139, 178, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 6, 10, 7, 54, 34, 992, DateTimeKind.Utc).AddTicks(7097), new byte[] { 210, 212, 47, 30, 194, 247, 151, 79, 108, 73, 149, 82, 45, 126, 18, 95, 142, 157, 123, 93, 70, 207, 152, 215, 132, 78, 245, 15, 97, 26, 66, 171 }, new byte[] { 107, 160, 178, 96, 76, 50, 43, 102, 61, 176, 167, 216, 29, 92, 26, 240, 90, 124, 251, 251, 247, 117, 227, 54, 17, 110, 52, 199, 250, 35, 13, 20, 96, 12, 155, 85, 43, 77, 150, 83, 99, 181, 221, 254, 1, 78, 2, 129, 32, 91, 127, 253, 0, 47, 225, 104, 43, 204, 80, 122, 236, 139, 178, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(6961), new DateTime(2024, 6, 10, 7, 54, 34, 992, DateTimeKind.Utc).AddTicks(6973), new byte[] { 210, 212, 47, 30, 194, 247, 151, 79, 108, 73, 149, 82, 45, 126, 18, 95, 142, 157, 123, 93, 70, 207, 152, 215, 132, 78, 245, 15, 97, 26, 66, 171 }, new byte[] { 107, 160, 178, 96, 76, 50, 43, 102, 61, 176, 167, 216, 29, 92, 26, 240, 90, 124, 251, 251, 247, 117, 227, 54, 17, 110, 52, 199, 250, 35, 13, 20, 96, 12, 155, 85, 43, 77, 150, 83, 99, 181, 221, 254, 1, 78, 2, 129, 32, 91, 127, 253, 0, 47, 225, 104, 43, 204, 80, 122, 236, 139, 178, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7111), new DateTime(2024, 6, 10, 7, 54, 34, 992, DateTimeKind.Utc).AddTicks(7123), new byte[] { 210, 212, 47, 30, 194, 247, 151, 79, 108, 73, 149, 82, 45, 126, 18, 95, 142, 157, 123, 93, 70, 207, 152, 215, 132, 78, 245, 15, 97, 26, 66, 171 }, new byte[] { 107, 160, 178, 96, 76, 50, 43, 102, 61, 176, 167, 216, 29, 92, 26, 240, 90, 124, 251, 251, 247, 117, 227, 54, 17, 110, 52, 199, 250, 35, 13, 20, 96, 12, 155, 85, 43, 77, 150, 83, 99, 181, 221, 254, 1, 78, 2, 129, 32, 91, 127, 253, 0, 47, 225, 104, 43, 204, 80, 122, 236, 139, 178, 2 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7098), new DateTime(2024, 6, 10, 7, 54, 34, 992, DateTimeKind.Utc).AddTicks(7110), new byte[] { 210, 212, 47, 30, 194, 247, 151, 79, 108, 73, 149, 82, 45, 126, 18, 95, 142, 157, 123, 93, 70, 207, 152, 215, 132, 78, 245, 15, 97, 26, 66, 171 }, new byte[] { 107, 160, 178, 96, 76, 50, 43, 102, 61, 176, 167, 216, 29, 92, 26, 240, 90, 124, 251, 251, 247, 117, 227, 54, 17, 110, 52, 199, 250, 35, 13, 20, 96, 12, 155, 85, 43, 77, 150, 83, 99, 181, 221, 254, 1, 78, 2, 129, 32, 91, 127, 253, 0, 47, 225, 104, 43, 204, 80, 122, 236, 139, 178, 2 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7287));
        }
    }
}
