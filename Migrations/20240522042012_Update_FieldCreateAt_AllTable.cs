using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_FieldCreateAt_AllTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 23, 12, 57, 883, DateTimeKind.Utc).AddTicks(2918));

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
    }
}
