namespace BE_Healthcare.Models
{
    public class AddTrainingProcessModel
    {
        public string SchoolName { get; set; } = null!;
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public string Major { get; set; } = null!;
        public Guid? IdDoctor { get; set; }
    }
}
