using BE_Healthcare.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Models
{
    public class TimeOffModel
    {
        public int IdTimeOff { get; set; }
        public DateTime Date { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public int? Status { get; set; }
        public string? Reason { get; set; } = null!;

    }
}
