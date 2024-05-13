using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Data.Entities
{
    public class Doctor
    {
        [Key]
        public Guid IdDoctor { get; set; }
        public int? YearExperience { get; set; } = null!;
        public double? Price { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public int? IdSpecialty { get; set; }

        [ForeignKey(nameof(IdSpecialty))]
        public MedicalSpecialty MedicalSpecialty{ get; set; } = null!;
        public ICollection<Certificate> Certificates { get; set; } = null!;

        public Guid IdUser { get; set; }
        public User User { get; set; } = null!;
        public string? WorkingTimeStart { get; set; } = null!;
        public string? WorkingTimeEnd { get; set; } = null!;
        public int? DurationPerAppointment { get; set; }
        public int? StatusVerified { get; set; } //0: Pending - 1: Approved - 2: Rejected
        public string? NameClinic { get; set; } = null!;
        public string? BusinessLicense { get; set; } = null!;



    }
}
