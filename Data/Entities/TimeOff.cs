using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Data.Entities
{
    public class TimeOff
    {
        [Key]
        public int IdTimeOff { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? Date { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public Guid? IdDoctor { get; set; }

        [ForeignKey(nameof(IdDoctor))]
        public Doctor Doctor { get; set; } = null!;
        public int? Status { get; set; }
        public string Reason { get; set; } = null!;
        

    }
}
