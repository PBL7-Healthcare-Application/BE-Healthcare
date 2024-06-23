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
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<MedicalSpecialty> MedicalSpecialties { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<TimeOff> TimeOffs { get; set; }
        public DbSet<TrainingProcess> TrainingProcesses { get; set; }
        public DbSet<WorkingProcess> WorkingProcesses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }

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
                new Role { IdRole = 1, Name = "User" },
                new Role { IdRole = 2, Name = "Doctor" },
                new Role { IdRole = 3, Name = "Admin" }
                );
            #endregion

            #region Data MedicalSpecialty
            modelBuilder.Entity<MedicalSpecialty>().HasData(
                new MedicalSpecialty { IdSpecialty = 1, Name = "Internal Medicine", Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718981095/yzdx4mxo3nsso9fflv4l.webp" },
                new MedicalSpecialty { IdSpecialty = 2, Name = "General Surgery", Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718981242/codte5bzrbjlmhdboe18.webp" },
                new MedicalSpecialty { IdSpecialty = 3, Name = "Obstetrics and Gynecology", Image = "https://cdn-healthcare.hellohealthgroup.com/specialties/san-phu-khoa.png" },
                new MedicalSpecialty { IdSpecialty = 4, Name = "Pediatrics", Image = "https://cdn-healthcare.hellohealthgroup.com/specialties/nhi-khoa.png" },
                new MedicalSpecialty { IdSpecialty = 5, Name = "Emergency Medicine", Image = "https://res.cloudinary.com/dbtam9pnc/image/upload/v1713413379/Doctor/gigu9hqbvlrdth4y77pv.webp" },
                new MedicalSpecialty { IdSpecialty = 6, Name = "Dermatology", Image = "https://cdn-healthcare.hellohealthgroup.com/specialties/da-lieu.png" },
                new MedicalSpecialty { IdSpecialty = 7, Name = "Dentistry", Image = "https://cdn-healthcare.hellohealthgroup.com/specialties/nha-khoa.png" },
                new MedicalSpecialty { IdSpecialty = 8, Name = "Plastic Surgery", Image = "https://cdn-healthcare.hellohealthgroup.com/2022/03/1648190355_623d6393ac9b40.00770044.jpg" },
                new MedicalSpecialty { IdSpecialty = 10, Name = "Cardiology", Image = "https://cdn-healthcare.hellohealthgroup.com/specialties/tim-mach.png" },
                new MedicalSpecialty { IdSpecialty = 11, Name = "Pulmonology", Image = "https://cdn-healthcare.hellohealthgroup.com/specialties/khoa-phoi.png" },
                new MedicalSpecialty { IdSpecialty = 12, Name = "Gastroenterology", Image = "https://cdn-healthcare.hellohealthgroup.com/2022/03/1648192254_623d6afed218d0.32746408.jpg" },
                new MedicalSpecialty { IdSpecialty = 13, Name = "Hematology", Image = "https://cdn-healthcare.hellohealthgroup.com/specialties/huyet-hoc.png" },
                new MedicalSpecialty { IdSpecialty = 14, Name = "Endocrinology", Image = "https://cdn-healthcare.hellohealthgroup.com/specialties/khoa-noi-tiet.png" },
                new MedicalSpecialty { IdSpecialty = 15, Name = "Public Health", Image = "https://cdn-healthcare.hellohealthgroup.com/2022/03/1648192124_623d6a7cca01f2.62072083.jpg" },
                new MedicalSpecialty { IdSpecialty = 17, Name = "Psychiatry", Image = "https://cdn-healthcare.hellohealthgroup.com/2022/09/1663834655_632c1a1f872a42.63080420.jpg" },
                new MedicalSpecialty { IdSpecialty = 18, Name = "Traditional Medicine", Image = "https://cdn-healthcare.hellohealthgroup.com/2022/03/1648189960_623d6208833488.26923360.jpg" }
                );
            #endregion

            #region Data User

            using var hashFunc = new HMACSHA256();
            string password_sample = "String@123";
            string otp_sample = "123456";
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    IdUser = Guid.Parse("9117c626-c3d0-4d14-b345-d70d85268623"),
                    Email = "nguyenquocthanh268@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Nguyen Quoc Thanh",
                    DOB = new DateTime(2002, 08, 26),
                    Gender = true,
                    Address = "124 Bui Giang, Hoa An, Cam Le, Da Nang",
                    PhoneNumber = "0905030133",
                    Avatar = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979661/zslqmoxwlm5n6vjnbd6k.png",
                    OTPVerification = otp_sample,
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
                    Gender = true,
                    Address = "Tuy Loan, Hoa Vang, Cam Le, Da Nang",
                    PhoneNumber = "0905415721",
                    DOB = new DateTime(2002, 12, 12),
                    Avatar = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979443/jvjdj7mso2fzqlhsqtgt.png",
                    OTPVerification = otp_sample,
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
                    Gender = false,
                    Address = "Ngu Hanh Son, Da Nang",
                    PhoneNumber = "0921843174",
                    DOB = new DateTime(2002, 10, 11),

                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 1      //User
                },

                new User
                {
                    IdUser = Guid.Parse("1ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    Email = "john.doe@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "John Doe",
                    DOB = new DateTime(1990, 05, 15),
                    Gender = true,
                    Address = "45 Elm Street, Springfield, IL",
                    PhoneNumber = "0905001234",
                    Avatar = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719069524/v8hu3qi9f8soqsagswtn.jpg",
                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 1
                },
                new User
                {
                    IdUser = Guid.Parse("2ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    Email = "jane.smith@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Jane Smith",
                    DOB = new DateTime(1985, 03, 22),
                    Gender = false,
                    Address = "123 Maple Avenue, Anytown, TX",
                    PhoneNumber = "0905012345",
                    Avatar = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719069584/n1gpp4jdduagdkvdwkfq.jpg",
                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 1
                },
                new User
                {
                    IdUser = Guid.Parse("3ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    Email = "michael.jordan@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Michael Jordan",
                    DOB = new DateTime(1975, 11, 17),
                    Gender = true,
                    Address = "789 Oak Lane, Chicago, IL",
                    PhoneNumber = "0905023456",
                    Avatar = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719069658/uxi5cbd5ohtwtefwu2un.jpg",
                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 1
                },
                new User
                {
                    IdUser = Guid.Parse("4ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    Email = "emily.davis@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Emily Davis",
                    DOB = new DateTime(1995, 07, 30),
                    Gender = false,
                    Address = "456 Pine Street, Los Angeles, CA",
                    PhoneNumber = "0905034567",
                    Avatar = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719069721/gtzyqa4injuat46wbtsb.jpg",
                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 1
                },
                new User
                {
                    IdUser = Guid.Parse("5ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    Email = "robert.brown@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Robert Brown",
                    DOB = new DateTime(1980, 01, 05),
                    Gender = true,
                    Address = "321 Cedar Drive, Boston, MA",
                    PhoneNumber = "0905045678",
                    Avatar = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070149/ez0opee2spindl6qiypt.jpg",
                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 1
                },
                new User
                {
                    IdUser = Guid.Parse("6ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    Email = "lisa.wilson@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Lisa Wilson",
                    DOB = new DateTime(1992, 12, 12),
                    Gender = false,
                    Address = "654 Birch Avenue, Seattle, WA",
                    PhoneNumber = "0905056789",
                    Avatar = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070219/mfyvzdpu2tfyovqv6zk9.jpg",
                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 1
                },
                new User
                {
                    IdUser = Guid.Parse("7ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    Email = "david.clark@example.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "David Clark",
                    DOB = new DateTime(1988, 09, 20),
                    Gender = true,
                    Address = "987 Willow Lane, Miami, FL",
                    PhoneNumber = "0905067890",
                    Avatar = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070316/o1pmjoj2vu1jycmmb6ny.jpg",
                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 1
                },
                //================================================================================================================================
                new User
                {
                    IdUser = Guid.Parse("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                    Email = "john.smith@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Dr. John Smith",
                    DOB = new DateTime(1972, 7, 8),
                    PhoneNumber = "0900127848",
                    Address = "19 Nguyen Tuong Pho Street, Hoa Minh, Lien Chieu, Da Nang",
                    longtitude = "108.1745195",
                    latitude = "16.063627",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1680511237/2fb7ee0f-dfee-4579-a119-95bccd9bdea6/fa9d5fa9-2c93-428b-aee0-03f4ce064bd9.jpg",
                    Gender = true,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("9f12c430-de83-4910-92ac-704bffefaab2"),
                    Email = "emily.johnson@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Dr. Emily Johnson",
                    DOB = new DateTime(1961, 2, 3),
                    PhoneNumber = "0941448374",
                    Address = "517 Ton Duc Thang Street, Hoa Khanh Nam, Lien Chieu, Da Nang",
                    longtitude = "108.15611821300007",
                    latitude = "16.06452980000006",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1680511603/df59eb21-3a29-4c7a-b762-d9bff4e4da9a/759f1e45-7879-41f2-a270-fd5f55c9fed5.jpg",
                    Gender = true,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb451"),
                    Email = "michael.brown@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Dr. Michael Brown",
                    DOB = new DateTime(1963, 3, 14),
                    PhoneNumber = "0934778332",
                    Address = "276 Dong Da Street, Thanh Binh, Hai Chau, Da Nang",
                    longtitude = "108.2155694",
                    latitude = "16.0765671",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1680512033/48485db2-ab6e-4f98-93e1-504965cec010/3b9d9971-40bc-40de-bd43-7e1bb35c83dd.jpg",
                    Gender = true,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb452"),
                    Email = "sarah.davis@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Prof. Dr. Sarah Davis",
                    DOB = new DateTime(1975, 11, 19),
                    PhoneNumber = "0929064778",
                    Address = "33 Cao Thang Street, Thanh Binh, Hai Chau, Da Nang",
                    longtitude = "108.2142730839606",
                    latitude = "16.07616593590908",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1525960428/98dfc23b-c970-4342-b57d-08c386c43e5d/572fe2a8-64e1-4087-a018-3866079e6ff5.jpg",
                    Gender = false,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb453"),
                    Email = "david.wilson@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Prof. Dr. David Wilson",
                    DOB = new DateTime(1967, 9, 4),
                    PhoneNumber = "0965597404",
                    Address = "96 Trieu Nu Vuong Street, Hai Chau 2, Hai Chau, Da Nang",
                    longtitude = "108.21653123000004",
                    latitude = "16.064064461000044",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1680511470/c4fa22c5-790e-4f3f-8511-5b114670ed85/54e56361-e48d-43f7-8d3b-adbe1a59a36e.jpg",
                    Gender = true,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb454"),
                    Email = "laura.martinez@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Prof. Dr. Laura Martinez",
                    DOB = new DateTime(1968, 9, 14),
                    PhoneNumber = "0961733270",
                    Address = "2 Le Thanh Nghi Street, Hoa Cuong, Hai Chau, Da Nang",
                    longtitude = "108.2177031",
                    latitude = "16.0445465",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1618488149/d889bf94-d4c8-4a62-a1dc-35735256b1ce/8006a4f9-e47a-454f-bcba-25e60e504dde.jpg",
                    Gender = false,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb455"),
                    Email = "robert.taylor@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Assoc. Prof. Dr. Robert Taylor",
                    DOB = new DateTime(1963, 12, 30),
                    PhoneNumber = "0906893161",
                    Address = "64 Tran Cao Van Street, Tam Thuan, Thanh Khe, Da Nang",
                    longtitude = "108.21087439696076",
                    latitude = "16.072938523909848",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/h_180,w_180,f_auto,c_thumb,g_face,z_0.7/v1610565267/c7b0c5f0-24e3-4f50-ae58-60893bf2a37a/6dd99135-5b0f-4d27-8508-1a1c23530e9b.png",
                    Gender = true,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb456"),
                    Email = "jessica.moore@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Assoc. Prof. Dr. Jessica Moore",
                    DOB = new DateTime(1962, 7, 1),
                    PhoneNumber = "0923267870",
                    Address = "82 Quang Trung Street, Thach Thang, Hai Chau, Da Nang",
                    longtitude = "108.21884153500008",
                    latitude = "16.074633395000035",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1525960875/07700e7c-2f24-453f-be7e-0437edc6c3a2/ccee4ba3-2b9a-4f51-991d-8b9d76c5ac65.jpg",
                    Gender = false,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("e4a0f9d1-f914-4d85-bfe1-1dc5c4507a6f"),
                    Email = "alice.morgan@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Dr. Alice Morgan",
                    DOB = new DateTime(1964, 1, 15),
                    PhoneNumber = "0905863245",
                    Address = "142 Trieu Nu Vuong Street, Hai Chau 2, Hai Chau, Da Nang",
                    longtitude = "108.21667342200004",
                    latitude = "16.062915375000046",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1589829513/2f72c6b5-f53c-4473-bea5-47e7a5e60f83/309cba8b-3d9e-41aa-af75-0e8c6c4d28d3.jpg",
                    Gender = false,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("b2d5a7d6-dab1-489a-8db5-2c9483a7d948"),
                    Email = "oliver.white@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Dr. Oliver White",
                    DOB = new DateTime(1969, 5, 22),
                    PhoneNumber = "0932476895",
                    Address = "111 Thanh Thuy Street, Thanh Binh, Hai Chau, Da Nang",
                    longtitude = "108.21406614200004",
                    latitude = "16.08356567900006",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1713341344/4857e326-b98c-45fa-8841-d99d1e9350f8/2e1df710-9cb1-4022-8a05-2631ee108f55.jpg",
                    Gender = true,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("f76c3b89-8fcd-4e5f-abc1-39c13fb8a97d"),
                    Email = "sophie.harris@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Dr. Sophie Harris",
                    DOB = new DateTime(1965, 8, 30),
                    PhoneNumber = "0928631974",
                    Address = "95 Hai Phong Street, Thach Thang, Hai Chau, Da Nang",
                    longtitude = "108.21535855300004",
                    latitude = "16.071919252000043",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1597687679/ba815298-2ce2-456c-9710-822d7750f4de/02a1a5b5-b8b9-4648-8ed8-6996662d0724.jpg",
                    Gender = false,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("cf9b2f8e-59c9-4f09-8fa1-d624fd0d5bcb"),
                    Email = "henry.walker@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Dr. Henry Walker",
                    DOB = new DateTime(1962, 12, 9),
                    PhoneNumber = "0945381720",
                    Address = "21 Thai Van Lung Street, Hoa Xuan, Cam Le, Da Nang",
                    longtitude = "108.22470250100008",
                    latitude = "16.02039805800007",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1525960591/8afad210-bc4f-4af0-9eb4-0ff5032c96a2/5d255b73-661f-4674-98e9-d0e24c83ba6d.jpg",
                    Gender = true,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("4a9dc58e-282a-4f92-9b0d-bb1a707c3f7b"),
                    Email = "mia.robinson@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Dr. Mia Robinson",
                    DOB = new DateTime(1963, 4, 18),
                    PhoneNumber = "0936842197",
                    Address = "280 Nguyen Huu Tho Street, Khue Trung Ward, Cam Le District, Da Nang City",
                    longtitude = "108.2098811",
                    latitude = "16.0374192",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1540363288/412b2fae-1c1e-4923-952b-358d971977df/13f5a650-d939-45b5-a621-344f1144b004.jpg",
                    Gender = true,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("d6a4c3e8-9111-4bc2-b0b9-e84b4dfb5d9e"),
                    Email = "james.clark@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Dr. James Clark",
                    DOB = new DateTime(1966, 11, 3),
                    PhoneNumber = "0941205864",
                    Address = "2 Le Thanh Nghi Street, Hoa Cuong, Hai Chau, Da Nang",
                    longtitude = "108.2177031",
                    latitude = "16.0445465",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1525963679/17b30593-83ec-47b5-b08f-744a3f019e81/e4b189ea-1bbb-40f1-b488-dc6e433d4b1d.jpg",
                    Gender = true,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                new User
                {
                    IdUser = Guid.Parse("1f2b4a9d-793e-4c89-9fdf-3d1e684d816f"),
                    Email = "ava.thompson@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Dr. Ava Thompson",
                    DOB = new DateTime(1968, 10, 27),
                    PhoneNumber = "0931467082",
                    Address = "1081 Ngo Quyen Street, An Hai Bac, Son Tra, Da Nang",
                    longtitude = "108.2346953",
                    latitude = "16.0598485",
                    Avatar = "https://res.cloudinary.com/doctena/image/upload/c_thumb,f_auto,g_face,h_100,w_100,z_0.7/v1542460196/fab102d3-a80c-44cf-93fe-d2f03d104dfb/339ba259-2169-4ab8-b7c5-7c9c656ca099.jpg",
                    Gender = true,


                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 2      // Doctor
                },
                //================================================================================================================================
                new User
                {
                    IdUser = Guid.Parse("efaaf143-4211-45d1-9b08-f085f19caa56"),
                    Email = "admin@gmail.com",
                    PasswordHash = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(password_sample)),
                    PasswordSalt = hashFunc.Key,
                    Name = "Admin",
                    OTPVerification = otp_sample,
                    OTPCreatedAt = DateTime.UtcNow,
                    IsVerified = true,
                    idRole = 3      //Admin
                }
                );

            #endregion

            #region Data Doctor
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    YearExperience = 22,
                    Price = 400000,
                    IdSpecialty = 7,
                    IdUser = Guid.Parse("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "17:00",
                    DurationPerAppointment = 60,
                    Description = "Dr. John Smith is a seasoned Dentistry specialist with a wealth of experience in oral health care. " +
                    "Formerly the Deputy Head of Clinical Department at a prominent dentistry Hospital in Ho Chi Minh City, Dr. Smith is " +
                    "renowned for his expertise in diagnosing and treating complex dental conditions, particularly in pediatric dentistry and" +
                    " various cosmetic dentistry procedures.\n\nDr. Smith is a familiar face at dentistry conferences and seminars, contributing " +
                    "significantly to the field with over 20 years of professional experience. Known for his compassionate and dedicated approach, he" +
                    " is always available to advise and support patients on their medical concerns tailored to individual needs",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. John Smith Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979241/gmdzkgdzwsdzvhawwn9a.png",
                    IsVerifiedAt = DateTime.UtcNow,
                    NumberOfComment = 1,
                    RateAverage = 4,
                    IsVerifiedInfoCertificate = false

                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("954d0f01-a006-443a-957d-3d1165b79ee7"),
                    YearExperience = 18,
                    Price = 500000,
                    IdSpecialty = 5,
                    IdUser = Guid.Parse("9f12c430-de83-4910-92ac-704bffefaab2"),
                    WorkingTimeStart = "07:00",
                    WorkingTimeEnd = "17:00",
                    DurationPerAppointment = 60,
                    Description = "Emily Johnson, M.D. is a graduate of De La Salle Medical & Health Sciences Institute, Doctor of Medicine." +
                    " He had his Pediatric residency training at De La Salle University Medical Center. During his residency training, he wrote " +
                    "an award-winning case report and research. He also became the department`s Chief Resident. Dr. Macapinlac is now a General Pediatrician" +
                    " and the doctor behind “Pedia On-The-Go” Facebook page",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. John Smith Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979279/d5cf4lohbymvfftgopmo.webp",
                    IsVerifiedAt = DateTime.UtcNow,
                    NumberOfComment = 1,
                    RateAverage = 2

                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                    YearExperience = 20,
                    Price = 400000,
                    IdSpecialty = 1,
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb451"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "18:00",
                    DurationPerAppointment = 60,
                    Description = "Dr. Michael Brown has always been fascinated by technology involved in radiotherapy. After graduating from the University " +
                    "of the Philippines Manila, he spent his internship at the Philippine General Hospital, where he was recognized as the most outstanding intern" +
                    " in orthopedics and outstanding intern in neurosurgery. He then moved to four years of residency training in one of the Philippines` biggest " +
                    "hospitals, the Makati Medical Center. After residency, he served as Chief Resident of Radiation Oncology for a year before heading to Davao " +
                    "Doctors Hospital.He currently is a Philippine Medical Association Member, fellow of the Philippine College of Radiology Member, and diplomate " +
                    "of the Philippine Radiation Oncology Society.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. Michael Brown Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979325/gyr3max086lrfcy8ej7u.webp",
                    IsVerifiedAt = DateTime.UtcNow,
                    NumberOfComment = 1,
                    RateAverage = 5

                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c984"),
                    YearExperience = 15,
                    Price = 350000,
                    IdSpecialty = 10,
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb452"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "18:00",
                    DurationPerAppointment = 60,
                    Description = "Sarah Davis earned her Doctor of Medicine and Master in Business Administration (MD-MBA) double degree and her Bachelor of Science" +
                    " in Health Sciences degree from the Ateneo de Manila University where she currently serves as a professor for global health and health policy.She " +
                    "leads both Alaga Health Inc. and Experto PlayLabs International Consultancy Inc. as Chief Operating Officer.  As a research consultant, she has" +
                    " previously worked with Health Care Without Harm - Asia, Mark Johnston Hospital, Global Center for Good Governance in Tobacco Control, Epimetrics, " +
                    "the Ateneo Center for Health Evidence, Action & Leadership (A-HEALS), the Department of Health (DOH), United States Agency for International Development" +
                    " (USAID), and the University of the Philippines",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. Sarah Davis Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979241/gmdzkgdzwsdzvhawwn9a.png",
                    IsVerifiedAt = DateTime.UtcNow,

                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    YearExperience = 32,
                    Price = 500000,
                    IdSpecialty = 6,
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb453"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "18:00",
                    DurationPerAppointment = 60,
                    Description = "David Wilson was formerly Chief Medical Officer, Calamba Medical Center, serving from Jan 2018 to 2022. She`s also the founding board " +
                    "member of the Philippine Infectious Diseases Society of Obstetrics and Gynecology. She earned her post-doctoral Fellowship on HIV/OB-GYN Infections " +
                    "from The Miriam Hospital-Brown University, Providence RI under the Fogarty Grant Training (NIH) scholarship. She graduated with a medical degree from " +
                    "the UP College of Medicine and completed her residency training in Obstetrics and Gynecology at the Philippine General Hospital (UP-PGH). She also " +
                    "completed her MBA in Health at the Ateneo Graduate School of Business.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. David Wilson Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979279/d5cf4lohbymvfftgopmo.webp",
                    IsVerifiedAt = DateTime.UtcNow,
                    NumberOfComment = 5,
                    RateAverage = 4.2

                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c986"),
                    YearExperience = 23,
                    Price = 350000,
                    IdSpecialty = 6,
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb454"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "18:00",
                    DurationPerAppointment = 60,
                    Description = "Laura Martinez graduated with a Bachelor of Science degree in Human Biology and obtained her medical degree from the De La Salle Health " +
                    "Sciences Institute. She is currently taking up her residency training as an Internal Medicine doctor at the Chinese General Hospital and Medical Center.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. Laura Martinez Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979325/gyr3max086lrfcy8ej7u.webp",
                    IsVerifiedAt = DateTime.UtcNow,
                    NumberOfComment = 1,
                    RateAverage = 3
                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c987"),
                    YearExperience = 27,
                    Price = 400000,
                    IdSpecialty = 6,
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb455"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "18:00",
                    DurationPerAppointment = 60,
                    Description = "Robert Taylor is a graduate of the University of the Philippines College of Medicine. He completed his residency training in Internal " +
                    "Medicine at the Philippine General Hospital. He is a diplomate of the Philippine College of Physicians and a fellow of the Philippine Society of " +
                    "Endocrinology, Diabetes, and Metabolism. He is currently a consultant at the Makati Medical Center and the Asian Hospital and Medical Center. He is " +
                    "also a faculty member of the Ateneo School of Medicine and Public Health. He is a member of the Philippine Medical Association, the Philippine Society " +
                    "of Endocrinology, Diabetes, and Metabolism, and the American Association of Clinical Endocrinologists. He is also a member of the Philippine Society of " +
                    "General Internal Medicine and the Philippine Society of Parenteral and Enteral Nutrition",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. Robert Taylor Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979241/gmdzkgdzwsdzvhawwn9a.png",
                    IsVerifiedAt = DateTime.UtcNow,

                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c988"),
                    YearExperience = 26,
                    Price = 450000,
                    IdSpecialty = 6,
                    IdUser = Guid.Parse("efaaf180-4211-45d1-9b08-f085f19cb456"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "18:00",
                    DurationPerAppointment = 60,
                    Description = "Jessica Moore graduated from the University of Sto. Tomas with a degree in Doctor of Medicine. For her undergraduate studies, she pursued BS " +
                    "in Psychology at the same university. he is currently a diplomate of the Philippine Heart Association and a fellow of the Philippine College of Physicians.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. Jessica Moore Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979279/d5cf4lohbymvfftgopmo.webp",
                    IsVerifiedAt = DateTime.UtcNow,

                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c989"),
                    YearExperience = 24,
                    Price = 4000000,
                    IdSpecialty = 6,
                    IdUser = Guid.Parse("e4a0f9d1-f914-4d85-bfe1-1dc5c4507a6f"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "17:00",
                    DurationPerAppointment = 60,
                    Description = "Dr. Alice Morgan has always been fascinated by advancements in dermatological technology. After graduating from the University of the Philippines " +
                    "Manila, she completed her internship at the Philippine General Hospital, where she was recognized as the most outstanding intern in dermatology and outstanding " +
                    "intern in internal medicine. She then pursued four years of residency training at one of the Philippines` largest hospitals, the Makati Medical Center. After her " +
                    "residency, she served as Chief Resident of Dermatology for a year before joining Davao Doctors Hospital. She is currently a member of the Philippine Medical " +
                    "Association, a fellow of the Philippine Dermatological Society, and a diplomate of the Philippine Board of Dermatology.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. Alice Morgan Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979325/gyr3max086lrfcy8ej7u.webp",
                    IsVerifiedAt = DateTime.UtcNow,

                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c990"),
                    YearExperience = 29,
                    Price = 3500000,
                    IdSpecialty = 1,
                    IdUser = Guid.Parse("b2d5a7d6-dab1-489a-8db5-2c9483a7d948"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "17:00",
                    DurationPerAppointment = 60,
                    Description = "Dr. Oliver White was formerly Chief Medical Officer at Calamba Medical Center, serving from January 2018 to 2022. He is also a founding board " +
                    "member of the Philippine Society of Internal Medicine. He earned his post-doctoral Fellowship in Infectious Diseases from The Miriam Hospital-Brown University, " +
                    "Providence RI, under the Fogarty Grant Training (NIH) scholarship. He graduated with a medical degree from the UP College of Medicine and completed his residency " +
                    "training in Internal Medicine at the Philippine General Hospital (UP-PGH). He also completed his MBA in Health at the Ateneo Graduate School of Business.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. Oliver White Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979241/gmdzkgdzwsdzvhawwn9a.png",
                    IsVerifiedAt = DateTime.UtcNow,

                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c991"),
                    YearExperience = 20,
                    Price = 3000000,
                    IdSpecialty = 6,
                    IdUser = Guid.Parse("f76c3b89-8fcd-4e5f-abc1-39c13fb8a97d"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "17:00",
                    DurationPerAppointment = 60,
                    Description = "Dr. Sophie Harris graduated with a Bachelor of Science degree in Human Biology and obtained her medical degree from the De La Salle Health Sciences" +
                    " Institute. She is currently taking up her residency training as a Dermatology doctor at the Chinese General Hospital and Medical Center.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. Sophie Harris Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979279/d5cf4lohbymvfftgopmo.webp",
                    IsVerifiedAt = DateTime.UtcNow,

                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c992"),
                    YearExperience = 19,
                    Price = 3000000,
                    IdSpecialty = 4,
                    IdUser = Guid.Parse("cf9b2f8e-59c9-4f09-8fa1-d624fd0d5bcb"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "17:00",
                    DurationPerAppointment = 60,
                    Description = "Dr. Henry Walker is a graduate of the University of the Philippines College of Medicine. He completed his residency training in Pediatrics at " +
                    "the Philippine General Hospital. He is a diplomate of the Philippine Pediatric Society and a fellow of the Philippine Society of Pediatric Gastroenterology, " +
                    "Hepatology, and Nutrition. He is currently a consultant at the Makati Medical Center and the Asian Hospital and Medical Center. He is also a faculty member of " +
                    "the Ateneo School of Medicine and Public Health. He is a member of the Philippine Medical Association, the Philippine Pediatric Society, and the American Academy " +
                    "of Pediatrics. He is also a member of the Philippine Society of Pediatric Gastroenterology, Hepatology, and Nutrition and the Philippine Society of Newborn Medicine.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. Henry Walker Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979325/gyr3max086lrfcy8ej7u.webp",
                    IsVerifiedAt = DateTime.UtcNow,

                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c993"),
                    YearExperience = 21,
                    Price = 3400000,
                    IdSpecialty = 10,
                    IdUser = Guid.Parse("4a9dc58e-282a-4f92-9b0d-bb1a707c3f7b"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "17:00",
                    DurationPerAppointment = 60,
                    Description = "Dr. Mia Robinson graduated from the University of Sto. Tomas with a Doctor of Medicine degree. For her undergraduate studies, she pursued a BS in " +
                    "Psychology at the same university. She is currently a diplomate of the Philippine Heart Association and a fellow of the Philippine College of Physicians.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. Mia Robinson Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979241/gmdzkgdzwsdzvhawwn9a.png",
                    IsVerifiedAt = DateTime.UtcNow,

                },
                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c994"),
                    YearExperience = 27,
                    Price = 400000,
                    IdSpecialty = 2,
                    IdUser = Guid.Parse("d6a4c3e8-9111-4bc2-b0b9-e84b4dfb5d9e"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "17:00",
                    DurationPerAppointment = 60,
                    Description = "Dr. James Clark, M.D., is a graduate of De La Salle Medical & Health Sciences Institute with a Doctor of Medicine degree. He completed his " +
                    "residency training in General Surgery at De La Salle University Medical Center. During his residency training, he wrote an award-winning case report and " +
                    "research. He also served as the department`s Chief Resident. Dr. Clark is now a General Surgeon and the doctor behind the “Surgery On-The-Go” Facebook page.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. James Clark Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979279/d5cf4lohbymvfftgopmo.webp",
                    IsVerifiedAt = DateTime.UtcNow,
                },

                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c995"),
                    YearExperience = 33,
                    Price = 500000,
                    IdSpecialty = 10,
                    IdUser = Guid.Parse("1f2b4a9d-793e-4c89-9fdf-3d1e684d816f"),
                    WorkingTimeStart = "08:00",
                    WorkingTimeEnd = "17:00",
                    DurationPerAppointment = 60,
                    Description = "Dr. Ava Thompson has always been fascinated by advancements in cardiovascular technology. After graduating from the University of the Philippines " +
                    "Manila, she spent her internship at the Philippine General Hospital, where she was recognized as the most outstanding intern in cardiology and outstanding intern " +
                    "in internal medicine. She then moved to four years of residency training in one of the Philippines` biggest hospitals, the Makati Medical Center. After residency, " +
                    "she served as Chief Resident of Cardiology for a year before heading to Davao Doctors Hospital. She is currently a member of the Philippine Medical Association, a " +
                    "fellow of the Philippine College of Physicians, and a diplomate of the Philippine Heart Association.",
                    StatusVerified = AppNumber.APPROVED,
                    NameClinic = "Dr. Ava Thompson Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979325/gyr3max086lrfcy8ej7u.webp",
                    IsVerifiedAt = DateTime.UtcNow,

                },


                new Doctor
                {
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c996"),
                    YearExperience = null,
                    Price = null,
                    IdSpecialty = 10,
                    IdUser = Guid.Parse("1ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    WorkingTimeStart = null,
                    WorkingTimeEnd = null,
                    DurationPerAppointment = null,
                    Description = null,
                    StatusVerified = AppNumber.PENDING,
                    NameClinic = "Dr. John Doe Clinic",
                    BusinessLicense = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979325/gyr3max086lrfcy8ej7u.webp",
                    IsVerifiedAt = null,
                    IsVerifiedInfoCertificate = false,
                }
                );
            #endregion

            #region Data TimeOff
            // modelBuilder.Entity<TimeOff>().HasData(
            //     new TimeOff
            //     {
            //         IdTimeOff = 1,
            //         Date = new DateTime(2024, 5, 1),
            //         StartTime = "08:00",
            //         EndTime = "10:00",
            //         IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
            //         Status = 1,  //1 -> Busy; 2->Break
            //         Reason = "Busy with family"
            //     },
            //     new TimeOff
            //     {
            //         IdTimeOff = 2,
            //         Date = new DateTime(2024, 5, 2),
            //         StartTime = "15:00",
            //         EndTime = "16:00",
            //         IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
            //         Status = 1,  //1 -> Busy; 2->Break
            //         Reason = "Busy with family"
            //     },
            //     new TimeOff
            //     {
            //         IdTimeOff = 3,
            //         Date = new DateTime(2024, 5, 2),
            //         StartTime = "11:00",
            //         EndTime = "13:00",
            //         IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
            //         Status = 2,  //1 -> Busy; 2->Break
            //     },
            //     new TimeOff
            //     {
            //         IdTimeOff = 4,
            //         Date = new DateTime(2024, 5, 4),
            //         StartTime = "13:00",
            //         EndTime = "15:00",
            //         IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
            //         Status = 1,  //1 -> Busy; 2->Break
            //         Reason = "Busy with family"

            //     }
            //     );
            #endregion

            #region Data Certificate
            modelBuilder.Entity<Certificate>().HasData(
                new Certificate
                {
                    IdCertificate = 32,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070466/lxlatebu64hmwutdth6b.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c996"),
                    StatusVerified = AppNumber.PENDING
                },
                new Certificate
                {
                    IdCertificate = 1,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 2,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 31,
                    Name = "recognized the title of Associate Professor of Medicine",
                    Year = 2000,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070466/lxlatebu64hmwutdth6b.png",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.PENDING
                },

                new Certificate
                {
                    IdCertificate = 3,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("954d0f01-a006-443a-957d-3d1165b79ee7"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 4,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("954d0f01-a006-443a-957d-3d1165b79ee7"),
                    StatusVerified = AppNumber.APPROVED
                },

                new Certificate
                {
                    IdCertificate = 5,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 6,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                    StatusVerified = AppNumber.APPROVED
                },

                new Certificate
                {
                    IdCertificate = 7,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c984"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 8,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c984"),
                    StatusVerified = AppNumber.APPROVED
                },

                new Certificate
                {
                    IdCertificate = 9,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 10,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    StatusVerified = AppNumber.APPROVED
                },

                new Certificate
                {
                    IdCertificate = 11,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c986"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 12,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c986"),
                    StatusVerified = AppNumber.APPROVED
                },

                new Certificate
                {
                    IdCertificate = 13,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c987"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 14,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c987"),
                    StatusVerified = AppNumber.APPROVED
                },

                new Certificate
                {
                    IdCertificate = 15,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c988"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 16,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c988"),
                    StatusVerified = AppNumber.APPROVED
                },

                new Certificate
                {
                    IdCertificate = 17,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c989"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 18,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c989"),
                    StatusVerified = AppNumber.APPROVED
                },

                new Certificate
                {
                    IdCertificate = 19,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c990"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 20,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c990"),
                    StatusVerified = AppNumber.APPROVED
                },

                new Certificate
                {
                    IdCertificate = 21,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c991"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 22,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c991"),
                    StatusVerified = AppNumber.APPROVED
                },

                new Certificate
                {
                    IdCertificate = 23,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c992"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 24,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c992"),
                    StatusVerified = AppNumber.APPROVED
                },

                new Certificate
                {
                    IdCertificate = 25,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c993"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 26,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c993"),
                    StatusVerified = AppNumber.APPROVED
                },

                new Certificate
                {
                    IdCertificate = 27,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c994"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 28,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c994"),
                    StatusVerified = AppNumber.APPROVED
                },

                new Certificate
                {
                    IdCertificate = 29,
                    Name = "Was awarded the title of Professor",
                    Year = 1991,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070512/f2ntd2nq4nlbesvsvc17.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c995"),
                    StatusVerified = AppNumber.APPROVED
                },
                new Certificate
                {
                    IdCertificate = 30,
                    Name = "Medical Practice License",
                    Year = 1990,
                    Image = "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1719070549/memekjg2ebtn91gxsib2.png",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c995"),
                    StatusVerified = AppNumber.APPROVED
                }
                );
            #endregion

            #region Data TrainingProcess
            modelBuilder.Entity<TrainingProcess>().HasData(
                new TrainingProcess
                {
                    IdTrainingProcess = 1,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 2,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 3,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("954d0f01-a006-443a-957d-3d1165b79ee7"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 4,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("954d0f01-a006-443a-957d-3d1165b79ee7"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 5,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 6,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 7,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c984"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 8,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c984"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 9,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 10,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 11,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c986"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 12,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c986"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 13,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c987"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 14,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c987"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 15,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c988"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 16,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c988"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 17,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c989"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 18,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c989"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 19,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c990"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 20,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c990"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 21,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c991"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 22,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c991"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 23,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c992"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 24,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c992"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 25,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c993"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 26,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c993"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 27,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c994"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 28,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c994"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                },

                new TrainingProcess
                {
                    IdTrainingProcess = 29,
                    SchoolName = "University of Medicine and Pharmacy at Ho Chi Minh City",
                    Major = "Specialist Doctor Graduation",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c995"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1983,
                    EndYear = 1989,

                },
                new TrainingProcess
                {
                    IdTrainingProcess = 30,
                    SchoolName = "Internship in the United States",
                    Major = "Intern",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c995"),
                    StatusVerified = AppNumber.APPROVED,
                    StartYear = 1989,
                    EndYear = 1990,

                });

            #endregion

            #region Data WorkingProcess
            modelBuilder.Entity<WorkingProcess>().HasData(
                new WorkingProcess
                {
                    IdWorkingProcess = 1,
                    Position = "Senior lecturer",
                    StartYear = 2012,
                    EndYear = 2014,
                    Workplace = "Hanoi Medical University",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED
                },
                new WorkingProcess
                {
                    IdWorkingProcess = 2,
                    Position = "Deputy Head of the Department of Internal Medicine, Faculty of Medicine.",
                    StartYear = 2014,
                    EndYear = 2018,
                    Workplace = "Ho Chi Minh City National University",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED
                },
                new WorkingProcess
                {
                    IdWorkingProcess = 3,
                    Position = "Chairman of the Medical Advisory Board, Attending Physician",
                    StartYear = 2018,
                    EndYear = 2021,
                    Workplace = "Multispecialty Clinic",
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    StatusVerified = AppNumber.APPROVED
                },

                new WorkingProcess
                {
                    IdWorkingProcess = 4,
                    Position = "Senior lecturer",
                    StartYear = 2012,
                    EndYear = 2014,
                    Workplace = "Hanoi Medical University",
                    IdDoctor = Guid.Parse("954d0f01-a006-443a-957d-3d1165b79ee7"),
                    StatusVerified = AppNumber.APPROVED
                },
                new WorkingProcess
                {
                    IdWorkingProcess = 5,
                    Position = "Deputy Head of the Department of Internal Medicine, Faculty of Medicine.",
                    StartYear = 2014,
                    EndYear = 2018,
                    Workplace = "Ho Chi Minh City National University",
                    IdDoctor = Guid.Parse("954d0f01-a006-443a-957d-3d1165b79ee7"),
                    StatusVerified = AppNumber.APPROVED
                },
                new WorkingProcess
                {
                    IdWorkingProcess = 6,
                    Position = "Chairman of the Medical Advisory Board, Attending Physician",
                    StartYear = 2018,
                    EndYear = 2021,
                    Workplace = "Multispecialty Clinic",
                    IdDoctor = Guid.Parse("954d0f01-a006-443a-957d-3d1165b79ee7"),
                    StatusVerified = AppNumber.APPROVED
                },

                new WorkingProcess
                {
                    IdWorkingProcess = 7,
                    Position = "Senior lecturer",
                    StartYear = 2012,
                    EndYear = 2014,
                    Workplace = "Hanoi Medical University",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                    StatusVerified = AppNumber.APPROVED
                },
                new WorkingProcess
                {
                    IdWorkingProcess = 8,
                    Position = "Deputy Head of the Department of Internal Medicine, Faculty of Medicine.",
                    StartYear = 2014,
                    EndYear = 2018,
                    Workplace = "Ho Chi Minh City National University",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                    StatusVerified = AppNumber.APPROVED
                },
                new WorkingProcess
                {
                    IdWorkingProcess = 9,
                    Position = "Chairman of the Medical Advisory Board, Attending Physician",
                    StartYear = 2018,
                    EndYear = 2021,
                    Workplace = "Multispecialty Clinic",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                    StatusVerified = AppNumber.APPROVED
                },

                new WorkingProcess
                {
                    IdWorkingProcess = 10,
                    Position = "Senior lecturer",
                    StartYear = 2012,
                    EndYear = 2014,
                    Workplace = "Hanoi Medical University",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c984"),
                    StatusVerified = AppNumber.APPROVED
                },
                new WorkingProcess
                {
                    IdWorkingProcess = 11,
                    Position = "Deputy Head of the Department of Internal Medicine, Faculty of Medicine.",
                    StartYear = 2014,
                    EndYear = 2018,
                    Workplace = "Ho Chi Minh City National University",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c984"),
                    StatusVerified = AppNumber.APPROVED
                },
                new WorkingProcess
                {
                    IdWorkingProcess = 12,
                    Position = "Chairman of the Medical Advisory Board, Attending Physician",
                    StartYear = 2018,
                    EndYear = 2021,
                    Workplace = "Multispecialty Clinic",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c984"),
                    StatusVerified = AppNumber.APPROVED
                },

                new WorkingProcess
                {
                    IdWorkingProcess = 13,
                    Position = "Senior lecturer",
                    StartYear = 2012,
                    EndYear = 2014,
                    Workplace = "Hanoi Medical University",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    StatusVerified = AppNumber.APPROVED
                },
                new WorkingProcess
                {
                    IdWorkingProcess = 14,
                    Position = "Deputy Head of the Department of Internal Medicine, Faculty of Medicine.",
                    StartYear = 2014,
                    EndYear = 2018,
                    Workplace = "Ho Chi Minh City National University",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    StatusVerified = AppNumber.APPROVED
                },
                new WorkingProcess
                {
                    IdWorkingProcess = 15,
                    Position = "Chairman of the Medical Advisory Board, Attending Physician",
                    StartYear = 2018,
                    EndYear = 2021,
                    Workplace = "Multispecialty Clinic",
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    StatusVerified = AppNumber.APPROVED
                }

                );
            #endregion

            #region Data Appointment

            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    IdAppointment = 1,
                    StartTime = "15:00",
                    EndTime = "16:00",
                    Date = new DateTime(2024, 6, 15),
                    Issue = "My face has freckles",
                    Status = AppNumber.APPOINTMENT_CANCELED,
                    Type = false,
                    IdUser = Guid.Parse("9117c626-c3d0-4d14-b345-d70d85268623"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    IsRating = false,
                    Price = 500000,
                    Reason = "I have family matters so I can't come for a check-up",
                    idUserCancel = Guid.Parse("9117c626-c3d0-4d14-b345-d70d85268623"),

                },
                new Appointment
                {
                    IdAppointment = 2,
                    StartTime = "15:00",
                    EndTime = "16:00",
                    Date = new DateTime(2024, 6, 16),
                    Issue = "My face has freckles",
                    Status = AppNumber.APPOINTMENT_COMPLETED,
                    Type = false,
                    IdUser = Guid.Parse("9117c626-c3d0-4d14-b345-d70d85268623"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    IsRating = false,
                    Price = 500000,

                },
                new Appointment
                {
                    IdAppointment = 3,
                    StartTime = "09:00",
                    EndTime = "10:00",
                    Date = new DateTime(2024, 6, 20),
                    Issue = "My face has many pimples.",
                    Status = AppNumber.APPOINTMENT_COMPLETED,
                    Type = false,
                    IdUser = Guid.Parse("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    IsRating = true,
                    Price = 500000,

                },
                new Appointment
                {
                    IdAppointment = 4,
                    StartTime = "9:00",
                    EndTime = "10:00",
                    Date = new DateTime(2024, 6, 22),
                    Issue = "I need my wisdom teeth removed.",
                    Status = AppNumber.APPOINTMENT_COMPLETED,
                    Type = false,
                    IdUser = Guid.Parse("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    IsRating = true,
                    Price = 500000,

                },
                new Appointment
                {
                    IdAppointment = 5,
                    StartTime = "09:00",
                    EndTime = "10:00",
                    Date = new DateTime(2024, 6, 20),
                    Issue = "My face has many pimples.",
                    Status = AppNumber.APPOINTMENT_COMPLETED,
                    Type = false,
                    IdUser = Guid.Parse("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c986"),
                    IsRating = true,
                    Price = 350000,

                },

                new Appointment
                {
                    IdAppointment = 6,
                    StartTime = "10:00",
                    EndTime = "11:00",
                    Date = new DateTime(2024, 6, 25),
                    Issue = "My tooth is swollen and hurts a lot.",
                    Status = AppNumber.APPOINTMENT_CONFIRMED,
                    Type = false,
                    IdUser = Guid.Parse("9117c626-c3d0-4d14-b345-d70d85268623"),
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    Price = 400000,

                },
                new Appointment
                {
                    IdAppointment = 7,
                    StartTime = "9:00",
                    EndTime = "10:00",
                    Date = new DateTime(2024, 6, 26),
                    Issue = "I need my wisdom teeth removed.",
                    Status = AppNumber.APPOINTMENT_CONFIRMED,
                    Type = false,
                    IdUser = Guid.Parse("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    Price = 400000,

                },

                new Appointment
                {
                    IdAppointment = 8,
                    StartTime = "9:00",
                    EndTime = "10:00",
                    Date = new DateTime(2024, 6, 25),
                    Issue = "I need my wisdom teeth removed.",
                    Status = AppNumber.APPOINTMENT_CONFIRMED,
                    Type = false,
                    IdUser = Guid.Parse("6ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    Price = 500000,

                },

                //Appointment with status Waiting (Patient not come)
                new Appointment
                {
                    IdAppointment = 9,
                    StartTime = "08:00",
                    EndTime = "09:00",
                    Date = new DateTime(2024, 6, 23),
                    Issue = "My wisdom teeth have some problems.",
                    Status = AppNumber.APPOINTMENT_WAITING,
                    Type = false,
                    IdUser = Guid.Parse("5ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    Price = 500000,

                },
                new Appointment
                {
                    IdAppointment = 10,
                    StartTime = "13:00",
                    EndTime = "14:00",
                    Date = new DateTime(2024, 6, 22),
                    Issue = "I need my wisdom teeth removed.",
                    Status = AppNumber.APPOINTMENT_WAITING,
                    Type = false,
                    IdUser = Guid.Parse("3ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    Price = 500000,

                },
                new Appointment
                {
                    IdAppointment = 11,
                    StartTime = "14:00",
                    EndTime = "15:00",
                    Date = new DateTime(2024, 6, 23),
                    Issue = "I need my wisdom teeth removed.",
                    Status = AppNumber.APPOINTMENT_WAITING,
                    Type = false,
                    IdUser = Guid.Parse("4ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    Price = 500000,

                }
                );

            #endregion


            #region Data Rating

            modelBuilder.Entity<Rating>().HasData(
                new Rating
                {
                    IdRating = 1,
                    RatingScore = 5,
                    Comment = "The quality of examination service is very good.",
                    IdUser = Guid.Parse("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    IdAppointment = 3

                },
                new Rating
                {
                    IdRating = 2,
                    RatingScore = 4,
                    Comment = "The doctor is very enthusiastic.",
                    IdUser = Guid.Parse("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    IdAppointment = 4
                },
                new Rating
                {
                    IdRating = 3,
                    RatingScore = 3,
                    Comment = "Good service.",
                    IdUser = Guid.Parse("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c986"),
                    IdAppointment = 5
                },


                new Rating
                {
                    IdRating = 4,
                    RatingScore = 4,
                    Comment = "Good service.",
                    IdUser = Guid.Parse("1ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"),
                    IdAppointment = 98
                },
                new Rating
                {
                    IdRating = 5,
                    RatingScore = 2,
                    Comment = "Good service.",
                    IdUser = Guid.Parse("2ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("954d0f01-a006-443a-957d-3d1165b79ee7"),
                    IdAppointment = 98
                },
                new Rating
                {
                    IdRating = 6,
                    RatingScore = 5,
                    Comment = "Good service.",
                    IdUser = Guid.Parse("3ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c983"),
                    IdAppointment = 98
                },



                new Rating
                {
                    IdRating = 7,
                    RatingScore = 4,
                    Comment = "The doctor is very enthusiastic.",
                    IdUser = Guid.Parse("5ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    IdAppointment = 4
                },
                new Rating
                {
                    IdRating = 8,
                    RatingScore = 3,
                    Comment = "The doctor is very enthusiastic.",
                    IdUser = Guid.Parse("6ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    IdAppointment = 4
                },
                new Rating
                {
                    IdRating = 9,
                    RatingScore = 5,
                    Comment = "The doctor is very enthusiastic.",
                    IdUser = Guid.Parse("7ba4b5ec-1ad8-4676-8871-122749af64e4"),
                    IdDoctor = Guid.Parse("2536a049-6c0d-45fc-a0d6-ea107731c985"),
                    IdAppointment = 4
                }
                );

            #endregion
        }
    }
}
