using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Collect_Data_v3__Certificate_WorkingProcess_TrainingProcess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "IdAppointment", "CreatedAt", "Date", "EndTime", "IdDoctor", "IdUser", "IsRating", "Issue", "Price", "Reason", "StartTime", "StartTimeOfExamination", "Status", "Type", "UpdatedAt", "idDoctorCancel", "idUserCancel" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6698), new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "16:00", new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), new Guid("9117c626-c3d0-4d14-b345-d70d85268623"), false, "My face has freckles", 500000.0, "I have family matters so I can't come for a check-up", "15:00", null, 2, false, null, null, new Guid("9117c626-c3d0-4d14-b345-d70d85268623") },
                    { 2, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6713), new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "16:00", new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), new Guid("9117c626-c3d0-4d14-b345-d70d85268623"), false, "My face has freckles", 500000.0, null, "15:00", null, 3, false, null, null, null },
                    { 3, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6718), new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "10:00", new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"), true, "My face has many pimples.", 500000.0, null, "09:00", null, 3, false, null, null, null },
                    { 4, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6722), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "10:00", new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"), true, "I need my wisdom teeth removed.", 500000.0, null, "9:00", null, 3, false, null, null, null },
                    { 5, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6726), new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "10:00", new Guid("2536a049-6c0d-45fc-a0d6-ea107731c986"), new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"), true, "My face has many pimples.", 350000.0, null, "09:00", null, 3, false, null, null, null },
                    { 6, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6731), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "11:00", new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), new Guid("9117c626-c3d0-4d14-b345-d70d85268623"), false, "My tooth is swollen and hurts a lot.", 400000.0, null, "10:00", null, 1, false, null, null, null },
                    { 7, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6735), new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "10:00", new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"), false, "I need my wisdom teeth removed.", 400000.0, null, "9:00", null, 1, false, null, null, null },
                    { 8, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6739), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "10:00", new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), new Guid("6ba4b5ec-1ad8-4676-8871-122749af64e4"), false, "I need my wisdom teeth removed.", 500000.0, null, "9:00", null, 1, false, null, null, null },
                    { 9, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6743), new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "09:00", new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), new Guid("5ba4b5ec-1ad8-4676-8871-122749af64e4"), false, "My wisdom teeth have some problems.", 500000.0, null, "08:00", null, 4, false, null, null, null },
                    { 10, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6747), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "14:00", new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), new Guid("3ba4b5ec-1ad8-4676-8871-122749af64e4"), false, "I need my wisdom teeth removed.", 500000.0, null, "13:00", null, 4, false, null, null, null },
                    { 11, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6776), new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "15:00", new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), new Guid("4ba4b5ec-1ad8-4676-8871-122749af64e4"), false, "I need my wisdom teeth removed.", 500000.0, null, "14:00", null, 4, false, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "IdCertificate", "CreatedAt", "IdDoctor", "Image", "Name", "StatusVerified", "UpdatedAt", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6361), new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 2, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6363), new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 3, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6368), new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 4, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6371), new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 5, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6373), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 6, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6376), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 7, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6379), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c984"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 8, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6382), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c984"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 9, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6384), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 10, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6387), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 11, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6390), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c986"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 12, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6392), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c986"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 13, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6395), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c987"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 14, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6398), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c987"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 15, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6400), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c988"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 16, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6404), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c988"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 17, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6407), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c989"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 18, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6410), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c989"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 19, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6412), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c990"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 20, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6415), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c990"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 21, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6417), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c991"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 22, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6420), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c991"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 23, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6422), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c992"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 24, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6425), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c992"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 25, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6428), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c993"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 26, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6430), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c993"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 27, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6433), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c994"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 28, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6435), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c994"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 29, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6437), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c995"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png", "Was awarded the title of Professor", 1, null, 1991 },
                    { 30, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6439), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c995"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png", "Medical Practice License", 1, null, 1990 },
                    { 31, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6366), new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070466/lxlatebu64hmwutdth6b.png", "recognized the title of Associate Professor of Medicine", 0, null, 2000 },
                    { 32, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6355), new Guid("2536a049-6c0d-45fc-a0d6-ea107731c996"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070466/lxlatebu64hmwutdth6b.png", "Was awarded the title of Professor", 0, null, 1991 }
                });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6180), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c984"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6186), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6191), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c986"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6197), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c987"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6204), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c988"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6208), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c989"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6213), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c990"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6282), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c991"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6289), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c992"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6294), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c993"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6299), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c994"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6305), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c995"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6310), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c996"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6153), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6173), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "IdRating", "Comment", "CreatedAt", "IdAppointment", "IdDoctor", "IdUser", "RatingScore" },
                values: new object[,]
                {
                    { 1, "The quality of examination service is very good.", new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6806), 3, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"), 5 },
                    { 2, "The doctor is very enthusiastic.", new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6813), 4, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"), 4 },
                    { 3, "Good service.", new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6816), 5, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c986"), new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"), 3 },
                    { 4, "Good service.", new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6820), 98, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), new Guid("1ba4b5ec-1ad8-4676-8871-122749af64e4"), 4 },
                    { 5, "Good service.", new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6823), 98, new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"), new Guid("2ba4b5ec-1ad8-4676-8871-122749af64e4"), 2 },
                    { 6, "Good service.", new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6826), 98, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"), new Guid("3ba4b5ec-1ad8-4676-8871-122749af64e4"), 5 },
                    { 7, "The doctor is very enthusiastic.", new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6829), 4, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), new Guid("5ba4b5ec-1ad8-4676-8871-122749af64e4"), 4 },
                    { 8, "The doctor is very enthusiastic.", new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6832), 4, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), new Guid("6ba4b5ec-1ad8-4676-8871-122749af64e4"), 3 },
                    { 9, "The doctor is very enthusiastic.", new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6834), 4, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), new Guid("7ba4b5ec-1ad8-4676-8871-122749af64e4"), 5 }
                });

            migrationBuilder.InsertData(
                table: "TrainingProcesses",
                columns: new[] { "IdTrainingProcess", "CreatedAt", "EndYear", "IdDoctor", "Major", "SchoolName", "StartYear", "StatusVerified", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6472), 1989, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 2, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6485), 1990, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 3, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6488), 1989, new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 4, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6492), 1990, new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 5, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6494), 1989, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 6, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6497), 1990, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 7, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6499), 1989, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c984"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 8, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6502), 1990, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c984"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 9, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6505), 1989, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 10, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6533), 1990, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 11, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6536), 1989, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c986"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 12, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6539), 1990, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c986"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 13, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6542), 1989, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c987"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 14, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6545), 1990, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c987"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 15, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6548), 1989, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c988"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 16, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6550), 1990, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c988"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 17, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6554), 1989, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c989"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 18, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6557), 1990, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c989"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 19, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6560), 1989, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c990"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 20, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6562), 1990, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c990"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 21, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6565), 1989, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c991"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 22, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6568), 1990, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c991"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 23, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6571), 1989, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c992"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 24, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6574), 1990, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c992"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 25, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6576), 1989, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c993"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 26, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6579), 1990, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c993"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 27, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6582), 1989, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c994"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 28, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6585), 1990, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c994"), "Intern", "Internship in the United States", 1989, 1, null },
                    { 29, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6587), 1989, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c995"), "Specialist Doctor Graduation", "University of Medicine and Pharmacy at Ho Chi Minh City", 1983, 1, null },
                    { 30, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6591), 1990, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c995"), "Intern", "Internship in the United States", 1989, 1, null }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("1ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5680), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5695), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("1f2b4a9d-793e-4c89-9fdf-3d1e684d816f"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6070), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6085), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("2ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5696), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5712), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("3ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5713), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5729), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("4a9dc58e-282a-4f92-9b0d-bb1a707c3f7b"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6038), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6053), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("4ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5730), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5745), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("5ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5746), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5762), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5763), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5778), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5796), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5812), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("7ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5779), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5795), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5643), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5662), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5530), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5641), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5813), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5829), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("b2d5a7d6-dab1-489a-8db5-2c9483a7d948"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5985), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6002), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5663), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5679), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("cf9b2f8e-59c9-4f09-8fa1-d624fd0d5bcb"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6021), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6037), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("d6a4c3e8-9111-4bc2-b0b9-e84b4dfb5d9e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6054), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6069), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("e4a0f9d1-f914-4d85-bfe1-1dc5c4507a6f"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5968), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5984), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6086), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6100), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5845), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb452"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5846), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5865), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb453"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5866), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5898), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb454"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5915), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5934), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb455"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5935), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5950), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb456"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(5952), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(5967), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("f76c3b89-8fcd-4e5f-abc1-39c13fb8a97d"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6003), new DateTime(2024, 6, 23, 10, 10, 1, 459, DateTimeKind.Utc).AddTicks(6020), new byte[] { 18, 219, 226, 69, 202, 150, 251, 245, 196, 219, 172, 76, 5, 14, 84, 245, 134, 180, 216, 23, 0, 6, 191, 84, 118, 53, 29, 118, 152, 32, 194, 222 }, new byte[] { 172, 87, 142, 93, 41, 118, 164, 164, 121, 227, 151, 124, 9, 12, 183, 93, 168, 205, 156, 87, 237, 35, 213, 237, 160, 235, 121, 138, 195, 93, 93, 224, 6, 34, 213, 100, 221, 161, 134, 111, 54, 236, 1, 237, 98, 162, 89, 241, 31, 135, 225, 11, 214, 134, 35, 230, 224, 67, 104, 34, 26, 121, 71, 82 } });

            migrationBuilder.InsertData(
                table: "WorkingProcesses",
                columns: new[] { "IdWorkingProcess", "CreatedAt", "EndYear", "IdDoctor", "Position", "StartYear", "StatusVerified", "UpdatedAt", "Workplace" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6625), 2014, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Senior lecturer", 2012, 1, null, "Hanoi Medical University" },
                    { 2, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6636), 2018, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Deputy Head of the Department of Internal Medicine, Faculty of Medicine.", 2014, 1, null, "Ho Chi Minh City National University" },
                    { 3, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6639), 2021, new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "Chairman of the Medical Advisory Board, Attending Physician", 2018, 1, null, "Multispecialty Clinic" },
                    { 4, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6642), 2014, new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"), "Senior lecturer", 2012, 1, null, "Hanoi Medical University" },
                    { 5, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6644), 2018, new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"), "Deputy Head of the Department of Internal Medicine, Faculty of Medicine.", 2014, 1, null, "Ho Chi Minh City National University" },
                    { 6, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6647), 2021, new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"), "Chairman of the Medical Advisory Board, Attending Physician", 2018, 1, null, "Multispecialty Clinic" },
                    { 7, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6649), 2014, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"), "Senior lecturer", 2012, 1, null, "Hanoi Medical University" },
                    { 8, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6652), 2018, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"), "Deputy Head of the Department of Internal Medicine, Faculty of Medicine.", 2014, 1, null, "Ho Chi Minh City National University" },
                    { 9, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6655), 2021, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"), "Chairman of the Medical Advisory Board, Attending Physician", 2018, 1, null, "Multispecialty Clinic" },
                    { 10, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6658), 2014, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c984"), "Senior lecturer", 2012, 1, null, "Hanoi Medical University" },
                    { 11, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6661), 2018, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c984"), "Deputy Head of the Department of Internal Medicine, Faculty of Medicine.", 2014, 1, null, "Ho Chi Minh City National University" },
                    { 12, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6663), 2021, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c984"), "Chairman of the Medical Advisory Board, Attending Physician", 2018, 1, null, "Multispecialty Clinic" },
                    { 13, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6666), 2014, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), "Senior lecturer", 2012, 1, null, "Hanoi Medical University" },
                    { 14, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6669), 2018, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), "Deputy Head of the Department of Internal Medicine, Faculty of Medicine.", 2014, 1, null, "Ho Chi Minh City National University" },
                    { 15, new DateTime(2024, 6, 23, 17, 10, 1, 459, DateTimeKind.Local).AddTicks(6671), 2021, new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), "Chairman of the Medical Advisory Board, Attending Physician", 2018, 1, null, "Multispecialty Clinic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "IdCertificate",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "IdRating",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "IdRating",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "IdRating",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "IdRating",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "IdRating",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "IdRating",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "IdRating",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "IdRating",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "IdRating",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TrainingProcesses",
                keyColumn: "IdTrainingProcess",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WorkingProcesses",
                keyColumn: "IdWorkingProcess",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8351), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c984"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8356), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8361), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c986"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8365), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c987"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8371), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c988"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8378), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c989"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8382), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c990"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8387), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c991"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8393), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c992"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8398), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c993"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8403), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c994"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8409), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c995"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8413), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c996"),
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8331), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                columns: new[] { "CreatedAt", "IsVerifiedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8344), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("1ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7899), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(7913), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("1f2b4a9d-793e-4c89-9fdf-3d1e684d816f"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8254), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8268), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("2ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7914), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(7928), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("3ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7929), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(7943), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("4a9dc58e-282a-4f92-9b0d-bb1a707c3f7b"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8224), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8238), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("4ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7944), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(7959), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("5ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7960), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(7974), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7975), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(7992), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8008), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8023), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("7ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7993), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8007), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7864), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(7882), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(7862), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8024), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8039), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("b2d5a7d6-dab1-489a-8db5-2c9483a7d948"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8177), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8193), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(7884), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(7898), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("cf9b2f8e-59c9-4f09-8fa1-d624fd0d5bcb"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8209), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8223), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("d6a4c3e8-9111-4bc2-b0b9-e84b4dfb5d9e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8253), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("e4a0f9d1-f914-4d85-bfe1-1dc5c4507a6f"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8133), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8176), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8269), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8282), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8040), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8055), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb452"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8056), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8071), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb453"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8072), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8086), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb454"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8087), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8101), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb455"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8102), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8116), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb456"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8118), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8132), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("f76c3b89-8fcd-4e5f-abc1-39c13fb8a97d"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8194), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8208), new byte[] { 52, 149, 109, 229, 174, 12, 215, 176, 90, 243, 120, 193, 84, 37, 119, 248, 159, 235, 8, 137, 43, 81, 219, 192, 186, 249, 42, 11, 246, 82, 27, 82 }, new byte[] { 138, 198, 6, 31, 245, 4, 244, 52, 157, 212, 22, 114, 54, 75, 246, 73, 126, 78, 67, 245, 220, 147, 109, 72, 150, 34, 67, 254, 27, 11, 214, 6, 96, 130, 231, 53, 173, 32, 248, 253, 134, 103, 38, 91, 100, 222, 16, 9, 24, 109, 200, 31, 17, 109, 61, 217, 76, 84, 213, 98, 178, 96, 182, 216 } });
        }
    }
}
