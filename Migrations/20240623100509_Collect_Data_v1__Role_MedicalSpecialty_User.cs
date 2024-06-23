using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Collect_Data_v1__Role_MedicalSpecialty_User : Migration
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
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    IsVerified = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReasonLockAccount = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsLocked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsAdminDisabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    latitude = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    longtitude = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdSpecialty = table.Column<int>(type: "int", nullable: true),
                    IdUser = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    WorkingTimeStart = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkingTimeEnd = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DurationPerAppointment = table.Column<int>(type: "int", nullable: true),
                    StatusVerified = table.Column<int>(type: "int", nullable: true),
                    NameClinic = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BusinessLicense = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsVerifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsVerifiedInfoCertificate = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsVerifiedInfoWorkingProcess = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsVerifiedInfoTrainingProcess = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    RateAverage = table.Column<double>(type: "double", nullable: true),
                    NumberOfComment = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    ExpiredAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                name: "Appointments",
                columns: table => new
                {
                    IdAppointment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StartTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EndTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Issue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IdUser = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Price = table.Column<double>(type: "double", nullable: true),
                    Reason = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idDoctorCancel = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    idUserCancel = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsRating = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    StartTimeOfExamination = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.IdAppointment);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_IdDoctor",
                        column: x => x.IdDoctor,
                        principalTable: "Doctors",
                        principalColumn: "IdDoctor");
                    table.ForeignKey(
                        name: "FK_Appointments_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "IdUser");
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
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    StatusVerified = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                name: "MedicalRecords",
                columns: table => new
                {
                    IdMedicalRecord = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdUser = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdAppointment = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "double", nullable: false),
                    Temperature = table.Column<double>(type: "double", nullable: false),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.IdMedicalRecord);
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
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdAppointment = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "TimeOffs",
                columns: table => new
                {
                    IdTimeOff = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    StartTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EndTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Reason = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsFixed = table.Column<bool>(type: "tinyint(1)", nullable: false)
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
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    StatusVerified = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    IdDoctor = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    StatusVerified = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                columns: new[] { "IdSpecialty", "CreatedAt", "Image", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6142), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718981095/yzdx4mxo3nsso9fflv4l.webp", "Internal Medicine" },
                    { 2, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6160), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718981242/codte5bzrbjlmhdboe18.webp", "General Surgery" },
                    { 3, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6163), "https://cdn-healthcare.hellohealthgroup.com/specialties/san-phu-khoa.png", "Obstetrics and Gynecology" },
                    { 4, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6164), "https://cdn-healthcare.hellohealthgroup.com/specialties/nhi-khoa.png", "Pediatrics" },
                    { 5, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6165), "https://res.cloudinary.com/dbtam9pnc/image/upload/v1713413379/Doctor/gigu9hqbvlrdth4y77pv.webp", "Emergency Medicine" },
                    { 6, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6166), "https://cdn-healthcare.hellohealthgroup.com/specialties/da-lieu.png", "Dermatology" },
                    { 7, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6167), "https://cdn-healthcare.hellohealthgroup.com/specialties/nha-khoa.png", "Dentistry" },
                    { 8, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6168), "https://cdn-healthcare.hellohealthgroup.com/2022/03/1648190355_623d6393ac9b40.00770044.jpg", "Plastic Surgery" },
                    { 10, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6169), "https://cdn-healthcare.hellohealthgroup.com/specialties/tim-mach.png", "Cardiology" },
                    { 11, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6170), "https://cdn-healthcare.hellohealthgroup.com/specialties/khoa-phoi.png", "Pulmonology" },
                    { 12, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6171), "https://cdn-healthcare.hellohealthgroup.com/2022/03/1648192254_623d6afed218d0.32746408.jpg", "Gastroenterology" },
                    { 13, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6172), "https://cdn-healthcare.hellohealthgroup.com/specialties/huyet-hoc.png", "Hematology" },
                    { 14, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6173), "https://cdn-healthcare.hellohealthgroup.com/specialties/khoa-noi-tiet.png", "Endocrinology" },
                    { 15, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6174), "https://cdn-healthcare.hellohealthgroup.com/2022/03/1648192124_623d6a7cca01f2.62072083.jpg", "Public Health" },
                    { 17, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6175), "https://cdn-healthcare.hellohealthgroup.com/2022/09/1663834655_632c1a1f872a42.63080420.jpg", "Psychiatry" },
                    { 18, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6177), "https://cdn-healthcare.hellohealthgroup.com/2022/03/1648189960_623d6208833488.26923360.jpg", "Traditional Medicine" }
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
                columns: new[] { "IdUser", "Address", "Avatar", "CreatedAt", "DOB", "Email", "Gender", "IsAdminDisabled", "IsLocked", "IsVerified", "Name", "OTPCreatedAt", "OTPVerification", "PasswordHash", "PasswordSalt", "PhoneNumber", "ReasonLockAccount", "UpdatedAt", "idRole", "latitude", "longtitude" },
                values: new object[,]
                {
                    { new Guid("1ba4b5ec-1ad8-4676-8871-122749af64e4"), "45 Elm Street, Springfield, IL", "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719069524/v8hu3qi9f8soqsagswtn.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7091), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@gmail.com", true, false, false, true, "John Doe", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7113), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0905001234", null, null, 1, null, null },
                    { new Guid("1f2b4a9d-793e-4c89-9fdf-3d1e684d816f"), "1081 Ngo Quyen Street, An Hai Bac, Son Tra, Da Nang", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1542460196/fab102d3-a80c-44cf-93fe-d2f03d104dfb/339ba259-2169-4ab8-b7c5-7c9c656ca099.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7628), new DateTime(1968, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ava.thompson@gmail.com", true, false, false, true, "Dr. Ava Thompson", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7645), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0931467082", null, null, 2, "16.0598485", "108.2346953" },
                    { new Guid("2ba4b5ec-1ad8-4676-8871-122749af64e4"), "123 Maple Avenue, Anytown, TX", "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719069584/n1gpp4jdduagdkvdwkfq.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7115), new DateTime(1985, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@gmail.com", false, false, false, true, "Jane Smith", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7135), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0905012345", null, null, 1, null, null },
                    { new Guid("3ba4b5ec-1ad8-4676-8871-122749af64e4"), "789 Oak Lane, Chicago, IL", "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719069658/uxi5cbd5ohtwtefwu2un.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7137), new DateTime(1975, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.jordan@gmail.com", true, false, false, true, "Michael Jordan", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7159), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0905023456", null, null, 1, null, null },
                    { new Guid("4a9dc58e-282a-4f92-9b0d-bb1a707c3f7b"), "280 Nguyen Huu Tho Street, Khue Trung Ward, Cam Le District, Da Nang City", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1540363288/412b2fae-1c1e-4923-952b-358d971977df/13f5a650-d939-45b5-a621-344f1144b004.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7593), new DateTime(1963, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "mia.robinson@gmail.com", true, false, false, true, "Dr. Mia Robinson", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7609), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0936842197", null, null, 2, "16.0374192", "108.2098811" },
                    { new Guid("4ba4b5ec-1ad8-4676-8871-122749af64e4"), "456 Pine Street, Los Angeles, CA", "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719069721/gtzyqa4injuat46wbtsb.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7161), new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.davis@gmail.com", false, false, false, true, "Emily Davis", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7183), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0905034567", null, null, 1, null, null },
                    { new Guid("5ba4b5ec-1ad8-4676-8871-122749af64e4"), "321 Cedar Drive, Boston, MA", "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070149/ez0opee2spindl6qiypt.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7184), new DateTime(1980, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "robert.brown@gmail.com", true, false, false, true, "Robert Brown", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7208), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0905045678", null, null, 1, null, null },
                    { new Guid("6ba4b5ec-1ad8-4676-8871-122749af64e4"), "654 Birch Avenue, Seattle, WA", "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070219/mfyvzdpu2tfyovqv6zk9.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7209), new DateTime(1992, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "lisa.wilson@gmail.com", false, false, false, true, "Lisa Wilson", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7231), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0905056789", null, null, 1, null, null },
                    { new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"), "19 Nguyen Tuong Pho Street, Hoa Minh, Lien Chieu, Da Nang", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1680511237/2fb7ee0f-dfee-4579-a119-95bccd9bdea6/fa9d5fa9-2c93-428b-aee0-03f4ce064bd9.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7257), new DateTime(1972, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.smith@gmail.com", true, false, false, true, "Dr. John Smith", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7281), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0900127848", null, null, 2, "16.063627", "108.1745195" },
                    { new Guid("7ba4b5ec-1ad8-4676-8871-122749af64e4"), "987 Willow Lane, Miami, FL", "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070316/o1pmjoj2vu1jycmmb6ny.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7232), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.clark@example.com", true, false, false, true, "David Clark", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7255), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0905067890", null, null, 1, null, null },
                    { new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"), "Tuy Loan, Hoa Vang, Cam Le, Da Nang", "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979443/jvjdj7mso2fzqlhsqtgt.png", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7036), new DateTime(2002, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "buivanhuy@gmail.com", true, false, false, true, "Huy Bui", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7063), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0905415721", null, null, 1, null, null },
                    { new Guid("9117c626-c3d0-4d14-b345-d70d85268623"), "124 Bui Giang, Hoa An, Cam Le, Da Nang", "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979661/zslqmoxwlm5n6vjnbd6k.png", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6885), new DateTime(2002, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenquocthanh268@gmail.com", true, false, false, true, "Nguyen Quoc Thanh", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7031), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0905030133", null, null, 1, null, null },
                    { new Guid("9f12c430-de83-4910-92ac-704bffefaab2"), "517 Ton Duc Thang Street, Hoa Khanh Nam, Lien Chieu, Da Nang", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1680511603/df59eb21-3a29-4c7a-b762-d9bff4e4da9a/759f1e45-7879-41f2-a270-fd5f55c9fed5.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7283), new DateTime(1961, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.johnson@gmail.com", true, false, false, true, "Dr. Emily Johnson", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7306), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0941448374", null, null, 2, "16.06452980000006", "108.15611821300007" },
                    { new Guid("b2d5a7d6-dab1-489a-8db5-2c9483a7d948"), "111 Thanh Thuy Street, Thanh Binh, Hai Chau, Da Nang", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1713341344/4857e326-b98c-45fa-8841-d99d1e9350f8/2e1df710-9cb1-4022-8a05-2631ee108f55.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7539), new DateTime(1969, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "oliver.white@gmail.com", true, false, false, true, "Dr. Oliver White", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7557), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0932476895", null, null, 2, "16.08356567900006", "108.21406614200004" },
                    { new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"), "Ngu Hanh Son, Da Nang", null, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7064), new DateTime(2002, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "anhoang@gmail.com", false, false, false, true, "Vo A Hoang", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7089), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0921843174", null, null, 1, null, null },
                    { new Guid("cf9b2f8e-59c9-4f09-8fa1-d624fd0d5bcb"), "21 Thai Van Lung Street, Hoa Xuan, Cam Le, Da Nang", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1525960591/8afad210-bc4f-4af0-9eb4-0ff5032c96a2/5d255b73-661f-4674-98e9-d0e24c83ba6d.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7576), new DateTime(1962, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "henry.walker@gmail.com", true, false, false, true, "Dr. Henry Walker", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7592), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0945381720", null, null, 2, "16.02039805800007", "108.22470250100008" },
                    { new Guid("d6a4c3e8-9111-4bc2-b0b9-e84b4dfb5d9e"), "2 Le Thanh Nghi Street, Hoa Cuong, Hai Chau, Da Nang", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1525963679/17b30593-83ec-47b5-b08f-744a3f019e81/e4b189ea-1bbb-40f1-b488-dc6e433d4b1d.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7610), new DateTime(1966, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.clark@gmail.com", true, false, false, true, "Dr. James Clark", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7627), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0941205864", null, null, 2, "16.0445465", "108.2177031" },
                    { new Guid("e4a0f9d1-f914-4d85-bfe1-1dc5c4507a6f"), "142 Trieu Nu Vuong Street, Hai Chau 2, Hai Chau, Da Nang", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1589829513/2f72c6b5-f53c-4473-bea5-47e7a5e60f83/309cba8b-3d9e-41aa-af75-0e8c6c4d28d3.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7521), new DateTime(1964, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice.morgan@gmail.com", false, false, false, true, "Dr. Alice Morgan", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7537), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0905863245", null, null, 2, "16.062915375000046", "108.21667342200004" },
                    { new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"), null, null, new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7647), null, "admin@gmail.com", null, false, false, true, "Admin", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7661), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, null, null, null, 3, null, null },
                    { new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"), "276 Dong Da Street, Thanh Binh, Hai Chau, Da Nang", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1680512033/48485db2-ab6e-4f98-93e1-504965cec010/3b9d9971-40bc-40de-bd43-7e1bb35c83dd.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7308), new DateTime(1963, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.brown@gmail.com", true, false, false, true, "Dr. Michael Brown", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7331), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0934778332", null, null, 2, "16.0765671", "108.2155694" },
                    { new Guid("efaaf180-4211-45d1-9b08-f085f19cb452"), "33 Cao Thang Street, Thanh Binh, Hai Chau, Da Nang", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1525960428/98dfc23b-c970-4342-b57d-08c386c43e5d/572fe2a8-64e1-4087-a018-3866079e6ff5.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7333), new DateTime(1975, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarah.davis@gmail.com", false, false, false, true, "Prof. Dr. Sarah Davis", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7355), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0929064778", null, null, 2, "16.07616593590908", "108.2142730839606" },
                    { new Guid("efaaf180-4211-45d1-9b08-f085f19cb453"), "96 Trieu Nu Vuong Street, Hai Chau 2, Hai Chau, Da Nang", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1680511470/c4fa22c5-790e-4f3f-8511-5b114670ed85/54e56361-e48d-43f7-8d3b-adbe1a59a36e.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7357), new DateTime(1967, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.wilson@gmail.com", true, false, false, true, "Prof. Dr. David Wilson", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7381), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0965597404", null, null, 2, "16.064064461000044", "108.21653123000004" },
                    { new Guid("efaaf180-4211-45d1-9b08-f085f19cb454"), "2 Le Thanh Nghi Street, Hoa Cuong, Hai Chau, Da Nang", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1618488149/d889bf94-d4c8-4a62-a1dc-35735256b1ce/8006a4f9-e47a-454f-bcba-25e60e504dde.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7383), new DateTime(1968, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "laura.martinez@gmail.com", false, false, false, true, "Prof. Dr. Laura Martinez", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7407), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0961733270", null, null, 2, "16.0445465", "108.2177031" },
                    { new Guid("efaaf180-4211-45d1-9b08-f085f19cb455"), "64 Tran Cao Van Street, Tam Thuan, Thanh Khe, Da Nang", "https://res.cloudinary.com/doctena/image/upload/h_180,w_180,f_auto,c_thumb,g_face,z_0.7/v1610565267/c7b0c5f0-24e3-4f50-ae58-60893bf2a37a/6dd99135-5b0f-4d27-8508-1a1c23530e9b.png", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7409), new DateTime(1963, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "robert.taylor@gmail.com", true, false, false, true, "Assoc. Prof. Dr. Robert Taylor", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7456), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0906893161", null, null, 2, "16.072938523909848", "108.21087439696076" },
                    { new Guid("efaaf180-4211-45d1-9b08-f085f19cb456"), "82 Quang Trung Street, Thach Thang, Hai Chau, Da Nang", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1525960875/07700e7c-2f24-453f-be7e-0437edc6c3a2/ccee4ba3-2b9a-4f51-991d-8b9d76c5ac65.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7499), new DateTime(1962, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jessica.moore@gmail.com", false, false, false, true, "Assoc. Prof. Dr. Jessica Moore", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7519), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0923267870", null, null, 2, "16.074633395000035", "108.21884153500008" },
                    { new Guid("f76c3b89-8fcd-4e5f-abc1-39c13fb8a97d"), "95 Hai Phong Street, Thach Thang, Hai Chau, Da Nang", "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1597687679/ba815298-2ce2-456c-9710-822d7750f4de/02a1a5b5-b8b9-4648-8ed8-6996662d0724.jpg", new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7558), new DateTime(1965, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophie.harris@gmail.com", false, false, false, true, "Dr. Sophie Harris", new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7575), "123456", new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 }, "0928631974", null, null, 2, "16.071919252000043", "108.21535855300004" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_IdDoctor",
                table: "Appointments",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_IdUser",
                table: "Appointments",
                column: "IdUser");

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
                name: "IX_MedicalRecords_IdDoctor",
                table: "MedicalRecords",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_IdUser",
                table: "MedicalRecords",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_IdDoctor",
                table: "Ratings",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_IdUser",
                table: "Ratings",
                column: "IdUser");

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
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "Ratings");

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
