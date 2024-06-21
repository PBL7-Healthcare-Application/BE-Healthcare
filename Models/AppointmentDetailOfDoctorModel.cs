namespace BE_Healthcare.Models
{
    public class AppointmentDetailOfDoctorModel : AppointmentModel
    {
        public Guid IdUser { get; set; }
        public string NameUser { get; set; } = null!;
        public string? AvatarUser { get; set; } = null!;
        public string NameDoctor { get; set; } = null!;
        public string? AvatarDoctor { get; set; } = null!;
        public string? MedicalSpecialty { get; set; } = null!;

    }
}
