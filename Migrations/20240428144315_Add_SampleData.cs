using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Add_SampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MedicalSpecialties",
                columns: table => new
                {
                    IdSpecialty = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalSpecialties", x => x.IdSpecialty);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRole);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Email = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<byte[]>(type: "longblob", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "longblob", nullable: false),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DOB = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Avatar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gender = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    idRole = table.Column<int>(type: "int", nullable: false),
                    OTPVerification = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OTPCreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsVerified = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_User_Roles_idRole",
                        column: x => x.idRole,
                        principalTable: "Roles",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    YearExperience = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "double", nullable: true),
                    IdSpecialty = table.Column<int>(type: "int", nullable: true),
                    IdUser = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    WorkingTimeStart = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkingTimeEnd = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DurationPerAppointment = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.IdDoctor);
                    table.ForeignKey(
                        name: "FK_Doctors_MedicalSpecialties_IdSpecialty",
                        column: x => x.IdSpecialty,
                        principalTable: "MedicalSpecialties",
                        principalColumn: "IdSpecialty");
                    table.ForeignKey(
                        name: "FK_Doctors_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Token = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JwtId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsUsed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsRevoked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IssuedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExpiredAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    IdCertificate = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.IdCertificate);
                    table.ForeignKey(
                        name: "FK_Certificates_Doctors_IdDoctor",
                        column: x => x.IdDoctor,
                        principalTable: "Doctors",
                        principalColumn: "IdDoctor");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TimeOffs",
                columns: table => new
                {
                    IdTimeOff = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "Date", nullable: true),
                    StartTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EndTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Reason = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeOffs", x => x.IdTimeOff);
                    table.ForeignKey(
                        name: "FK_TimeOffs_Doctors_IdDoctor",
                        column: x => x.IdDoctor,
                        principalTable: "Doctors",
                        principalColumn: "IdDoctor");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainingProcesses",
                columns: table => new
                {
                    IdTrainingProcess = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SchoolName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartYear = table.Column<int>(type: "int", nullable: true),
                    EndYear = table.Column<int>(type: "int", nullable: true),
                    Major = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProcesses", x => x.IdTrainingProcess);
                    table.ForeignKey(
                        name: "FK_TrainingProcesses_Doctors_IdDoctor",
                        column: x => x.IdDoctor,
                        principalTable: "Doctors",
                        principalColumn: "IdDoctor");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkingProcesses",
                columns: table => new
                {
                    IdWorkingProcess = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Position = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartYear = table.Column<int>(type: "int", nullable: true),
                    EndYear = table.Column<int>(type: "int", nullable: true),
                    Workplace = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingProcesses", x => x.IdWorkingProcess);
                    table.ForeignKey(
                        name: "FK_WorkingProcesses_Doctors_IdDoctor",
                        column: x => x.IdDoctor,
                        principalTable: "Doctors",
                        principalColumn: "IdDoctor");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "MedicalSpecialties",
                columns: new[] { "IdSpecialty", "Name" },
                values: new object[,]
                {
                    { 1, "Internal Medicine" },
                    { 2, "General Surgery" },
                    { 3, "Obstetrics and Gynecology" },
                    { 4, "Pediatrics" },
                    { 5, "Emergency Medicine" },
                    { 6, "Dermatology" },
                    { 7, "Dentistry" },
                    { 8, "Plastic Surgery" },
                    { 9, "Nuclear Medicine" },
                    { 10, "Cardiology" },
                    { 11, "Pulmonology" },
                    { 12, "Gastroenterology" },
                    { 13, "Hematology" },
                    { 14, "Endocrinology" },
                    { 15, "Public Health" },
                    { 16, "Preventive Medicine" },
                    { 17, "Psychiatry" },
                    { 18, "Traditional Medicine" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "IdRole", "Name" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Doctor" },
                    { 3, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "IdUser", "Address", "Avatar", "DOB", "Email", "Gender", "IsVerified", "Name", "OTPCreatedAt", "OTPVerification", "PasswordHash", "PasswordSalt", "PhoneNumber", "idRole" },
                values: new object[,]
                {
                    { new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"), null, null, null, "doctor1@gmail.com", null, true, "BS.CKII Trần Thị Hoài Hương", new DateTime(2024, 4, 28, 14, 43, 15, 440, DateTimeKind.Utc).AddTicks(2578), "123456", new byte[] { 62, 27, 121, 222, 74, 220, 242, 94, 47, 147, 14, 16, 156, 245, 25, 253, 3, 1, 3, 68, 123, 250, 254, 83, 1, 221, 91, 50, 234, 136, 54, 13 }, new byte[] { 219, 144, 94, 227, 146, 137, 230, 248, 143, 158, 121, 62, 155, 122, 108, 17, 12, 89, 56, 144, 128, 83, 244, 251, 139, 48, 35, 159, 118, 45, 15, 187, 101, 73, 30, 195, 244, 155, 216, 152, 173, 81, 215, 217, 75, 20, 170, 193, 191, 237, 198, 209, 159, 54, 64, 195, 184, 52, 8, 188, 222, 173, 13, 106 }, null, 2 },
                    { new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"), null, null, null, "buivanhuy@gmail.com", null, true, "Huy Bui", new DateTime(2024, 4, 28, 14, 43, 15, 440, DateTimeKind.Utc).AddTicks(2554), "123456", new byte[] { 62, 27, 121, 222, 74, 220, 242, 94, 47, 147, 14, 16, 156, 245, 25, 253, 3, 1, 3, 68, 123, 250, 254, 83, 1, 221, 91, 50, 234, 136, 54, 13 }, new byte[] { 219, 144, 94, 227, 146, 137, 230, 248, 143, 158, 121, 62, 155, 122, 108, 17, 12, 89, 56, 144, 128, 83, 244, 251, 139, 48, 35, 159, 118, 45, 15, 187, 101, 73, 30, 195, 244, 155, 216, 152, 173, 81, 215, 217, 75, 20, 170, 193, 191, 237, 198, 209, 159, 54, 64, 195, 184, 52, 8, 188, 222, 173, 13, 106 }, null, 1 },
                    { new Guid("9117c626-c3d0-4d14-b345-d70d85268623"), null, null, null, "nguyenquocthanh268@gmail.com", null, true, "Nguyen Quoc Thanh", new DateTime(2024, 4, 28, 14, 43, 15, 440, DateTimeKind.Utc).AddTicks(2535), "123456", new byte[] { 62, 27, 121, 222, 74, 220, 242, 94, 47, 147, 14, 16, 156, 245, 25, 253, 3, 1, 3, 68, 123, 250, 254, 83, 1, 221, 91, 50, 234, 136, 54, 13 }, new byte[] { 219, 144, 94, 227, 146, 137, 230, 248, 143, 158, 121, 62, 155, 122, 108, 17, 12, 89, 56, 144, 128, 83, 244, 251, 139, 48, 35, 159, 118, 45, 15, 187, 101, 73, 30, 195, 244, 155, 216, 152, 173, 81, 215, 217, 75, 20, 170, 193, 191, 237, 198, 209, 159, 54, 64, 195, 184, 52, 8, 188, 222, 173, 13, 106 }, null, 1 },
                    { new Guid("9f12c430-de83-4910-92ac-704bffefaab2"), null, null, null, "doctor2@gmail.com", null, true, "TS.BS Vũ Thái Hà", new DateTime(2024, 4, 28, 14, 43, 15, 440, DateTimeKind.Utc).AddTicks(2590), "123456", new byte[] { 62, 27, 121, 222, 74, 220, 242, 94, 47, 147, 14, 16, 156, 245, 25, 253, 3, 1, 3, 68, 123, 250, 254, 83, 1, 221, 91, 50, 234, 136, 54, 13 }, new byte[] { 219, 144, 94, 227, 146, 137, 230, 248, 143, 158, 121, 62, 155, 122, 108, 17, 12, 89, 56, 144, 128, 83, 244, 251, 139, 48, 35, 159, 118, 45, 15, 187, 101, 73, 30, 195, 244, 155, 216, 152, 173, 81, 215, 217, 75, 20, 170, 193, 191, 237, 198, 209, 159, 54, 64, 195, 184, 52, 8, 188, 222, 173, 13, 106 }, null, 2 },
                    { new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"), null, null, null, "anhoang@gmail.com", null, true, "Vo A Hoang", new DateTime(2024, 4, 28, 14, 43, 15, 440, DateTimeKind.Utc).AddTicks(2566), "123456", new byte[] { 62, 27, 121, 222, 74, 220, 242, 94, 47, 147, 14, 16, 156, 245, 25, 253, 3, 1, 3, 68, 123, 250, 254, 83, 1, 221, 91, 50, 234, 136, 54, 13 }, new byte[] { 219, 144, 94, 227, 146, 137, 230, 248, 143, 158, 121, 62, 155, 122, 108, 17, 12, 89, 56, 144, 128, 83, 244, 251, 139, 48, 35, 159, 118, 45, 15, 187, 101, 73, 30, 195, 244, 155, 216, 152, 173, 81, 215, 217, 75, 20, 170, 193, 191, 237, 198, 209, 159, 54, 64, 195, 184, 52, 8, 188, 222, 173, 13, 106 }, null, 1 },
                    { new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"), null, null, null, "doctor3@gmail.com", null, true, "TS.BS Trần Thịnh", new DateTime(2024, 4, 28, 14, 43, 15, 440, DateTimeKind.Utc).AddTicks(2602), "123456", new byte[] { 62, 27, 121, 222, 74, 220, 242, 94, 47, 147, 14, 16, 156, 245, 25, 253, 3, 1, 3, 68, 123, 250, 254, 83, 1, 221, 91, 50, 234, 136, 54, 13 }, new byte[] { 219, 144, 94, 227, 146, 137, 230, 248, 143, 158, 121, 62, 155, 122, 108, 17, 12, 89, 56, 144, 128, 83, 244, 251, 139, 48, 35, 159, 118, 45, 15, 187, 101, 73, 30, 195, 244, 155, 216, 152, 173, 81, 215, 217, 75, 20, 170, 193, 191, 237, 198, 209, 159, 54, 64, 195, 184, 52, 8, 188, 222, 173, 13, 106 }, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "DurationPerAppointment", "IdSpecialty", "IdUser", "Price", "WorkingTimeEnd", "WorkingTimeStart", "YearExperience" },
                values: new object[,]
                {
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"), 1, 1, new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"), 400000.0, "18:00", "08:00", 7 },
                    { new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), 1, 7, new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"), 500000.0, "17:00", "08:00", 5 },
                    { new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"), 1, 5, new Guid("9f12c430-de83-4910-92ac-704bffefaab2"), 600000.0, "17:00", "07:00", 8 }
                });

            migrationBuilder.InsertData(
                table: "TimeOffs",
                columns: new[] { "IdTimeOff", "Date", "EndTime", "IdDoctor", "Reason", "StartTime", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10:00", new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Busy with family", "08:00", 1 },
                    { 2, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "16:00", new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Busy with family", "15:00", 1 },
                    { 3, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "13:00", new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), null, "11:00", 2 }
                });

            migrationBuilder.InsertData(
                table: "TrainingProcesses",
                columns: new[] { "IdTrainingProcess", "EndYear", "IdDoctor", "Major", "SchoolName", "StartYear" },
                values: new object[,]
                {
                    { 1, null, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Tốt nghiệp Bác sĩ Chuyên khoa II, chuyên ngành Da liễu", "Đại học Y Dược TP.HCM", null },
                    { 2, null, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Tốt nghiệp Bác sĩ Chuyên khoa I, chuyên ngành Da liễu", "Đại học Y Dược TP.HCM", null },
                    { 3, null, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Tốt nghiệp Bác sĩ Đa khoa", "Đại học Y Dược TP.HCM", null },
                    { 4, null, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Tham gia lớp Sơ bộ DInh dưỡng", "Đại học Y khoa Phạm Ngọc Thạch", null }
                });

            migrationBuilder.InsertData(
                table: "WorkingProcesses",
                columns: new[] { "IdWorkingProcess", "EndYear", "IdDoctor", "Position", "StartYear", "Workplace" },
                values: new object[,]
                {
                    { 1, 2014, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Bác sĩ Da liễu", 2012, "Phòng khám Da liễu Táo Đỏ" },
                    { 2, 2014, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Nguyên Phó Trưởng khoa Lâm sàng 1", 2012, "Bệnh viện Da liễu TP. HCM" },
                    { 3, 2014, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Trưởng Khoa Dinh Dưỡng", 2012, "Bệnh viện Da liễu TP. HCM" },
                    { 4, 2014, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Bác sĩ chuyên khoa da liễu, thẩm mỹ da", 2012, "Bệnh viện Da liễu TP. HCM" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_IdDoctor",
                table: "Certificates",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_IdSpecialty",
                table: "Doctors",
                column: "IdSpecialty");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_IdUser",
                table: "Doctors",
                column: "IdUser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeOffs_IdDoctor",
                table: "TimeOffs",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProcesses_IdDoctor",
                table: "TrainingProcesses",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_User_idRole",
                table: "User",
                column: "idRole");

            migrationBuilder.CreateIndex(
                name: "IX_WorkingProcesses_IdDoctor",
                table: "WorkingProcesses",
                column: "IdDoctor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "TimeOffs");

            migrationBuilder.DropTable(
                name: "TrainingProcesses");

            migrationBuilder.DropTable(
                name: "WorkingProcesses");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "MedicalSpecialties");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
