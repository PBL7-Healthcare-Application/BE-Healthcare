namespace BE_Healthcare.Models
{
    public class TrainingProcessModel
    {
        public int IdTrainingProcess { get; set; }
        public string SchoolName { get; set; } = null!;
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public string Major { get; set; } = null!;
        public int? StatusVerified { get; set; } //0: Pending - 1: Approved - 2: Rejected

    }
}
