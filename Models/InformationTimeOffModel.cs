namespace BE_Healthcare.Models
{
    public class InformationTimeOffModel
    {
        public DateTime Date { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public int? Status { get; set; }
        public string? Reason { get; set; } = null!;
        public bool IsFixed { get; set; } = false;

    }
}
