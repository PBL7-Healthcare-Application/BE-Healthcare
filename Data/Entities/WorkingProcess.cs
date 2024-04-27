using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BE_Healthcare.Data.Entities
{
    public class WorkingProcess
    {
        [Key]
        public int IdWorkingProcess { get; set; }
        public string Position { get; set; } = null!;
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public string Workplace { get; set; } = null!;

        public Guid? IdDoctor { get; set; }

        [ForeignKey(nameof(IdDoctor))]
        public Doctor Doctor { get; set; } = null!;
    }
}
