using BE_Healthcare.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Models
{
    public class AppointmentModel
    {
        public Guid IdDoctor { get; set; }

        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public DateTime Date { get; set; }
        public string? Issue { get; set; } = null;
        public bool Type { get; set; } = false!;    //False - Offline; True - Online
    }
}
