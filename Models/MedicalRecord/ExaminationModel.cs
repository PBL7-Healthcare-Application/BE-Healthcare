namespace BE_Healthcare.Models.MedicalRecord
{
    public class ExaminationModel : AppointmentManagementModel
    {
        public DateTime? StartTimeOfExamination { get; set; } = null!;
        public Guid? IdUser { get; set; }

    }
}
