namespace BE_Healthcare.Models
{
    public class AppointmentSearchCriteriaModel
    {
        public string? search { get; set; } = null;
        public int? Status { get; set; } = 1;
        public int page { get; set; } = 1;
        public string? filterAvailable { get; set; } = null;

    }
}
