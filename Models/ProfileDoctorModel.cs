namespace BE_Healthcare.Models
{
    public class ProfileDoctorModel : ProfileModel
    {
        public Guid IdDoctor { get; set; }
        public int? YearExperience { get; set; }
        public double? Price { get; set; }
        public string? Description { get; set; } = null!;
        public string MedicalSpecialty { get; set; } = null!;
        public List<CertificateModel>? Certificates { get; set; } = null!;
        public List<WorkingProcessModel>? WorkingProcess { get; set; } = null!;
        public List<TrainingProcessModel>? TrainingProcess { get; set; } = null!;
        public string? WorkingTimeStart { get; set; } = null!;
        public string? WorkingTimeEnd { get; set; } = null!;
        public int? DurationPerAppointment { get; set; }
        public int? StatusVerified { get; set; } //0: Pending - 1: Approved - 2: Rejected
        public string? NameClinic { get; set; } = null!;
    }
}
