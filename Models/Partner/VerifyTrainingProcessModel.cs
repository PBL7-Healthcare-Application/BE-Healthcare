using BE_Healthcare.Models.TrainingProcess;

namespace BE_Healthcare.Models.Partner
{
    public class VerifyTrainingProcessModel
    {
        public Guid IdDoctor { get; set; }
        public List<TrainingProcessModel> TrainingProcesses { get; set; }
    }
}
