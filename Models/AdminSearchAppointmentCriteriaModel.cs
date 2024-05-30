namespace BE_Healthcare.Models
{
    public class AdminSearchAppointmentCriteriaModel
    {
        public DateTime? Date { get; set; } = null!;
        public int? Status { get; set; } = null!;
        public int page { get; set; } = 1;
    }
}
