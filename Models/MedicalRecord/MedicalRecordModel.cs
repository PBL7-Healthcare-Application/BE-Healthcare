using BE_Healthcare.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Models.MedicalRecord
{
    public class MedicalRecordModel
    {
        public Guid? IdDoctor { get; set; }
        public Guid IdUser { get; set; }
        public int IdAppointment { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public double Temperature { get; set; }
        public string Content { get; set; } = null!;
        public DateTime? Date { get; set; } = null!;

    }
}
