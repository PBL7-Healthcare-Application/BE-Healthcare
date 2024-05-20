using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BE_Healthcare.Constant;

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
        public int? StatusVerified { get; set; } = AppNumber.PENDING; //0: Pending - 1: Approved - 2: Rejected
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
