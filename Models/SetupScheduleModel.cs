namespace BE_Healthcare.Models
{
    public class SetupScheduleModel
    {
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public int DurationPerAppointment { get; set; }

    }
}
