using System.ComponentModel.DataAnnotations;

namespace BE_Healthcare.Data.Entities
{
    public class MedicalSpecialty
    {
        [Key]
        public int Id_Specialty { get; set; }

        public string Name { get; set; } = null!;

        //public virtual ICollection<Doctor> Doctors{ get; set; } = null!;

    }
}
