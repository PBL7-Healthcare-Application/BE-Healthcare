using BE_Healthcare.Constant;

namespace BE_Healthcare.Models.WorkingProcess
{
    public class WorkingProcessModel : AddWorkingProcessModel
    {
        public int IdWorkingProcess { get; set; }
        public int? StatusVerified { get; set; } //0: Pending - 1: Approved - 2: Rejected


    }
}
