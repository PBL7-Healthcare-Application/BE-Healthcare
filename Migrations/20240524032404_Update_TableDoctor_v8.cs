using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableDoctor_v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfComment",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RateAverage",
                table: "Doctors",
                type: "double",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                columns: new[] { "CreatedAt", "NumberOfComment", "RateAverage" },
                values: new object[] { new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6063), 0, null });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                columns: new[] { "CreatedAt", "NumberOfComment", "RateAverage" },
                values: new object[] { new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6017), 0, null });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                columns: new[] { "CreatedAt", "NumberOfComment", "RateAverage" },
                values: new object[] { new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6052), 0, null });

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 5, 24, 3, 24, 4, 87, DateTimeKind.Utc).AddTicks(5674), new byte[] { 250, 98, 79, 79, 99, 204, 248, 131, 141, 4, 214, 109, 188, 254, 9, 72, 143, 250, 66, 234, 241, 181, 248, 97, 168, 39, 127, 190, 56, 124, 147, 162 }, new byte[] { 211, 245, 159, 237, 215, 31, 252, 57, 134, 185, 181, 145, 225, 244, 90, 98, 40, 222, 236, 172, 47, 40, 238, 4, 71, 160, 167, 71, 126, 7, 54, 171, 145, 210, 7, 6, 49, 37, 48, 254, 249, 164, 109, 175, 4, 96, 222, 213, 186, 236, 140, 200, 223, 234, 217, 1, 106, 238, 141, 155, 252, 156, 193, 7 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(5581), new DateTime(2024, 5, 24, 3, 24, 4, 87, DateTimeKind.Utc).AddTicks(5614), new byte[] { 250, 98, 79, 79, 99, 204, 248, 131, 141, 4, 214, 109, 188, 254, 9, 72, 143, 250, 66, 234, 241, 181, 248, 97, 168, 39, 127, 190, 56, 124, 147, 162 }, new byte[] { 211, 245, 159, 237, 215, 31, 252, 57, 134, 185, 181, 145, 225, 244, 90, 98, 40, 222, 236, 172, 47, 40, 238, 4, 71, 160, 167, 71, 126, 7, 54, 171, 145, 210, 7, 6, 49, 37, 48, 254, 249, 164, 109, 175, 4, 96, 222, 213, 186, 236, 140, 200, 223, 234, 217, 1, 106, 238, 141, 155, 252, 156, 193, 7 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(5293), new DateTime(2024, 5, 24, 3, 24, 4, 87, DateTimeKind.Utc).AddTicks(5576), new byte[] { 250, 98, 79, 79, 99, 204, 248, 131, 141, 4, 214, 109, 188, 254, 9, 72, 143, 250, 66, 234, 241, 181, 248, 97, 168, 39, 127, 190, 56, 124, 147, 162 }, new byte[] { 211, 245, 159, 237, 215, 31, 252, 57, 134, 185, 181, 145, 225, 244, 90, 98, 40, 222, 236, 172, 47, 40, 238, 4, 71, 160, 167, 71, 126, 7, 54, 171, 145, 210, 7, 6, 49, 37, 48, 254, 249, 164, 109, 175, 4, 96, 222, 213, 186, 236, 140, 200, 223, 234, 217, 1, 106, 238, 141, 155, 252, 156, 193, 7 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(5832), new DateTime(2024, 5, 24, 3, 24, 4, 87, DateTimeKind.Utc).AddTicks(5868), new byte[] { 250, 98, 79, 79, 99, 204, 248, 131, 141, 4, 214, 109, 188, 254, 9, 72, 143, 250, 66, 234, 241, 181, 248, 97, 168, 39, 127, 190, 56, 124, 147, 162 }, new byte[] { 211, 245, 159, 237, 215, 31, 252, 57, 134, 185, 181, 145, 225, 244, 90, 98, 40, 222, 236, 172, 47, 40, 238, 4, 71, 160, 167, 71, 126, 7, 54, 171, 145, 210, 7, 6, 49, 37, 48, 254, 249, 164, 109, 175, 4, 96, 222, 213, 186, 236, 140, 200, 223, 234, 217, 1, 106, 238, 141, 155, 252, 156, 193, 7 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(5616), new DateTime(2024, 5, 24, 3, 24, 4, 87, DateTimeKind.Utc).AddTicks(5649), new byte[] { 250, 98, 79, 79, 99, 204, 248, 131, 141, 4, 214, 109, 188, 254, 9, 72, 143, 250, 66, 234, 241, 181, 248, 97, 168, 39, 127, 190, 56, 124, 147, 162 }, new byte[] { 211, 245, 159, 237, 215, 31, 252, 57, 134, 185, 181, 145, 225, 244, 90, 98, 40, 222, 236, 172, 47, 40, 238, 4, 71, 160, 167, 71, 126, 7, 54, 171, 145, 210, 7, 6, 49, 37, 48, 254, 249, 164, 109, 175, 4, 96, 222, 213, 186, 236, 140, 200, 223, 234, 217, 1, 106, 238, 141, 155, 252, 156, 193, 7 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(5898), new DateTime(2024, 5, 24, 3, 24, 4, 87, DateTimeKind.Utc).AddTicks(5928), new byte[] { 250, 98, 79, 79, 99, 204, 248, 131, 141, 4, 214, 109, 188, 254, 9, 72, 143, 250, 66, 234, 241, 181, 248, 97, 168, 39, 127, 190, 56, 124, 147, 162 }, new byte[] { 211, 245, 159, 237, 215, 31, 252, 57, 134, 185, 181, 145, 225, 244, 90, 98, 40, 222, 236, 172, 47, 40, 238, 4, 71, 160, 167, 71, 126, 7, 54, 171, 145, 210, 7, 6, 49, 37, 48, 254, 249, 164, 109, 175, 4, 96, 222, 213, 186, 236, 140, 200, 223, 234, 217, 1, 106, 238, 141, 155, 252, 156, 193, 7 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(5871), new DateTime(2024, 5, 24, 3, 24, 4, 87, DateTimeKind.Utc).AddTicks(5897), new byte[] { 250, 98, 79, 79, 99, 204, 248, 131, 141, 4, 214, 109, 188, 254, 9, 72, 143, 250, 66, 234, 241, 181, 248, 97, 168, 39, 127, 190, 56, 124, 147, 162 }, new byte[] { 211, 245, 159, 237, 215, 31, 252, 57, 134, 185, 181, 145, 225, 244, 90, 98, 40, 222, 236, 172, 47, 40, 238, 4, 71, 160, 167, 71, 126, 7, 54, 171, 145, 210, 7, 6, 49, 37, 48, 254, 249, 164, 109, 175, 4, 96, 222, 213, 186, 236, 140, 200, 223, 234, 217, 1, 106, 238, 141, 155, 252, 156, 193, 7 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6388));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfComment",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "RateAverage",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 1, 11, 0, 857, DateTimeKind.Local).AddTicks(9457));

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
    }
}
