namespace BE_Healthcare.Models.MedicalRecord
{
    public class DoctorViewMedicalRecordHistoryOfUserModel
    {
        public InfoUserOfMedicalRecordHistoryModel InfoUser { get; set; }
        public List<MedicalRecordHistoryModel> MedicalRecordHistory { get; set; }
    }
}
