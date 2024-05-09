namespace BE_Healthcare.Models
{
    public class AppointmentManagementModel
    {
        public int IdAppointment { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public DateTime Date { get; set; }
        public string NamePatient{ get; set; } = null!;
        public string? PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        
    }
}
