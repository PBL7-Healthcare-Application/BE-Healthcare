using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BE_Healthcare.Constant;

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
        public int? StatusVerified { get; set; } = AppNumber.PENDING; //0: Pending - 1: Approved - 2: Rejected

    }
}
