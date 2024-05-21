namespace BE_Healthcare.Models.Partner
{
    public class PartnerSearchCriteriaModel
    {
        public string? search { get; set; }
        public int? idSpecialty { get; set; }
        public int page { get; set; } = 1;
    }
}
