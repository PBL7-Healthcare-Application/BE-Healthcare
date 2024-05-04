namespace BE_Healthcare.Models
{
    public class ScheduleAppointmentSuccessfulModel : AppointmentModel
    {
        public string Name { get; set; } = null!;
        public string? Address { get; set; } = null!;
        public double? Price { get; set; }
        public string? Avatar_Doctor { get; set; } = null!;

        public Guid IdUser { get; set; }
        public string Name_User { get; set; } = null!;
        public string? Avatar_User { get; set; } = null!;



    }
}
