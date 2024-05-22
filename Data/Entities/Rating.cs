using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Data.Entities
{
    public class Rating
    {
        [Key]
        public int IdRating { get; set; }
        public int RatingScore { get; set; }
        public string? Comment { get; set; } = null!;
        public Guid? IdUser { get; set; }
        [ForeignKey(nameof(IdUser))]
        public User User { get; set; } = null!;

        public Guid? IdDoctor { get; set; }
        [ForeignKey(nameof(IdDoctor))]
        public Doctor Doctor { get; set; } = null!;
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public int IdAppointment { get; set; }


    }
}
