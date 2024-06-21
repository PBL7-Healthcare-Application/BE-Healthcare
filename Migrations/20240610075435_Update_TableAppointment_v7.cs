using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableAppointment_v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Appointments",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7303), null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7310), null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7313), null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7316), null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 14, 54, 34, 992, DateTimeKind.Local).AddTicks(7319), null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8119), new DateTime(2024, 5, 26, 18, 47, 39, 443, DateTimeKind.Utc).AddTicks(8132), new byte[] { 199, 187, 8, 179, 149, 104, 224, 207, 47, 116, 80, 207, 241, 78, 215, 227, 151, 38, 242, 122, 91, 148, 74, 126, 8, 54, 9, 223, 176, 208, 174, 157 }, new byte[] { 84, 53, 118, 101, 75, 63, 0, 228, 128, 41, 210, 230, 171, 93, 37, 201, 230, 184, 3, 161, 224, 65, 219, 130, 14, 12, 234, 174, 25, 54, 156, 163, 28, 12, 215, 35, 84, 214, 157, 237, 33, 196, 193, 19, 77, 210, 210, 63, 35, 200, 218, 123, 131, 39, 212, 72, 105, 254, 234, 51, 107, 62, 86, 226 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8086), new DateTime(2024, 5, 26, 18, 47, 39, 443, DateTimeKind.Utc).AddTicks(8103), new byte[] { 199, 187, 8, 179, 149, 104, 224, 207, 47, 116, 80, 207, 241, 78, 215, 227, 151, 38, 242, 122, 91, 148, 74, 126, 8, 54, 9, 223, 176, 208, 174, 157 }, new byte[] { 84, 53, 118, 101, 75, 63, 0, 228, 128, 41, 210, 230, 171, 93, 37, 201, 230, 184, 3, 161, 224, 65, 219, 130, 14, 12, 234, 174, 25, 54, 156, 163, 28, 12, 215, 35, 84, 214, 157, 237, 33, 196, 193, 19, 77, 210, 210, 63, 35, 200, 218, 123, 131, 39, 212, 72, 105, 254, 234, 51, 107, 62, 86, 226 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(7920), new DateTime(2024, 5, 26, 18, 47, 39, 443, DateTimeKind.Utc).AddTicks(8080), new byte[] { 199, 187, 8, 179, 149, 104, 224, 207, 47, 116, 80, 207, 241, 78, 215, 227, 151, 38, 242, 122, 91, 148, 74, 126, 8, 54, 9, 223, 176, 208, 174, 157 }, new byte[] { 84, 53, 118, 101, 75, 63, 0, 228, 128, 41, 210, 230, 171, 93, 37, 201, 230, 184, 3, 161, 224, 65, 219, 130, 14, 12, 234, 174, 25, 54, 156, 163, 28, 12, 215, 35, 84, 214, 157, 237, 33, 196, 193, 19, 77, 210, 210, 63, 35, 200, 218, 123, 131, 39, 212, 72, 105, 254, 234, 51, 107, 62, 86, 226 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8133), new DateTime(2024, 5, 26, 18, 47, 39, 443, DateTimeKind.Utc).AddTicks(8147), new byte[] { 199, 187, 8, 179, 149, 104, 224, 207, 47, 116, 80, 207, 241, 78, 215, 227, 151, 38, 242, 122, 91, 148, 74, 126, 8, 54, 9, 223, 176, 208, 174, 157 }, new byte[] { 84, 53, 118, 101, 75, 63, 0, 228, 128, 41, 210, 230, 171, 93, 37, 201, 230, 184, 3, 161, 224, 65, 219, 130, 14, 12, 234, 174, 25, 54, 156, 163, 28, 12, 215, 35, 84, 214, 157, 237, 33, 196, 193, 19, 77, 210, 210, 63, 35, 200, 218, 123, 131, 39, 212, 72, 105, 254, 234, 51, 107, 62, 86, 226 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8104), new DateTime(2024, 5, 26, 18, 47, 39, 443, DateTimeKind.Utc).AddTicks(8117), new byte[] { 199, 187, 8, 179, 149, 104, 224, 207, 47, 116, 80, 207, 241, 78, 215, 227, 151, 38, 242, 122, 91, 148, 74, 126, 8, 54, 9, 223, 176, 208, 174, 157 }, new byte[] { 84, 53, 118, 101, 75, 63, 0, 228, 128, 41, 210, 230, 171, 93, 37, 201, 230, 184, 3, 161, 224, 65, 219, 130, 14, 12, 234, 174, 25, 54, 156, 163, 28, 12, 215, 35, 84, 214, 157, 237, 33, 196, 193, 19, 77, 210, 210, 63, 35, 200, 218, 123, 131, 39, 212, 72, 105, 254, 234, 51, 107, 62, 86, 226 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8162), new DateTime(2024, 5, 26, 18, 47, 39, 443, DateTimeKind.Utc).AddTicks(8200), new byte[] { 199, 187, 8, 179, 149, 104, 224, 207, 47, 116, 80, 207, 241, 78, 215, 227, 151, 38, 242, 122, 91, 148, 74, 126, 8, 54, 9, 223, 176, 208, 174, 157 }, new byte[] { 84, 53, 118, 101, 75, 63, 0, 228, 128, 41, 210, 230, 171, 93, 37, 201, 230, 184, 3, 161, 224, 65, 219, 130, 14, 12, 234, 174, 25, 54, 156, 163, 28, 12, 215, 35, 84, 214, 157, 237, 33, 196, 193, 19, 77, 210, 210, 63, 35, 200, 218, 123, 131, 39, 212, 72, 105, 254, 234, 51, 107, 62, 86, 226 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8148), new DateTime(2024, 5, 26, 18, 47, 39, 443, DateTimeKind.Utc).AddTicks(8161), new byte[] { 199, 187, 8, 179, 149, 104, 224, 207, 47, 116, 80, 207, 241, 78, 215, 227, 151, 38, 242, 122, 91, 148, 74, 126, 8, 54, 9, 223, 176, 208, 174, 157 }, new byte[] { 84, 53, 118, 101, 75, 63, 0, 228, 128, 41, 210, 230, 171, 93, 37, 201, 230, 184, 3, 161, 224, 65, 219, 130, 14, 12, 234, 174, 25, 54, 156, 163, 28, 12, 215, 35, 84, 214, 157, 237, 33, 196, 193, 19, 77, 210, 210, 63, 35, 200, 218, 123, 131, 39, 212, 72, 105, 254, 234, 51, 107, 62, 86, 226 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8488));
        }
    }
}
