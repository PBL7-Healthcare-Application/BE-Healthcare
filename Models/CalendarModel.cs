namespace BE_Healthcare.Models
{
    public class CalendarModel
    {
        public List<TimeOffModel>? TimeOffs { get; set; } = null!;
        public List<AppointmentManagementModel>? Appointments { get; set; } = null!;

    }
}
