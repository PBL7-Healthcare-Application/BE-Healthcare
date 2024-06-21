namespace BE_Healthcare.Models
{
    public class CancelAppointmentAndUpdateWorkingTimeModel : WorkingTimeModel
    {
        public string? Reason { get; set; } = null;
    }
}
