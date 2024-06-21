using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Doctors",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Appointments",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "IdAppointment", "Date", "EndTime", "IdDoctor", "IdUser", "Issue", "StartTime", "Status", "Type" },
                values: new object[,]
                {
                    { 5, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "11:00", new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), new Guid("9117c626-c3d0-4d14-b345-d70d85268623"), "Tôi đang gặp phải vấn đề về da liễu, tôi cần bác sĩ kiểm tra và tư vấn giúp tôi.", "10:00", 1, false },
                    { 6, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "11:00", new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"), "Tôi đang gặp phải vấn đề về ruột thừa, tôi cần bác sĩ kiểm tra và tư vấn giúp tôi.", "10:00", 1, false }
                });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                column: "Description",
                value: "Tiến sĩ - Bác sĩ Trần Thịnh có gần 40 năm kinh nghiệm thăm khám và điều trị các vấn đề Da liễu. Tiến sĩ nguyên là Trưởng khoa Da liễu - Bệnh viện Da liễu TP.HCM và hiện đang là người điều hành phòng khám Chuyên khoa Da liễu Trần Thịnh.\r\n\r\nVề quá trình đào tạo, tiến sĩ tốt nghiệp chuyên ngành Da liễu tại trường Đại học Y Dược TP. HCM. Sau khi tốt nghiệp, tiến sĩ được giữ lại trường và đảm nhiệm vai trò bác sĩ, cán bộ phòng Khoa học kỹ thuật khoa Y. Đến năm 2009, dù đã là người dày dặn kinh nghiệm trong ngành, bác sĩ tiếp tục dành thời gian học thêm chuyên ngành về Quản lý Y tế tại trường Đại học Y Dược.\r\n\r\n\r\nNgoài cương vị bác sĩ, giai đoạn từ năm 1991 - 1999, tiến sĩ còn đảm đương nhiều vai trò quan trọng tại bệnh viện Da liễu. Trong đó có việc tham gia phụ trách chương trình kiểm soát bệnh lây qua tình dục và AIDS tại TP.HCM cũng như đóng góp vào quá trình đào tạo nguồn lực kế cận với vai trò giảng viên tại các trường đại học.\r\n\r\nNăm 2010, tiến sĩ Trần Thịnh đã nhận được bằng khen từ Bộ trưởng Bộ Y tế về những thành tựu có được. Xuyên suốt quá trình sự nghiệp, tiến sĩ được biết đến là một trong những chuyên gia vững về trình độ chuyên môn, tận tâm tận tình trong quá trình thăm khám.");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                column: "Description",
                value: "Bác sĩ Chuyên khoa I Trần Thị Hoài Hương nguyên là Phó Trưởng khoa Lâm sàng 1 tại Bệnh viện Da liễu TP.HCM.\r\n\r\nVề chuyên môn, bác sĩ chuyên thăm khám và điều trị các vấn đề bệnh lý chuyên sâu về da, bệnh da ở trẻ cũng như các phương pháp thẩm mỹ da liễu.\r\n\r\n\r\nBác sĩ cũng là gương mặt quen thuộc trong những hội nghị hội thảo về Da liễu. Với nền tảng chuyên môn hơn 20 năm, bác sĩ còn được biết đến với thái độ tận tình tận tâm, luôn sẵn sàng tư vấn hỗ trợ bệnh nhân các vấn đề bệnh lý cũng như trao đổi về các liệu pháp thẩm mỹ hiệu quả phù hợp.");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"),
                column: "Description",
                value: "Tiến sĩ - Bác sĩ Vũ Thái Hà có gần 20 năm kinh nghiệm trong việc tư vấn và điều trị các vấn đề về da liễu như nám, mụn, lão hóa da,…\r\n\r\nVề quá trình đào tạo, bác sĩ tốt nghiệp Bác sĩ nội trú Da liễu, tốt nghiệp bậc Thạc sĩ tại trường Đại học Y Hà Nội. Sau đó, bác sĩ có khoảng thời gian thực tập tại Pháp về phương pháp điều trị các bệnh về da liễu, bệnh về tóc, bệnh về móng.\r\n\r\n\r\nBác sĩ hiện đang đảm nhận vai trò Trưởng khoa Nghiên cứu và Ứng dụng công nghệ tế bào gốc tại Bệnh viện Da liễu Trung Ương. Bên cạnh đó, bác sĩ cũng là người phụ trách chuyên môn tại Phòng khám Da liễu Thái Hà.\r\n\r\nVới nền tảng chuyên môn cực kỳ vững chắc, bác sĩ chuyên thăm khám và điều trị các vấn đề bệnh lý liên quan đến da: viêm da cơ địa, viêm da tiếp xúc, viêm da dầu, thủy đậu, nám da, nám da,...Bên cạnh đó, bác sĩ cũng nhận tư vấn các vấn đề về sẹo, vấn đề về mụn, tình trạng lão hóa da, bớt sắc tố.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 5, 6, 44, 342, DateTimeKind.Utc).AddTicks(2405), new byte[] { 245, 230, 32, 12, 4, 99, 148, 231, 35, 18, 184, 80, 196, 201, 211, 148, 66, 219, 211, 201, 148, 11, 71, 78, 76, 141, 239, 246, 0, 228, 80, 38 }, new byte[] { 241, 119, 99, 178, 158, 218, 70, 215, 99, 39, 9, 152, 175, 30, 7, 252, 40, 23, 214, 175, 71, 25, 28, 208, 22, 180, 109, 253, 142, 161, 164, 152, 79, 218, 99, 214, 153, 204, 31, 162, 34, 179, 110, 125, 55, 150, 253, 44, 222, 160, 39, 115, 67, 4, 189, 209, 223, 180, 101, 145, 103, 250, 125, 66 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 5, 6, 44, 342, DateTimeKind.Utc).AddTicks(2364), new byte[] { 245, 230, 32, 12, 4, 99, 148, 231, 35, 18, 184, 80, 196, 201, 211, 148, 66, 219, 211, 201, 148, 11, 71, 78, 76, 141, 239, 246, 0, 228, 80, 38 }, new byte[] { 241, 119, 99, 178, 158, 218, 70, 215, 99, 39, 9, 152, 175, 30, 7, 252, 40, 23, 214, 175, 71, 25, 28, 208, 22, 180, 109, 253, 142, 161, 164, 152, 79, 218, 99, 214, 153, 204, 31, 162, 34, 179, 110, 125, 55, 150, 253, 44, 222, 160, 39, 115, 67, 4, 189, 209, 223, 180, 101, 145, 103, 250, 125, 66 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 5, 6, 44, 342, DateTimeKind.Utc).AddTicks(2335), new byte[] { 245, 230, 32, 12, 4, 99, 148, 231, 35, 18, 184, 80, 196, 201, 211, 148, 66, 219, 211, 201, 148, 11, 71, 78, 76, 141, 239, 246, 0, 228, 80, 38 }, new byte[] { 241, 119, 99, 178, 158, 218, 70, 215, 99, 39, 9, 152, 175, 30, 7, 252, 40, 23, 214, 175, 71, 25, 28, 208, 22, 180, 109, 253, 142, 161, 164, 152, 79, 218, 99, 214, 153, 204, 31, 162, 34, 179, 110, 125, 55, 150, 253, 44, 222, 160, 39, 115, 67, 4, 189, 209, 223, 180, 101, 145, 103, 250, 125, 66 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 5, 6, 44, 342, DateTimeKind.Utc).AddTicks(2423), new byte[] { 245, 230, 32, 12, 4, 99, 148, 231, 35, 18, 184, 80, 196, 201, 211, 148, 66, 219, 211, 201, 148, 11, 71, 78, 76, 141, 239, 246, 0, 228, 80, 38 }, new byte[] { 241, 119, 99, 178, 158, 218, 70, 215, 99, 39, 9, 152, 175, 30, 7, 252, 40, 23, 214, 175, 71, 25, 28, 208, 22, 180, 109, 253, 142, 161, 164, 152, 79, 218, 99, 214, 153, 204, 31, 162, 34, 179, 110, 125, 55, 150, 253, 44, 222, 160, 39, 115, 67, 4, 189, 209, 223, 180, 101, 145, 103, 250, 125, 66 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 5, 6, 44, 342, DateTimeKind.Utc).AddTicks(2387), new byte[] { 245, 230, 32, 12, 4, 99, 148, 231, 35, 18, 184, 80, 196, 201, 211, 148, 66, 219, 211, 201, 148, 11, 71, 78, 76, 141, 239, 246, 0, 228, 80, 38 }, new byte[] { 241, 119, 99, 178, 158, 218, 70, 215, 99, 39, 9, 152, 175, 30, 7, 252, 40, 23, 214, 175, 71, 25, 28, 208, 22, 180, 109, 253, 142, 161, 164, 152, 79, 218, 99, 214, 153, 204, 31, 162, 34, 179, 110, 125, 55, 150, 253, 44, 222, 160, 39, 115, 67, 4, 189, 209, 223, 180, 101, 145, 103, 250, 125, 66 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 5, 6, 44, 342, DateTimeKind.Utc).AddTicks(2440), new byte[] { 245, 230, 32, 12, 4, 99, 148, 231, 35, 18, 184, 80, 196, 201, 211, 148, 66, 219, 211, 201, 148, 11, 71, 78, 76, 141, 239, 246, 0, 228, 80, 38 }, new byte[] { 241, 119, 99, 178, 158, 218, 70, 215, 99, 39, 9, 152, 175, 30, 7, 252, 40, 23, 214, 175, 71, 25, 28, 208, 22, 180, 109, 253, 142, 161, 164, 152, 79, 218, 99, 214, 153, 204, 31, 162, 34, 179, 110, 125, 55, 150, 253, 44, 222, 160, 39, 115, 67, 4, 189, 209, 223, 180, 101, 145, 103, 250, 125, 66 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "IdAppointment",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Doctors");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Appointments",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 48, 10, 691, DateTimeKind.Utc).AddTicks(6510), new byte[] { 241, 227, 31, 179, 113, 112, 111, 69, 119, 153, 249, 8, 226, 95, 82, 150, 26, 90, 188, 81, 17, 209, 161, 36, 224, 240, 19, 194, 53, 157, 114, 155 }, new byte[] { 96, 238, 82, 115, 10, 18, 234, 74, 63, 6, 90, 228, 33, 154, 6, 15, 41, 205, 75, 246, 56, 171, 227, 116, 254, 193, 241, 108, 175, 35, 179, 35, 122, 60, 56, 142, 216, 7, 124, 222, 159, 76, 136, 104, 122, 21, 122, 126, 142, 4, 103, 74, 196, 20, 25, 200, 183, 107, 45, 213, 166, 114, 198, 38 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 48, 10, 691, DateTimeKind.Utc).AddTicks(6487), new byte[] { 241, 227, 31, 179, 113, 112, 111, 69, 119, 153, 249, 8, 226, 95, 82, 150, 26, 90, 188, 81, 17, 209, 161, 36, 224, 240, 19, 194, 53, 157, 114, 155 }, new byte[] { 96, 238, 82, 115, 10, 18, 234, 74, 63, 6, 90, 228, 33, 154, 6, 15, 41, 205, 75, 246, 56, 171, 227, 116, 254, 193, 241, 108, 175, 35, 179, 35, 122, 60, 56, 142, 216, 7, 124, 222, 159, 76, 136, 104, 122, 21, 122, 126, 142, 4, 103, 74, 196, 20, 25, 200, 183, 107, 45, 213, 166, 114, 198, 38 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 48, 10, 691, DateTimeKind.Utc).AddTicks(6467), new byte[] { 241, 227, 31, 179, 113, 112, 111, 69, 119, 153, 249, 8, 226, 95, 82, 150, 26, 90, 188, 81, 17, 209, 161, 36, 224, 240, 19, 194, 53, 157, 114, 155 }, new byte[] { 96, 238, 82, 115, 10, 18, 234, 74, 63, 6, 90, 228, 33, 154, 6, 15, 41, 205, 75, 246, 56, 171, 227, 116, 254, 193, 241, 108, 175, 35, 179, 35, 122, 60, 56, 142, 216, 7, 124, 222, 159, 76, 136, 104, 122, 21, 122, 126, 142, 4, 103, 74, 196, 20, 25, 200, 183, 107, 45, 213, 166, 114, 198, 38 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 48, 10, 691, DateTimeKind.Utc).AddTicks(6521), new byte[] { 241, 227, 31, 179, 113, 112, 111, 69, 119, 153, 249, 8, 226, 95, 82, 150, 26, 90, 188, 81, 17, 209, 161, 36, 224, 240, 19, 194, 53, 157, 114, 155 }, new byte[] { 96, 238, 82, 115, 10, 18, 234, 74, 63, 6, 90, 228, 33, 154, 6, 15, 41, 205, 75, 246, 56, 171, 227, 116, 254, 193, 241, 108, 175, 35, 179, 35, 122, 60, 56, 142, 216, 7, 124, 222, 159, 76, 136, 104, 122, 21, 122, 126, 142, 4, 103, 74, 196, 20, 25, 200, 183, 107, 45, 213, 166, 114, 198, 38 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 48, 10, 691, DateTimeKind.Utc).AddTicks(6499), new byte[] { 241, 227, 31, 179, 113, 112, 111, 69, 119, 153, 249, 8, 226, 95, 82, 150, 26, 90, 188, 81, 17, 209, 161, 36, 224, 240, 19, 194, 53, 157, 114, 155 }, new byte[] { 96, 238, 82, 115, 10, 18, 234, 74, 63, 6, 90, 228, 33, 154, 6, 15, 41, 205, 75, 246, 56, 171, 227, 116, 254, 193, 241, 108, 175, 35, 179, 35, 122, 60, 56, 142, 216, 7, 124, 222, 159, 76, 136, 104, 122, 21, 122, 126, 142, 4, 103, 74, 196, 20, 25, 200, 183, 107, 45, 213, 166, 114, 198, 38 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 48, 10, 691, DateTimeKind.Utc).AddTicks(6533), new byte[] { 241, 227, 31, 179, 113, 112, 111, 69, 119, 153, 249, 8, 226, 95, 82, 150, 26, 90, 188, 81, 17, 209, 161, 36, 224, 240, 19, 194, 53, 157, 114, 155 }, new byte[] { 96, 238, 82, 115, 10, 18, 234, 74, 63, 6, 90, 228, 33, 154, 6, 15, 41, 205, 75, 246, 56, 171, 227, 116, 254, 193, 241, 108, 175, 35, 179, 35, 122, 60, 56, 142, 216, 7, 124, 222, 159, 76, 136, 104, 122, 21, 122, 126, 142, 4, 103, 74, 196, 20, 25, 200, 183, 107, 45, 213, 166, 114, 198, 38 } });
        }
    }
}
