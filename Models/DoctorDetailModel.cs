using BE_Healthcare.Data.Entities;

namespace BE_Healthcare.Models
{
    public class DoctorDetailModel : DoctorModel
    {
        public string? PhoneNumber { get; set; } = null!;

        public List<CertificateModel> Certificates { get; set; } = null!;
        public List<WorkingProcessModel> WorkingProcess { get; set; } = null!;
        public List<TrainingProcessModel> TrainingProcess { get; set; } = null!;
        public string? WorkingTimeStart { get; set; } = null!;
        public string? WorkingTimeEnd { get; set; } = null!;
        public int? DurationPerAppointment { get; set; }
        public List<TimeOffModel> TimeOffs { get; set; } = null!;
        public string? NameClinic { get; set; } = null!;
        
        public List<SlotAppointmentModel>? SlotAppointments { get; set; } = null!;

    }
}
