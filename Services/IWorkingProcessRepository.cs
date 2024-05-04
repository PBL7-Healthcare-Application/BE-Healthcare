using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IWorkingProcessRepository
    {
        void AddWorkingProcess(Guid idDoctor, AddWorkingProcessModel workingprocess);
        ApiResponse AddOneWorkingProcess(Guid idDoctor, AddWorkingProcessModel workingprocess);
        ApiResponse AddListWorkingProcess(Guid idDoctor, List<AddWorkingProcessModel> workingprocesses);
    }
}
