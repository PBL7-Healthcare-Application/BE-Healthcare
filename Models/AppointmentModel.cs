using BE_Healthcare.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Models
{
    public class AppointmentModel : SlotAppointmentModel
    {
        public Guid IdDoctor { get; set; }
        public string? Issue { get; set; } = null;
        public bool Type { get; set; } = false!;    //False - Offline; True - Online
        public double? Price { get; set; }
        public string? Address { get; set; } = null!;
        public string? NameClinic { get; set; } = null!;


    }
}
