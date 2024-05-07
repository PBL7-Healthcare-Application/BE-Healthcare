namespace BE_Healthcare.Models
{
    public class ScheduleAppointmentSuccessfulModel : AppointmentModel
    {
        public string NameDoctor { get; set; } = null!;
        public string? AvatarDoctor { get; set; } = null!;

        public Guid IdUser { get; set; }
        public string NameUser { get; set; } = null!;
        public string? AvatarUser { get; set; } = null!;
        public string EmailUser { get; set; } = null!;
        public string? NameMedicalSpecialty { get; set; } = null!;




    }
}
