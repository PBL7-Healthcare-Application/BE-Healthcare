using System.ComponentModel.DataAnnotations;

namespace BE_Healthcare.Data.Entities
{
    public class MedicalSpecialty
    {
        [Key]
        public int IdSpecialty { get; set; }

        public string Name { get; set; } = null!;

        //public virtual ICollection<Doctor> Doctors{ get; set; } = null!;

    }
}
