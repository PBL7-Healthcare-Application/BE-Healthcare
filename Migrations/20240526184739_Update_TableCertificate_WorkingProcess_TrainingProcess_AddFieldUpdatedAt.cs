using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableCertificate_WorkingProcess_TrainingProcess_AddFieldUpdatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "WorkingProcesses",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "TrainingProcesses",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Certificates",
                type: "datetime(6)",
                nullable: true);

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8400), null });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8404), null });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8432), null });

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8440), null });

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8442), null });

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8443), null });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8475), null });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8482), null });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8486), null });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 1, 47, 39, 443, DateTimeKind.Local).AddTicks(8488), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "WorkingProcesses");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "TrainingProcesses");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Certificates");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 0, 28, 29, 23, DateTimeKind.Local).AddTicks(9859));

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
    }
}
