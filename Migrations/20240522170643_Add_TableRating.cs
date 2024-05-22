using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Add_TableRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    IdRating = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RatingScore = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdUser = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.IdRating);
                    table.ForeignKey(
                        name: "FK_Ratings_Doctors_IdDoctor",
                        column: x => x.IdDoctor,
                        principalTable: "Doctors",
                        principalColumn: "IdDoctor");
                    table.ForeignKey(
                        name: "FK_Ratings_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "IdUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_IdDoctor",
                table: "Ratings",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_IdUser",
                table: "Ratings",
                column: "IdUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "TimeOffs",
                keyColumn: "IdTimeOff",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7030), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(7042), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7001), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(7016), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(6915), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(6998), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7043), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(7055), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7017), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(7029), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7069), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(7082), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7056), new DateTime(2024, 5, 22, 8, 4, 50, 951, DateTimeKind.Utc).AddTicks(7068), new byte[] { 100, 151, 160, 118, 1, 2, 44, 158, 218, 86, 210, 117, 112, 19, 83, 24, 128, 92, 209, 45, 25, 96, 249, 235, 234, 173, 166, 202, 193, 80, 149, 163 }, new byte[] { 140, 57, 92, 54, 163, 14, 75, 100, 118, 127, 12, 235, 171, 151, 14, 19, 128, 203, 79, 115, 22, 255, 8, 116, 113, 231, 39, 42, 211, 130, 174, 180, 96, 6, 245, 122, 87, 208, 200, 168, 155, 51, 41, 77, 77, 189, 84, 57, 83, 236, 243, 31, 88, 90, 128, 167, 63, 19, 21, 117, 77, 26, 196, 128 } });

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 15, 4, 50, 951, DateTimeKind.Local).AddTicks(7232));
        }
    }
}
