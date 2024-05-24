using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Add_TableMedicalRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    IdMedicalRecord = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdUser = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdAppointment = table.Column<int>(type: "int", nullable: false),
                    AppointmentIdAppointment = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "double", nullable: false),
                    Temperature = table.Column<double>(type: "double", nullable: false),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.IdMedicalRecord);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Appointments_AppointmentIdAppointment",
                        column: x => x.AppointmentIdAppointment,
                        principalTable: "Appointments",
                        principalColumn: "IdAppointment",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Doctors_IdDoctor",
                        column: x => x.IdDoctor,
                        principalTable: "Doctors",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6001), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(6013), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5971), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(5986), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5862), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(5968), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6014), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(6026), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(5987), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(6000), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6042), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(6054), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6027), new DateTime(2024, 5, 24, 9, 6, 55, 258, DateTimeKind.Utc).AddTicks(6040), new byte[] { 202, 92, 122, 165, 238, 95, 150, 115, 226, 47, 181, 25, 81, 178, 228, 59, 109, 96, 22, 121, 1, 104, 113, 188, 112, 241, 49, 67, 63, 125, 21, 79 }, new byte[] { 229, 217, 242, 204, 147, 77, 39, 50, 151, 113, 68, 63, 248, 68, 166, 67, 3, 149, 147, 175, 78, 52, 77, 250, 238, 221, 205, 74, 76, 33, 77, 9, 28, 46, 20, 136, 169, 216, 99, 163, 3, 205, 1, 151, 39, 24, 15, 144, 217, 44, 45, 151, 4, 4, 126, 46, 52, 242, 140, 4, 37, 136, 4, 222 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 16, 6, 55, 258, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_AppointmentIdAppointment",
                table: "MedicalRecords",
                column: "AppointmentIdAppointment");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_IdDoctor",
                table: "MedicalRecords",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_IdUser",
                table: "MedicalRecords",
                column: "IdUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalRecords");

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
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 10, 24, 4, 87, DateTimeKind.Local).AddTicks(6052));

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
    }
}
