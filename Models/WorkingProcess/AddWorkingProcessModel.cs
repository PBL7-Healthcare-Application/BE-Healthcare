namespace BE_Healthcare.Models.WorkingProcess
{
    public class AddWorkingProcessModel
    {
        public string? Position { get; set; } = null!;
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public string? Workplace { get; set; } = null!;

        //public Guid? IdDoctor { get; set; }
    }
}
