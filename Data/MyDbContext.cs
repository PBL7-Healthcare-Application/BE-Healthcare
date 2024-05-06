using BE_Healthcare.Constant;
using BE_Healthcare.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;

namespace BE_Healthcare.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region Dbset
        public DbSet<User> Users{ get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<MedicalSpecialty> MedicalSpecialties { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<TimeOff> TimeOffs { get; set; }
        public DbSet<TrainingProcess> TrainingProcesses { get; set; }
        public DbSet<WorkingProcess> WorkingProcesses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasOne<Doctor>(e => e.Doctor)
            .WithOne(u => u.User)
            .HasForeignKey<Doctor>(u => u.IdUser).IsRequired();

            //Add Sample Data
            #region Data Role
            modelBuilder.Entity<Role>().HasData(
                new Role {IdRole = 1, Name = "User" },
                new Role {IdRole = 2, Name = "Doctor" },
                new Role {IdRole = 3, Name = "Admin" }
                );
            #endregion

            #region Data MedicalSpecialty
            modelBuilder.Entity<MedicalSpecialty>().HasData(
                new MedicalSpecialty { IdSpecialty = 1, Name = "Internal Medicine" },
                new MedicalSpecialty { IdSpecialty = 2, Name = "General Surgery" },
                new MedicalSpecialty { IdSpecialty = 3, Name = "Obstetrics and Gynecology" },
                new MedicalSpecialty { IdSpecialty = 4, Name = "Pediatrics" },
                new MedicalSpecialty { IdSpecialty = 5, Name = "Emergency Medicine" },
                new MedicalSpecialty { IdSpecialty = 6, Name = "Dermatology" },
                new MedicalSpecialty { IdSpecialty = 7, Name = "Dentistry" },
                new MedicalSpecialty { IdSpecialty = 8, Name = "Plastic Surgery" },
                new MedicalSpecialty { IdSpecialty = 9, Name = "Nuclear Medicine" },
                new MedicalSpecialty { IdSpecialty = 10, Name = "Cardiology" },
                new MedicalSpecialty { IdSpecialty = 11, Name = "Pulmonology" },
                new MedicalSpecialty { IdSpecialty = 12, Name = "Gastroenterology" },
                new MedicalSpecialty { IdSpecialty = 13, Name = "Hematology" },
                new MedicalSpecialty { IdSpecialty = 14, Name = "Endocrinology" },
                new MedicalSpecialty { IdSpecialty = 15, Name = "Public Health" },
                new MedicalSpecialty { IdSpecialty = 16, Name = "Preventive Medicine" },
                new MedicalSpecialty { IdSpecialty = 17, Name = "Psychiatry" },
                new MedicalSpecialty { IdSpecialty = 18, Name = "Traditional Medicine" }
                );
            #endregion

            #region Data User

            using var hashFunc = new HMACSHA256();
            string password_sample = "String@123";
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    IdUser = Guid.Parse("9117c626-c3d0-4d14-b345-d70d85268623"),
                    Email = "nguyenquocthanh268@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Nguyen Quoc Thanh",
                    OTPVerification = "123456",
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 1      //User
                },
                new User
                {
                    IdUser = Guid.Parse("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                    Email = "buivanhuy@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Huy Bui",
                    OTPVerification = "123456",
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 1      //User
                },
                new User
                {
                    IdUser = Guid.Parse("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                    Email = "anhoang@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Vo A Hoang",
                    OTPVerification = "123456",
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 1      //User
                },
                new User
                {
                    IdUser = Guid.Parse("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                    Email = "doctor1@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "BS.CKII Trần Thị Hoài Hương",
                    OTPVerification = "123456",
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      //Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("9f12c430-de83-4910-92ac-704bffefaab2"),
                    Email = "doctor2@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "TS.BS Vũ Thái Hà",
                    OTPVerification = "123456",
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      //Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb451"),
                    Email = "doctor3@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "TS.BS Trần Thịnh",
                    OTPVerification = "123456",
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      //Doctor
                }
                );
            #endregion

            #region Data Doctor
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    YearExperience = 5,
                    Price = 500000,
                    IdSpecialty = 7,
                    IdUser = Guid.Parse("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "17:00",
                    DurationPerAppointment = 1,
                    Description = "Bác sĩ Chuyên khoa I Trần Thị Hoài Hương nguyên là Phó Trưởng khoa Lâm sàng" +
                    " 1 tại Bệnh viện Da liễu TP.HCM.\r\n\r\nVề chuyên môn, bác sĩ chuyên thăm khám và điều trị các" +
                    " vấn đề bệnh lý chuyên sâu về da, bệnh da ở trẻ cũng như các phương pháp thẩm mỹ da liễu." +
                    "\r\n\r\n\r\nBác sĩ cũng là gương mặt quen thuộc trong những hội nghị hội thảo về Da liễu. " +
                    "Với nền tảng chuyên môn hơn 20 năm, bác sĩ còn được biết đến với thái độ tận tình tận tâm, " +
                    "luôn sẵn sàng tư vấn hỗ trợ bệnh nhân các vấn đề bệnh lý cũng như trao đổi về các liệu pháp " +
                    "thẩm mỹ hiệu quả phù hợp.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Phòng khám bác sĩ Hương"
                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("954d0f01-a006-443a-957d-3d1165b79ee7"),
                    YearExperience = 8,
                    Price = 600000,
                    IdSpecialty = 5,
                    IdUser = Guid.Parse("9f12c430-de83-4910-92ac-704bffefaab2"),
                    WorkingTimeStart = "07:00",
                    WorkingTimeEnd = "17:00",
                    DurationPerAppointment = 1,
                    Description = "Tiến sĩ - Bác sĩ Vũ Thái Hà có gần 20 năm kinh nghiệm trong việc tư vấn và điều trị" +
                    " các vấn đề về da liễu như nám, mụn, lão hóa da,…\r\n\r\nVề quá trình đào tạo, bác sĩ tốt nghiệp " +
                    "Bác sĩ nội trú Da liễu, tốt nghiệp bậc Thạc sĩ tại trường Đại học Y Hà Nội. Sau đó, bác sĩ có khoảng" +
                    " thời gian thực tập tại Pháp về phương pháp điều trị các bệnh về da liễu, bệnh về tóc, bệnh về móng." +
                    "\r\n\r\n\r\nBác sĩ hiện đang đảm nhận vai trò Trưởng khoa Nghiên cứu và Ứng dụng công nghệ tế bào gốc" +
                    " tại Bệnh viện Da liễu Trung Ương. Bên cạnh đó, bác sĩ cũng là người phụ trách chuyên môn tại Phòng" +
                    " khám Da liễu Thái Hà.\r\n\r\nVới nền tảng chuyên môn cực kỳ vững chắc, bác sĩ chuyên thăm khám và " +
                    "điều trị các vấn đề bệnh lý liên quan đến da: viêm da cơ địa, viêm da tiếp xúc, viêm da dầu, thủy" +
                    " đậu, nám da, nám da,...Bên cạnh đó, bác sĩ cũng nhận tư vấn các vấn đề về sẹo, vấn đề về mụn, tình" +
                    " trạng lão hóa da, bớt sắc tố.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Phòng khám Bác sĩ Thái Hà"

                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                    YearExperience = 7,
                    Price = 400000,
                    IdSpecialty = 1,
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb451"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "18:00",
                    DurationPerAppointment = 1,
                    Description = "Tiến sĩ - Bác sĩ Trần Thịnh có gần 40 năm kinh nghiệm thăm khám và điều trị các vấn đề Da liễu." +
                    " Tiến sĩ nguyên là Trưởng khoa Da liễu - Bệnh viện Da liễu TP.HCM và hiện đang là người điều hành phòng khám" +
                    " Chuyên khoa Da liễu Trần Thịnh.\r\n\r\nVề quá trình đào tạo, tiến sĩ tốt nghiệp chuyên ngành Da liễu tại " +
                    "trường Đại học Y Dược TP. HCM. Sau khi tốt nghiệp, tiến sĩ được giữ lại trường và đảm nhiệm vai trò bác sĩ, " +
                    "cán bộ phòng Khoa học kỹ thuật khoa Y. Đến năm 2009, dù đã là người dày dặn kinh nghiệm trong ngành, bác sĩ " +
                    "tiếp tục dành thời gian học thêm chuyên ngành về Quản lý Y tế tại trường Đại học Y Dược.\r\n\r\n\r\nNgoài " +
                    "cương vị bác sĩ, giai đoạn từ năm 1991 - 1999, tiến sĩ còn đảm đương nhiều vai trò quan trọng tại bệnh viện " +
                    "Da liễu. Trong đó có việc tham gia phụ trách chương trình kiểm soát bệnh lây qua tình dục và AIDS tại TP.HCM" +
                    " cũng như đóng góp vào quá trình đào tạo nguồn lực kế cận với vai trò giảng viên tại các trường đại học." +
                    "\r\n\r\nNăm 2010, tiến sĩ Trần Thịnh đã nhận được bằng khen từ Bộ trưởng Bộ Y tế về những thành tựu có " +
                    "được. Xuyên suốt quá trình sự nghiệp, tiến sĩ được biết đến là một trong những chuyên gia vững về trình độ" +
                    " chuyên môn, tận tâm tận tình trong quá trình thăm khám.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Phòng khám bác sĩ Thịnh"


                }
                );
            #endregion

            #region Data TimeOff
            modelBuilder.Entity<TimeOff>().HasData(
                new TimeOff
                {
                    IdTimeOff = 1,
                    Date = new DateTime(2024, 5, 1),
                    StartTime = "08:00",
                    EndTime = "10:00",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    Status = 1,  //1 -> Busy; 2->Break
                    Reason = "Busy with family"
                },
                new TimeOff
                {
                    IdTimeOff = 2,
                    Date = new DateTime(2024, 5, 2),
                    StartTime = "15:00",
                    EndTime = "16:00",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    Status = 1,  //1 -> Busy; 2->Break
                    Reason = "Busy with family"
                },
                new TimeOff
                {
                    IdTimeOff = 3,
                    Date = new DateTime(2024, 5, 2),
                    StartTime = "11:00",
                    EndTime = "13:00",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    Status = 2,  //1 -> Busy; 2->Break
                },
                new TimeOff
                {
                    IdTimeOff = 4,
                    Date = new DateTime(2024, 5, 4),
                    StartTime = "13:00",
                    EndTime = "15:00",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    Status = 1,  //1 -> Busy; 2->Break
                    Reason = "Busy with family"

                }
                );
            #endregion

            #region Data Certificate
            modelBuilder.Entity<Certificate>().HasData(
                new Certificate
                {
                    IdCertificate = 1,
                    Name = "Hội viên chi hội Da liễu Hồ Chí Minh",
                    Year = 2020,
                    Image = "https://hellobacsi.com/care/bac-si/bsckii-tran-thi-hoai-huong-646/",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED

                },
                new Certificate
                {
                    IdCertificate = 2,
                    Name = "Hội viên Hội Da liễu Việt Nam",
                    Year = 2022,
                    Image = "https://hellobacsi.com/care/bac-si/bsckii-tran-thi-hoai-huong-646/",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED

                }
                );
            #endregion

            #region Data TrainingProcess
            modelBuilder.Entity<TrainingProcess>().HasData(
                new TrainingProcess
                {
                    IdTrainingProcess = 1,
                    SchoolName = "Đại học Y Dược TP.HCM",
                    Major = "Tốt nghiệp Bác sĩ Chuyên khoa II, chuyên ngành Da liễu",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 2,
                    SchoolName = "Đại học Y Dược TP.HCM",
                    Major = "Tốt nghiệp Bác sĩ Chuyên khoa I, chuyên ngành Da liễu",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 3,
                    SchoolName = "Đại học Y Dược TP.HCM",
                    Major = "Tốt nghiệp Bác sĩ Đa khoa",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED
                },
                new TrainingProcess
                {
                    IdTrainingProcess = 4,
                    SchoolName = "Đại học Y khoa Phạm Ngọc Thạch",
                    Major = "Tham gia lớp Sơ bộ DInh dưỡng",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED
                }
                );
            #endregion

            #region Data WorkingProcess
            modelBuilder.Entity<WorkingProcess>().HasData(
                new WorkingProcess
                {
                    IdWorkingProcess = 1,
                    Position = "Bác sĩ Da liễu",
                    StartYear = 2012,
                    EndYear = 2014,
                    Workplace = "Phòng khám Da liễu Táo Đỏ",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED
                },
                new WorkingProcess
                {
                    IdWorkingProcess = 2,
                    Position = "Nguyên Phó Trưởng khoa Lâm sàng 1",
                    StartYear = 2012,
                    EndYear = 2014,
                    Workplace = "Bệnh viện Da liễu TP. HCM",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED
                },
                new WorkingProcess
                {
                    IdWorkingProcess = 3,
                    Position = "Trưởng Khoa Dinh Dưỡng",
                    StartYear = 2012,
                    EndYear = 2014,
                    Workplace = "Bệnh viện Da liễu TP. HCM",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED
                },
                new WorkingProcess
                {
                    IdWorkingProcess = 4,
                    Position = "Bác sĩ chuyên khoa da liễu, thẩm mỹ da",
                    StartYear = 2012,
                    EndYear = 2014,
                    Workplace = "Bệnh viện Da liễu TP. HCM",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED
                }
                );
            #endregion

            #region Data Appointment

            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    IdAppointment = 5,
                    StartTime = "10:00",
                    EndTime = "11:00",
                    Date = new DateTime(2024, 5, 4),
                    Issue = "Tôi đang gặp phải vấn đề về da liễu, tôi cần bác sĩ kiểm tra và tư vấn giúp tôi.",
                    Status = 1,
                    Type = false,
                    IdUser = Guid.Parse("9117c626-c3d0-4d14-b345-d70d85268623"),
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2")
                },
                new Appointment
                {
                    IdAppointment = 6,
                    StartTime = "9:00",
                    EndTime = "10:00",
                    Date = new DateTime(2024, 5, 4),
                    Issue = "Tôi đang gặp phải vấn đề về ruột thừa, tôi cần bác sĩ kiểm tra và tư vấn giúp tôi.",
                    Status = 1,
                    Type = false,
                    IdUser = Guid.Parse("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2")
                },
                new Appointment
                {
                    IdAppointment = 7,
                    StartTime = "15:00",
                    EndTime = "16:00",
                    Date = new DateTime(2024, 5, 4),
                    Issue = "Toi bi dau bung",
                    Status = 1,
                    Type = false,
                    IdUser = Guid.Parse("9117c626-c3d0-4d14-b345-d70d85268623"),
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2")
                },
                new Appointment
                {
                    IdAppointment = 8,
                    StartTime = "16:00",
                    EndTime = "17:00",
                    Date = new DateTime(2024, 5, 4),
                    Issue = "Toi bi dau bung non",
                    Status = 1,
                    Type = false,
                    IdUser = Guid.Parse("9117c626-c3d0-4d14-b345-d70d85268623"),
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2")
                },
                new Appointment
                {
                    IdAppointment = 9,
                    StartTime = "8:00",
                    EndTime = "9:00",
                    Date = new DateTime(2024, 5, 4),
                    Issue = "Toi bi dau bung non",
                    Status = 1,
                    Type = false,
                    IdUser = Guid.Parse("9117c626-c3d0-4d14-b345-d70d85268623"),
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2")
                }
                );

            #endregion
        }
    }
}
