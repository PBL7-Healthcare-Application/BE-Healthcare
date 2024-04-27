using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BE_Healthcare.Data.Entities
{
    public class TrainingProcess
    {
        [Key]
        public int IdTrainingProcess { get; set; }
        public string SchoolName { get; set; } = null!;
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public string Major { get; set; } = null!;
        public Guid? IdDoctor { get; set; }

        [ForeignKey(nameof(IdDoctor))]
        public Doctor Doctor { get; set; } = null!;
    }
}
