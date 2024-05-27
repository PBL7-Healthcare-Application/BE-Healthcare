using BE_Healthcare.Constant;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Data.Entities
{
    public class Certificate
    {
        [Key]
        public int IdCertificate { get; set; }
        public string Name { get; set; } = null!;
        public int? Year { get; set; }
        public string Image{ get; set; } = null!;

        public Guid? IdDoctor { get; set; }

        [ForeignKey(nameof(IdDoctor))]
        public Doctor Doctor { get; set; } = null!;
        public int? StatusVerified { get; set; } = AppNumber.PENDING; //0: Pending - 1: Approved - 2: Rejected
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = null!;

    }
}
