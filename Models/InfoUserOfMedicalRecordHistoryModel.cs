namespace BE_Healthcare.Models
{
    public class InfoUserOfMedicalRecordHistoryModel
    {
        public Guid IdUser { get; set; }
        public string? NameUser { get; set; } = null!;
        public string? AvatarUser { get; set; } = null!;
        public string? PhoneNumberUser { get; set; } = null!;

    }
}
