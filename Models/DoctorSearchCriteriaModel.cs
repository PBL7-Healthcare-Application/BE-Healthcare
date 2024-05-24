namespace BE_Healthcare.Models
{
    public class DoctorSearchCriteriaModel
    {
        public string? search { get; set; } = null;
        public int? exp { get; set; } = null;
        public double? from { get; set; } = null;
        public double? to { get; set; } = null;
        public string? sortBy { get; set; } = null;
        public int? idSpecialty { get; set; } = null;
        public string? filterAvailable { get; set; } = null;
        public int page { get; set; } = 1;
        public int? rate{ get; set; } = null!;

    }
}
