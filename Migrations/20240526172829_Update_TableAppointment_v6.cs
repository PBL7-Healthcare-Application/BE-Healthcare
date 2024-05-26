using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableAppointment_v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "StartTimeOfExamination",
                table: "Appointments",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                columns: new[] { "CreatedAt", "StartTimeOfExamination" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9843), null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                columns: new[] { "CreatedAt", "StartTimeOfExamination" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9850), null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                columns: new[] { "CreatedAt", "StartTimeOfExamination" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9853), null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                columns: new[] { "CreatedAt", "StartTimeOfExamination" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9856), null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                columns: new[] { "CreatedAt", "StartTimeOfExamination" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9859), null });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9583), new DateTime(2024, 5, 26, 17, 28, 29, 23, DateTimeKind.Utc).AddTicks(9597), new byte[] { 236, 251, 103, 152, 220, 143, 76, 225, 33, 113, 52, 233, 235, 47, 213, 110, 241, 249, 154, 71, 47, 208, 158, 35, 63, 121, 250, 2, 143, 14, 229, 173 }, new byte[] { 168, 8, 127, 140, 91, 111, 250, 71, 253, 148, 93, 123, 209, 177, 25, 230, 194, 93, 100, 168, 252, 66, 114, 224, 219, 174, 253, 245, 144, 232, 235, 82, 121, 204, 26, 135, 207, 207, 185, 112, 226, 39, 224, 160, 184, 18, 102, 253, 99, 247, 160, 37, 175, 122, 185, 182, 0, 50, 246, 98, 36, 145, 127, 201 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9553), new DateTime(2024, 5, 26, 17, 28, 29, 23, DateTimeKind.Utc).AddTicks(9568), new byte[] { 236, 251, 103, 152, 220, 143, 76, 225, 33, 113, 52, 233, 235, 47, 213, 110, 241, 249, 154, 71, 47, 208, 158, 35, 63, 121, 250, 2, 143, 14, 229, 173 }, new byte[] { 168, 8, 127, 140, 91, 111, 250, 71, 253, 148, 93, 123, 209, 177, 25, 230, 194, 93, 100, 168, 252, 66, 114, 224, 219, 174, 253, 245, 144, 232, 235, 82, 121, 204, 26, 135, 207, 207, 185, 112, 226, 39, 224, 160, 184, 18, 102, 253, 99, 247, 160, 37, 175, 122, 185, 182, 0, 50, 246, 98, 36, 145, 127, 201 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9457), new DateTime(2024, 5, 26, 17, 28, 29, 23, DateTimeKind.Utc).AddTicks(9551), new byte[] { 236, 251, 103, 152, 220, 143, 76, 225, 33, 113, 52, 233, 235, 47, 213, 110, 241, 249, 154, 71, 47, 208, 158, 35, 63, 121, 250, 2, 143, 14, 229, 173 }, new byte[] { 168, 8, 127, 140, 91, 111, 250, 71, 253, 148, 93, 123, 209, 177, 25, 230, 194, 93, 100, 168, 252, 66, 114, 224, 219, 174, 253, 245, 144, 232, 235, 82, 121, 204, 26, 135, 207, 207, 185, 112, 226, 39, 224, 160, 184, 18, 102, 253, 99, 247, 160, 37, 175, 122, 185, 182, 0, 50, 246, 98, 36, 145, 127, 201 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9598), new DateTime(2024, 5, 26, 17, 28, 29, 23, DateTimeKind.Utc).AddTicks(9610), new byte[] { 236, 251, 103, 152, 220, 143, 76, 225, 33, 113, 52, 233, 235, 47, 213, 110, 241, 249, 154, 71, 47, 208, 158, 35, 63, 121, 250, 2, 143, 14, 229, 173 }, new byte[] { 168, 8, 127, 140, 91, 111, 250, 71, 253, 148, 93, 123, 209, 177, 25, 230, 194, 93, 100, 168, 252, 66, 114, 224, 219, 174, 253, 245, 144, 232, 235, 82, 121, 204, 26, 135, 207, 207, 185, 112, 226, 39, 224, 160, 184, 18, 102, 253, 99, 247, 160, 37, 175, 122, 185, 182, 0, 50, 246, 98, 36, 145, 127, 201 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9570), new DateTime(2024, 5, 26, 17, 28, 29, 23, DateTimeKind.Utc).AddTicks(9582), new byte[] { 236, 251, 103, 152, 220, 143, 76, 225, 33, 113, 52, 233, 235, 47, 213, 110, 241, 249, 154, 71, 47, 208, 158, 35, 63, 121, 250, 2, 143, 14, 229, 173 }, new byte[] { 168, 8, 127, 140, 91, 111, 250, 71, 253, 148, 93, 123, 209, 177, 25, 230, 194, 93, 100, 168, 252, 66, 114, 224, 219, 174, 253, 245, 144, 232, 235, 82, 121, 204, 26, 135, 207, 207, 185, 112, 226, 39, 224, 160, 184, 18, 102, 253, 99, 247, 160, 37, 175, 122, 185, 182, 0, 50, 246, 98, 36, 145, 127, 201 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9625), new DateTime(2024, 5, 26, 17, 28, 29, 23, DateTimeKind.Utc).AddTicks(9637), new byte[] { 236, 251, 103, 152, 220, 143, 76, 225, 33, 113, 52, 233, 235, 47, 213, 110, 241, 249, 154, 71, 47, 208, 158, 35, 63, 121, 250, 2, 143, 14, 229, 173 }, new byte[] { 168, 8, 127, 140, 91, 111, 250, 71, 253, 148, 93, 123, 209, 177, 25, 230, 194, 93, 100, 168, 252, 66, 114, 224, 219, 174, 253, 245, 144, 232, 235, 82, 121, 204, 26, 135, 207, 207, 185, 112, 226, 39, 224, 160, 184, 18, 102, 253, 99, 247, 160, 37, 175, 122, 185, 182, 0, 50, 246, 98, 36, 145, 127, 201 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9611), new DateTime(2024, 5, 26, 17, 28, 29, 23, DateTimeKind.Utc).AddTicks(9624), new byte[] { 236, 251, 103, 152, 220, 143, 76, 225, 33, 113, 52, 233, 235, 47, 213, 110, 241, 249, 154, 71, 47, 208, 158, 35, 63, 121, 250, 2, 143, 14, 229, 173 }, new byte[] { 168, 8, 127, 140, 91, 111, 250, 71, 253, 148, 93, 123, 209, 177, 25, 230, 194, 93, 100, 168, 252, 66, 114, 224, 219, 174, 253, 245, 144, 232, 235, 82, 121, 204, 26, 135, 207, 207, 185, 112, 226, 39, 224, 160, 184, 18, 102, 253, 99, 247, 160, 37, 175, 122, 185, 182, 0, 50, 246, 98, 36, 145, 127, 201 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9825));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartTimeOfExamination",
                table: "Appointments");

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
    }
}
