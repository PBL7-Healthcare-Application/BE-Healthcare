using BE_Healthcare.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Models
{
    public class RatingModel
    {
        public int RatingScore { get; set; }
        public string? Comment { get; set; } = null!;
        public Guid IdDoctor { get; set; }
        public int IdAppointment { get; set; }

    }
}
