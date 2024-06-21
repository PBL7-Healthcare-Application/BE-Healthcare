namespace BE_Healthcare.Models.TrainingProcess
{
    public class TrainingProcessModel : AddTrainingProcessModel
    {
        public int IdTrainingProcess { get; set; }
        public int? StatusVerified { get; set; } //0: Pending - 1: Approved - 2: Rejected

    }
}
