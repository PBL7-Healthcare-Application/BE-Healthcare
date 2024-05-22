namespace BE_Healthcare.Models.Partner
{
    public class VerifyWorkingProcessModel
    {
        public Guid IdDoctor { get; set; }
        public List<WorkingProcessModel> WorkingProcesses { get; set; }
    }
}
