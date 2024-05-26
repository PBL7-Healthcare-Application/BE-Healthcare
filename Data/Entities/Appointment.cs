using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Data.Entities
{
    public class Appointment
    {
        [Key]
        public int IdAppointment { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        public string? Issue { get; set; } = null;
        public int? Status { get; set; }    //Status: 1 - Approved; 2 - Cancels; 3 - Completed
        public bool Type { get; set; } = false!;    //False - Offline; True - Online

        public Guid? IdDoctor { get; set; }

        [ForeignKey(nameof(IdDoctor))]
        public Doctor Doctor { get; set; } = null!;

        public Guid? IdUser { get; set; }

        [ForeignKey(nameof(IdUser))]
        public User User { get; set; } = null!;
        public double? Price { get; set; }
        public string? Reason { get; set; } = null;
        public Guid? idDoctorCancel { get; set; } = null!;
        public Guid? idUserCancel { get; set; } = null!;
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public bool IsRating { get; set; } = false!;
        public DateTime? StartTimeOfExamination { get; set; } = null!;

    }
}
