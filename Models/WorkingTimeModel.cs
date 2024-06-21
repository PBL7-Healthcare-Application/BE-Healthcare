namespace BE_Healthcare.Models
{
    public class WorkingTimeModel
    {
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public int DurationPerAppointment { get; set; }

    }
}
