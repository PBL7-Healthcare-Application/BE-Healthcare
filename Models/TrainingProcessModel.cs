namespace BE_Healthcare.Models
{
    public class TrainingProcessModel
    {
        public int IdTrainingProcess { get; set; }
        public string SchoolName { get; set; } = null!;
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public string Major { get; set; } = null!;
    }
}
