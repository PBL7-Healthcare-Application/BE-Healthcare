namespace BE_Healthcare.Models.MedicalRecord
{
    public class DoctorViewMedicalRecordHistoryOfUserModel : MedicalRecordHistoryModel
    {
        public string NameUser { get; set; } = null!;
        public string? PhoneNumberUser { get; set; } = null!;

    }
}
