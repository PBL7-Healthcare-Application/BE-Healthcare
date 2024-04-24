using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Data.Entities
{
    public class Doctor
    {
        [Key]
        public Guid Id_Doctor { get; set; }
        public string Certificate { get; set; } = null!;
        public string WorkingProcess{ get; set; } = null!;
        public string TrainingProcess{ get; set; } = null!;
        public int? YearExperience { get; set; }
        public double? Price { get; set; }

        public int? Id_Specialty { get; set; }

        [ForeignKey(nameof(Id_Specialty))]
        public MedicalSpecialty MedicalSpecialty{ get; set; } = null!;
        
        public Guid Id_User { get; set; }

        [ForeignKey(nameof(Id_User))]
        public User User { get; set; } = null!;
    }
}
