namespace BE_Healthcare.Models
{
    public class MyAppointmentModel
    {
        public string NameDoctor { get; set; } = null!;
        public string MedicalSpecialty { get; set; } = null!;
        public string? AvatarDoctor { get; set; } = null!;

        public int IdAppointment { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public DateTime Date { get; set; }
        public bool Type { get; set; } = false!;    //False - Offline; True - Online
        public int? Status { get; set; }    //Status: 1 - Approved; 2 - Reject; 3 - Completed
        public string? Issue { get; set; } = null;


    }
}
