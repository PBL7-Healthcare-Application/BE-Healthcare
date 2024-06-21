using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableAppointment_v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Ratings",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAppointment",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsRating",
                table: "Appointments",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsRating" },
                values: new object[] { new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9437), false });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsRating" },
                values: new object[] { new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9446), false });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsRating" },
                values: new object[] { new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9449), false });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsRating" },
                values: new object[] { new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9453), false });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsRating" },
                values: new object[] { new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9457), false });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9087), new DateTime(2024, 5, 22, 18, 11, 0, 857, DateTimeKind.Utc).AddTicks(9099), new byte[] { 148, 158, 235, 150, 97, 140, 112, 105, 140, 65, 114, 34, 85, 53, 9, 99, 72, 109, 161, 65, 202, 189, 253, 47, 186, 221, 203, 172, 207, 198, 86, 175 }, new byte[] { 184, 189, 250, 3, 101, 249, 106, 115, 206, 89, 156, 29, 112, 1, 64, 3, 59, 77, 240, 37, 28, 234, 195, 109, 169, 70, 198, 43, 152, 170, 209, 145, 82, 167, 130, 10, 132, 202, 210, 214, 33, 83, 111, 201, 19, 213, 205, 65, 29, 21, 160, 211, 56, 22, 85, 85, 103, 249, 19, 56, 56, 170, 179, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9057), new DateTime(2024, 5, 22, 18, 11, 0, 857, DateTimeKind.Utc).AddTicks(9072), new byte[] { 148, 158, 235, 150, 97, 140, 112, 105, 140, 65, 114, 34, 85, 53, 9, 99, 72, 109, 161, 65, 202, 189, 253, 47, 186, 221, 203, 172, 207, 198, 86, 175 }, new byte[] { 184, 189, 250, 3, 101, 249, 106, 115, 206, 89, 156, 29, 112, 1, 64, 3, 59, 77, 240, 37, 28, 234, 195, 109, 169, 70, 198, 43, 152, 170, 209, 145, 82, 167, 130, 10, 132, 202, 210, 214, 33, 83, 111, 201, 19, 213, 205, 65, 29, 21, 160, 211, 56, 22, 85, 85, 103, 249, 19, 56, 56, 170, 179, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(8962), new DateTime(2024, 5, 22, 18, 11, 0, 857, DateTimeKind.Utc).AddTicks(9054), new byte[] { 148, 158, 235, 150, 97, 140, 112, 105, 140, 65, 114, 34, 85, 53, 9, 99, 72, 109, 161, 65, 202, 189, 253, 47, 186, 221, 203, 172, 207, 198, 86, 175 }, new byte[] { 184, 189, 250, 3, 101, 249, 106, 115, 206, 89, 156, 29, 112, 1, 64, 3, 59, 77, 240, 37, 28, 234, 195, 109, 169, 70, 198, 43, 152, 170, 209, 145, 82, 167, 130, 10, 132, 202, 210, 214, 33, 83, 111, 201, 19, 213, 205, 65, 29, 21, 160, 211, 56, 22, 85, 85, 103, 249, 19, 56, 56, 170, 179, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9100), new DateTime(2024, 5, 22, 18, 11, 0, 857, DateTimeKind.Utc).AddTicks(9112), new byte[] { 148, 158, 235, 150, 97, 140, 112, 105, 140, 65, 114, 34, 85, 53, 9, 99, 72, 109, 161, 65, 202, 189, 253, 47, 186, 221, 203, 172, 207, 198, 86, 175 }, new byte[] { 184, 189, 250, 3, 101, 249, 106, 115, 206, 89, 156, 29, 112, 1, 64, 3, 59, 77, 240, 37, 28, 234, 195, 109, 169, 70, 198, 43, 152, 170, 209, 145, 82, 167, 130, 10, 132, 202, 210, 214, 33, 83, 111, 201, 19, 213, 205, 65, 29, 21, 160, 211, 56, 22, 85, 85, 103, 249, 19, 56, 56, 170, 179, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9073), new DateTime(2024, 5, 22, 18, 11, 0, 857, DateTimeKind.Utc).AddTicks(9086), new byte[] { 148, 158, 235, 150, 97, 140, 112, 105, 140, 65, 114, 34, 85, 53, 9, 99, 72, 109, 161, 65, 202, 189, 253, 47, 186, 221, 203, 172, 207, 198, 86, 175 }, new byte[] { 184, 189, 250, 3, 101, 249, 106, 115, 206, 89, 156, 29, 112, 1, 64, 3, 59, 77, 240, 37, 28, 234, 195, 109, 169, 70, 198, 43, 152, 170, 209, 145, 82, 167, 130, 10, 132, 202, 210, 214, 33, 83, 111, 201, 19, 213, 205, 65, 29, 21, 160, 211, 56, 22, 85, 85, 103, 249, 19, 56, 56, 170, 179, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9125), new DateTime(2024, 5, 22, 18, 11, 0, 857, DateTimeKind.Utc).AddTicks(9137), new byte[] { 148, 158, 235, 150, 97, 140, 112, 105, 140, 65, 114, 34, 85, 53, 9, 99, 72, 109, 161, 65, 202, 189, 253, 47, 186, 221, 203, 172, 207, 198, 86, 175 }, new byte[] { 184, 189, 250, 3, 101, 249, 106, 115, 206, 89, 156, 29, 112, 1, 64, 3, 59, 77, 240, 37, 28, 234, 195, 109, 169, 70, 198, 43, 152, 170, 209, 145, 82, 167, 130, 10, 132, 202, 210, 214, 33, 83, 111, 201, 19, 213, 205, 65, 29, 21, 160, 211, 56, 22, 85, 85, 103, 249, 19, 56, 56, 170, 179, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9113), new DateTime(2024, 5, 22, 18, 11, 0, 857, DateTimeKind.Utc).AddTicks(9125), new byte[] { 148, 158, 235, 150, 97, 140, 112, 105, 140, 65, 114, 34, 85, 53, 9, 99, 72, 109, 161, 65, 202, 189, 253, 47, 186, 221, 203, 172, 207, 198, 86, 175 }, new byte[] { 184, 189, 250, 3, 101, 249, 106, 115, 206, 89, 156, 29, 112, 1, 64, 3, 59, 77, 240, 37, 28, 234, 195, 109, 169, 70, 198, 43, 152, 170, 209, 145, 82, 167, 130, 10, 132, 202, 210, 214, 33, 83, 111, 201, 19, 213, 205, 65, 29, 21, 160, 211, 56, 22, 85, 85, 103, 249, 19, 56, 56, 170, 179, 121 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9417));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "IdAppointment",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "IsRating",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8465), new DateTime(2024, 5, 22, 17, 6, 43, 307, DateTimeKind.Utc).AddTicks(8477), new byte[] { 105, 147, 5, 23, 219, 236, 73, 88, 68, 57, 3, 113, 90, 127, 23, 122, 226, 15, 164, 123, 221, 95, 255, 232, 238, 20, 75, 146, 183, 99, 221, 43 }, new byte[] { 71, 199, 55, 158, 72, 173, 11, 84, 96, 239, 88, 149, 145, 63, 231, 23, 190, 23, 114, 42, 113, 236, 139, 67, 155, 254, 76, 113, 83, 225, 221, 56, 189, 163, 54, 165, 128, 143, 3, 13, 157, 154, 113, 102, 52, 169, 217, 237, 208, 31, 227, 195, 168, 147, 149, 110, 35, 243, 177, 205, 161, 112, 251, 229 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 5, 22, 17, 6, 43, 307, DateTimeKind.Utc).AddTicks(8451), new byte[] { 105, 147, 5, 23, 219, 236, 73, 88, 68, 57, 3, 113, 90, 127, 23, 122, 226, 15, 164, 123, 221, 95, 255, 232, 238, 20, 75, 146, 183, 99, 221, 43 }, new byte[] { 71, 199, 55, 158, 72, 173, 11, 84, 96, 239, 88, 149, 145, 63, 231, 23, 190, 23, 114, 42, 113, 236, 139, 67, 155, 254, 76, 113, 83, 225, 221, 56, 189, 163, 54, 165, 128, 143, 3, 13, 157, 154, 113, 102, 52, 169, 217, 237, 208, 31, 227, 195, 168, 147, 149, 110, 35, 243, 177, 205, 161, 112, 251, 229 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8343), new DateTime(2024, 5, 22, 17, 6, 43, 307, DateTimeKind.Utc).AddTicks(8433), new byte[] { 105, 147, 5, 23, 219, 236, 73, 88, 68, 57, 3, 113, 90, 127, 23, 122, 226, 15, 164, 123, 221, 95, 255, 232, 238, 20, 75, 146, 183, 99, 221, 43 }, new byte[] { 71, 199, 55, 158, 72, 173, 11, 84, 96, 239, 88, 149, 145, 63, 231, 23, 190, 23, 114, 42, 113, 236, 139, 67, 155, 254, 76, 113, 83, 225, 221, 56, 189, 163, 54, 165, 128, 143, 3, 13, 157, 154, 113, 102, 52, 169, 217, 237, 208, 31, 227, 195, 168, 147, 149, 110, 35, 243, 177, 205, 161, 112, 251, 229 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8478), new DateTime(2024, 5, 22, 17, 6, 43, 307, DateTimeKind.Utc).AddTicks(8490), new byte[] { 105, 147, 5, 23, 219, 236, 73, 88, 68, 57, 3, 113, 90, 127, 23, 122, 226, 15, 164, 123, 221, 95, 255, 232, 238, 20, 75, 146, 183, 99, 221, 43 }, new byte[] { 71, 199, 55, 158, 72, 173, 11, 84, 96, 239, 88, 149, 145, 63, 231, 23, 190, 23, 114, 42, 113, 236, 139, 67, 155, 254, 76, 113, 83, 225, 221, 56, 189, 163, 54, 165, 128, 143, 3, 13, 157, 154, 113, 102, 52, 169, 217, 237, 208, 31, 227, 195, 168, 147, 149, 110, 35, 243, 177, 205, 161, 112, 251, 229 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8452), new DateTime(2024, 5, 22, 17, 6, 43, 307, DateTimeKind.Utc).AddTicks(8464), new byte[] { 105, 147, 5, 23, 219, 236, 73, 88, 68, 57, 3, 113, 90, 127, 23, 122, 226, 15, 164, 123, 221, 95, 255, 232, 238, 20, 75, 146, 183, 99, 221, 43 }, new byte[] { 71, 199, 55, 158, 72, 173, 11, 84, 96, 239, 88, 149, 145, 63, 231, 23, 190, 23, 114, 42, 113, 236, 139, 67, 155, 254, 76, 113, 83, 225, 221, 56, 189, 163, 54, 165, 128, 143, 3, 13, 157, 154, 113, 102, 52, 169, 217, 237, 208, 31, 227, 195, 168, 147, 149, 110, 35, 243, 177, 205, 161, 112, 251, 229 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8504), new DateTime(2024, 5, 22, 17, 6, 43, 307, DateTimeKind.Utc).AddTicks(8516), new byte[] { 105, 147, 5, 23, 219, 236, 73, 88, 68, 57, 3, 113, 90, 127, 23, 122, 226, 15, 164, 123, 221, 95, 255, 232, 238, 20, 75, 146, 183, 99, 221, 43 }, new byte[] { 71, 199, 55, 158, 72, 173, 11, 84, 96, 239, 88, 149, 145, 63, 231, 23, 190, 23, 114, 42, 113, 236, 139, 67, 155, 254, 76, 113, 83, 225, 221, 56, 189, 163, 54, 165, 128, 143, 3, 13, 157, 154, 113, 102, 52, 169, 217, 237, 208, 31, 227, 195, 168, 147, 149, 110, 35, 243, 177, 205, 161, 112, 251, 229 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8491), new DateTime(2024, 5, 22, 17, 6, 43, 307, DateTimeKind.Utc).AddTicks(8503), new byte[] { 105, 147, 5, 23, 219, 236, 73, 88, 68, 57, 3, 113, 90, 127, 23, 122, 226, 15, 164, 123, 221, 95, 255, 232, 238, 20, 75, 146, 183, 99, 221, 43 }, new byte[] { 71, 199, 55, 158, 72, 173, 11, 84, 96, 239, 88, 149, 145, 63, 231, 23, 190, 23, 114, 42, 113, 236, 139, 67, 155, 254, 76, 113, 83, 225, 221, 56, 189, 163, 54, 165, 128, 143, 3, 13, 157, 154, 113, 102, 52, 169, 217, 237, 208, 31, 227, 195, 168, 147, 149, 110, 35, 243, 177, 205, 161, 112, 251, 229 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 0, 6, 43, 307, DateTimeKind.Local).AddTicks(8679));
        }
    }
}
