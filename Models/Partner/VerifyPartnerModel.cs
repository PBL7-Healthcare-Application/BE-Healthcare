namespace BE_Healthcare.Models.Partner
{
    public class VerifyPartnerModel
    {
        public Guid IdDoctor { get; set; }
        public int? StatusVerified { get; set; } //0: Pending - 1: Approved - 2: Rejected

    }
}
