namespace BE_Healthcare.Models.MedicalRecord
{
    public class MedicalRecordHistoryModel : MedicalRecordModel
    {
        public string Name { get; set; } = null!;

        public string MedicalSpecialty { get; set; } = null!;
    }
}
