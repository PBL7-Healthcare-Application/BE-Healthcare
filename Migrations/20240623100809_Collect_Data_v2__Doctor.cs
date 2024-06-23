using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Collect_Data_v2__Doctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "BusinessLicense", "CreatedAt", "Description", "DurationPerAppointment", "IdSpecialty", "IdUser", "IsVerifiedAt", "IsVerifiedInfoCertificate", "IsVerifiedInfoTrainingProcess", "IsVerifiedInfoWorkingProcess", "NameClinic", "NumberOfComment", "Price", "RateAverage", "StatusVerified", "UpdatedAt", "WorkingTimeEnd", "WorkingTimeStart", "YearExperience" },
                values: new object[,]
                {
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979325/gyr3max086lrfcy8ej7u.webp", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8351), "Dr. Michael Brown has always been fascinated by technology involved in radiotherapy. After graduating from the University of the Philippines Manila, he spent his internship at the Philippine General Hospital, where he was recognized as the most outstanding intern in orthopedics and outstanding intern in neurosurgery. He then moved to four years of residency training in one of the Philippines` biggest hospitals, the Makati Medical Center. After residency, he served as Chief Resident of Radiation Oncology for a year before heading to Davao Doctors Hospital.He currently is a Philippine Medical Association Member, fellow of the Philippine College of Radiology Member, and diplomate of the Philippine Radiation Oncology Society.", 60, 1, new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8355), true, true, true, "Dr. Michael Brown Clinic", 1, 400000.0, 5.0, 1, null, "18:00", "08:00", 20 },
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c984"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979241/gmdzkgdzwsdzvhawwn9a.png", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8356), "Sarah Davis earned her Doctor of Medicine and Master in Business Administration (MD-MBA) double degree and her Bachelor of Science in Health Sciences degree from the Ateneo de Manila University where she currently serves as a professor for global health and health policy.She leads both Alaga Health Inc. and Experto PlayLabs International Consultancy Inc. as Chief Operating Officer.  As a research consultant, she has previously worked with Health Care Without Harm - Asia, Mark Johnston Hospital, Global Center for Good Governance in Tobacco Control, Epimetrics, the Ateneo Center for Health Evidence, Action & Leadership (A-HEALS), the Department of Health (DOH), United States Agency for International Development (USAID), and the University of the Philippines", 60, 10, new Guid("efaaf180-4211-45d1-9b08-f085f19cb452"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8360), true, true, true, "Dr. Sarah Davis Clinic", 0, 350000.0, null, 1, null, "18:00", "08:00", 15 },
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979279/d5cf4lohbymvfftgopmo.webp", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8361), "David Wilson was formerly Chief Medical Officer, Calamba Medical Center, serving from Jan 2018 to 2022. She`s also the founding board member of the Philippine Infectious Diseases Society of Obstetrics and Gynecology. She earned her post-doctoral Fellowship on HIV/OB-GYN Infections from The Miriam Hospital-Brown University, Providence RI under the Fogarty Grant Training (NIH) scholarship. She graduated with a medical degree from the UP College of Medicine and completed her residency training in Obstetrics and Gynecology at the Philippine General Hospital (UP-PGH). She also completed her MBA in Health at the Ateneo Graduate School of Business.", 60, 6, new Guid("efaaf180-4211-45d1-9b08-f085f19cb453"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8364), true, true, true, "Dr. David Wilson Clinic", 5, 500000.0, 4.2000000000000002, 1, null, "18:00", "08:00", 32 },
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c986"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979325/gyr3max086lrfcy8ej7u.webp", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8365), "Laura Martinez graduated with a Bachelor of Science degree in Human Biology and obtained her medical degree from the De La Salle Health Sciences Institute. She is currently taking up her residency training as an Internal Medicine doctor at the Chinese General Hospital and Medical Center.", 60, 6, new Guid("efaaf180-4211-45d1-9b08-f085f19cb454"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8369), true, true, true, "Dr. Laura Martinez Clinic", 1, 350000.0, 3.0, 1, null, "18:00", "08:00", 23 },
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c987"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979241/gmdzkgdzwsdzvhawwn9a.png", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8371), "Robert Taylor is a graduate of the University of the Philippines College of Medicine. He completed his residency training in Internal Medicine at the Philippine General Hospital. He is a diplomate of the Philippine College of Physicians and a fellow of the Philippine Society of Endocrinology, Diabetes, and Metabolism. He is currently a consultant at the Makati Medical Center and the Asian Hospital and Medical Center. He is also a faculty member of the Ateneo School of Medicine and Public Health. He is a member of the Philippine Medical Association, the Philippine Society of Endocrinology, Diabetes, and Metabolism, and the American Association of Clinical Endocrinologists. He is also a member of the Philippine Society of General Internal Medicine and the Philippine Society of Parenteral and Enteral Nutrition", 60, 6, new Guid("efaaf180-4211-45d1-9b08-f085f19cb455"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8377), true, true, true, "Dr. Robert Taylor Clinic", 0, 400000.0, null, 1, null, "18:00", "08:00", 27 },
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c988"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979279/d5cf4lohbymvfftgopmo.webp", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8378), "Jessica Moore graduated from the University of Sto. Tomas with a degree in Doctor of Medicine. For her undergraduate studies, she pursued BS in Psychology at the same university. he is currently a diplomate of the Philippine Heart Association and a fellow of the Philippine College of Physicians.", 60, 6, new Guid("efaaf180-4211-45d1-9b08-f085f19cb456"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8382), true, true, true, "Dr. Jessica Moore Clinic", 0, 450000.0, null, 1, null, "18:00", "08:00", 26 },
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c989"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979325/gyr3max086lrfcy8ej7u.webp", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8382), "Dr. Alice Morgan has always been fascinated by advancements in dermatological technology. After graduating from the University of the Philippines Manila, she completed her internship at the Philippine General Hospital, where she was recognized as the most outstanding intern in dermatology and outstanding intern in internal medicine. She then pursued four years of residency training at one of the Philippines` largest hospitals, the Makati Medical Center. After her residency, she served as Chief Resident of Dermatology for a year before joining Davao Doctors Hospital. She is currently a member of the Philippine Medical Association, a fellow of the Philippine Dermatological Society, and a diplomate of the Philippine Board of Dermatology.", 60, 6, new Guid("e4a0f9d1-f914-4d85-bfe1-1dc5c4507a6f"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8386), true, true, true, "Dr. Alice Morgan Clinic", 0, 4000000.0, null, 1, null, "17:00", "08:00", 24 },
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c990"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979241/gmdzkgdzwsdzvhawwn9a.png", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8387), "Dr. Oliver White was formerly Chief Medical Officer at Calamba Medical Center, serving from January 2018 to 2022. He is also a founding board member of the Philippine Society of Internal Medicine. He earned his post-doctoral Fellowship in Infectious Diseases from The Miriam Hospital-Brown University, Providence RI, under the Fogarty Grant Training (NIH) scholarship. He graduated with a medical degree from the UP College of Medicine and completed his residency training in Internal Medicine at the Philippine General Hospital (UP-PGH). He also completed his MBA in Health at the Ateneo Graduate School of Business.", 60, 1, new Guid("b2d5a7d6-dab1-489a-8db5-2c9483a7d948"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8392), true, true, true, "Dr. Oliver White Clinic", 0, 3500000.0, null, 1, null, "17:00", "08:00", 29 },
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c991"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979279/d5cf4lohbymvfftgopmo.webp", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8393), "Dr. Sophie Harris graduated with a Bachelor of Science degree in Human Biology and obtained her medical degree from the De La Salle Health Sciences Institute. She is currently taking up her residency training as a Dermatology doctor at the Chinese General Hospital and Medical Center.", 60, 6, new Guid("f76c3b89-8fcd-4e5f-abc1-39c13fb8a97d"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8397), true, true, true, "Dr. Sophie Harris Clinic", 0, 3000000.0, null, 1, null, "17:00", "08:00", 20 },
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c992"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979325/gyr3max086lrfcy8ej7u.webp", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8398), "Dr. Henry Walker is a graduate of the University of the Philippines College of Medicine. He completed his residency training in Pediatrics at the Philippine General Hospital. He is a diplomate of the Philippine Pediatric Society and a fellow of the Philippine Society of Pediatric Gastroenterology, Hepatology, and Nutrition. He is currently a consultant at the Makati Medical Center and the Asian Hospital and Medical Center. He is also a faculty member of the Ateneo School of Medicine and Public Health. He is a member of the Philippine Medical Association, the Philippine Pediatric Society, and the American Academy of Pediatrics. He is also a member of the Philippine Society of Pediatric Gastroenterology, Hepatology, and Nutrition and the Philippine Society of Newborn Medicine.", 60, 4, new Guid("cf9b2f8e-59c9-4f09-8fa1-d624fd0d5bcb"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8402), true, true, true, "Dr. Henry Walker Clinic", 0, 3000000.0, null, 1, null, "17:00", "08:00", 19 },
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c993"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979241/gmdzkgdzwsdzvhawwn9a.png", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8403), "Dr. Mia Robinson graduated from the University of Sto. Tomas with a Doctor of Medicine degree. For her undergraduate studies, she pursued a BS in Psychology at the same university. She is currently a diplomate of the Philippine Heart Association and a fellow of the Philippine College of Physicians.", 60, 10, new Guid("4a9dc58e-282a-4f92-9b0d-bb1a707c3f7b"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8407), true, true, true, "Dr. Mia Robinson Clinic", 0, 3400000.0, null, 1, null, "17:00", "08:00", 21 },
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c994"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979279/d5cf4lohbymvfftgopmo.webp", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8409), "Dr. James Clark, M.D., is a graduate of De La Salle Medical & Health Sciences Institute with a Doctor of Medicine degree. He completed his residency training in General Surgery at De La Salle University Medical Center. During his residency training, he wrote an award-winning case report and research. He also served as the department`s Chief Resident. Dr. Clark is now a General Surgeon and the doctor behind the “Surgery On-The-Go” Facebook page.", 60, 2, new Guid("d6a4c3e8-9111-4bc2-b0b9-e84b4dfb5d9e"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8412), true, true, true, "Dr. James Clark Clinic", 0, 400000.0, null, 1, null, "17:00", "08:00", 27 },
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c995"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979325/gyr3max086lrfcy8ej7u.webp", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8413), "Dr. Ava Thompson has always been fascinated by advancements in cardiovascular technology. After graduating from the University of the Philippines Manila, she spent her internship at the Philippine General Hospital, where she was recognized as the most outstanding intern in cardiology and outstanding intern in internal medicine. She then moved to four years of residency training in one of the Philippines` biggest hospitals, the Makati Medical Center. After residency, she served as Chief Resident of Cardiology for a year before heading to Davao Doctors Hospital. She is currently a member of the Philippine Medical Association, a fellow of the Philippine College of Physicians, and a diplomate of the Philippine Heart Association.", 60, 10, new Guid("1f2b4a9d-793e-4c89-9fdf-3d1e684d816f"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8417), true, true, true, "Dr. Ava Thompson Clinic", 0, 500000.0, null, 1, null, "17:00", "08:00", 33 },
                    { new Guid("2536a049-6c0d-45fc-a0d6-ea107731c996"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979325/gyr3max086lrfcy8ej7u.webp", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8418), null, null, 10, new Guid("1ba4b5ec-1ad8-4676-8871-122749af64e4"), null, false, true, true, "Dr. John Doe Clinic", 0, null, null, 0, null, null, null, null },
                    { new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979241/gmdzkgdzwsdzvhawwn9a.png", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8331), "Dr. John Smith is a seasoned Dentistry specialist with a wealth of experience in oral health care. Formerly the Deputy Head of Clinical Department at a prominent dentistry Hospital in Ho Chi Minh City, Dr. Smith is renowned for his expertise in diagnosing and treating complex dental conditions, particularly in pediatric dentistry and various cosmetic dentistry procedures.\n\nDr. Smith is a familiar face at dentistry conferences and seminars, contributing significantly to the field with over 20 years of professional experience. Known for his compassionate and dedicated approach, he is always available to advise and support patients on their medical concerns tailored to individual needs", 60, 7, new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8342), false, true, true, "Dr. John Smith Clinic", 1, 400000.0, 4.0, 1, null, "17:00", "08:00", 22 },
                    { new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"), "https://res.cloudinary.com/dzdfqqdxs/image/upload/v1718979279/d5cf4lohbymvfftgopmo.webp", new DateTime(2024, 6, 23, 17, 8, 8, 611, DateTimeKind.Local).AddTicks(8344), "Emily Johnson, M.D. is a graduate of De La Salle Medical & Health Sciences Institute, Doctor of Medicine. He had his Pediatric residency training at De La Salle University Medical Center. During his residency training, he wrote an award-winning case report and research. He also became the department`s Chief Resident. Dr. Macapinlac is now a General Pediatrician and the doctor behind “Pedia On-The-Go” Facebook page", 60, 5, new Guid("9f12c430-de83-4910-92ac-704bffefaab2"), new DateTime(2024, 6, 23, 10, 8, 8, 611, DateTimeKind.Utc).AddTicks(8349), true, true, true, "Dr. John Smith Clinic", 1, 500000.0, 2.0, 1, null, "17:00", "07:00", 18 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c983"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c984"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c985"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c986"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c987"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c988"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c989"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c990"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c991"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c992"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c993"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c994"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c995"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("2536a049-6c0d-45fc-a0d6-ea107731c996"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("6c2e4c40-ad25-40fa-ad40-4c620f09d9b2"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: new Guid("954d0f01-a006-443a-957d-3d1165b79ee7"));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "MedicalSpecialties",
                keyColumn: "IdSpecialty",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("1ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7113), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("1f2b4a9d-793e-4c89-9fdf-3d1e684d816f"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7628), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7645), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("2ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7115), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7135), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("3ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7159), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("4a9dc58e-282a-4f92-9b0d-bb1a707c3f7b"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7593), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7609), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("4ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7161), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7183), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("5ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7184), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7208), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7209), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7231), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("6d2fc8cc-cbfa-401d-aef5-2d1588751d32"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7257), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7281), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("7ba4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7232), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7255), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("85f97fe1-83e4-4dcc-91ca-367cb29f148e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7036), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7063), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9117c626-c3d0-4d14-b345-d70d85268623"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(6885), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7031), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("9f12c430-de83-4910-92ac-704bffefaab2"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7283), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7306), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("b2d5a7d6-dab1-489a-8db5-2c9483a7d948"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7539), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7557), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("bfa4b5ec-1ad8-4676-8871-122749af64e4"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7064), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7089), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("cf9b2f8e-59c9-4f09-8fa1-d624fd0d5bcb"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7576), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7592), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("d6a4c3e8-9111-4bc2-b0b9-e84b4dfb5d9e"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7610), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7627), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("e4a0f9d1-f914-4d85-bfe1-1dc5c4507a6f"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7521), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7537), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf143-4211-45d1-9b08-f085f19caa56"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7647), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7661), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb451"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7308), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7331), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb452"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7333), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7355), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb453"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7357), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7381), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb454"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7383), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7407), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb455"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7409), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7456), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("efaaf180-4211-45d1-9b08-f085f19cb456"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7499), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7519), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: new Guid("f76c3b89-8fcd-4e5f-abc1-39c13fb8a97d"),
                columns: new[] { "CreatedAt", "OTPCreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 5, 9, 495, DateTimeKind.Local).AddTicks(7558), new DateTime(2024, 6, 23, 10, 5, 9, 495, DateTimeKind.Utc).AddTicks(7575), new byte[] { 67, 247, 87, 14, 16, 78, 130, 63, 107, 5, 190, 219, 169, 236, 147, 1, 124, 79, 160, 255, 172, 142, 152, 99, 251, 212, 13, 36, 134, 233, 58, 60 }, new byte[] { 50, 252, 0, 220, 10, 236, 172, 37, 173, 200, 156, 229, 183, 90, 121, 51, 42, 74, 54, 3, 213, 73, 19, 136, 4, 131, 170, 72, 89, 92, 192, 90, 9, 221, 218, 29, 136, 0, 70, 84, 248, 161, 220, 52, 126, 66, 106, 100, 91, 113, 251, 221, 27, 126, 103, 168, 79, 36, 137, 32, 68, 42, 185, 121 } });
        }
    }
}
