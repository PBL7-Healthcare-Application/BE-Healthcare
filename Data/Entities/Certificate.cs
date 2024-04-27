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

        public Guid? Id_Doctor { get; set; }

        [ForeignKey(nameof(Id_Doctor))]
        public Doctor Doctor { get; set; } = null!;
    }
}
