namespace BE_Healthcare.Models.Partner
{
    public class ListPartnerModel
    {
        public Guid IdDoctor { get; set; }
        public string Name { get; set; } = null!;
        public string MedicalSpecialty { get; set; } = null!;
        public DateTime? CreatedDate { get; set; } = null;
        public int? StatusVerified { get; set; } //0: Pending - 1: Approved - 2: Rejected

    }
}
