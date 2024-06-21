using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Data.Entities
{
    public class MedicalRecord
    {
        [Key]
        public int IdMedicalRecord { get; set; }

        public Guid IdDoctor { get; set; }
        [ForeignKey(nameof(IdDoctor))]
        public Doctor Doctor { get; set; } = null!;

        public Guid IdUser { get; set; }
        [ForeignKey(nameof(IdUser))]
        public User User { get; set; } = null!;

        public int IdAppointment { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int Height { get; set; }
        public double Weight { get; set; }    
        public double Temperature { get; set; }    
        public string Content { get; set; } = null!;
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

    }
}
