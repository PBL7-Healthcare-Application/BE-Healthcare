namespace BE_Healthcare.Models
{
    public class SlotAppointmentModel
    {
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
