namespace BE_Healthcare.Models
{
    public class MyAppointmentModel : AppointmentModel
    {
        public string NameDoctor { get; set; } = null!;
        public string MedicalSpecialty { get; set; } = null!;
        public string? AvatarDoctor { get; set; } = null!;

        public int IdAppointment { get; set; }
        public int? Status { get; set; }    //Status: 1 - Approved; 2 - Reject; 3 - Completed

    }
}
