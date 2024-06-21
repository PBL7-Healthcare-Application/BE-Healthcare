using BE_Healthcare.Constant;

namespace BE_Healthcare.Models.Partner
{
    public class PartnerSearchCriteriaModel
    {
        public string? search { get; set; }
        public int? idSpecialty { get; set; }
        public int page { get; set; } = 1;
        public int TypePartner{ get; set; } = AppNumber.TYPEPARTNER_PARTNER_REGISTRATIONFORM; //1: Partner registration form; 2:Doctor's information pending approval


    }
}
