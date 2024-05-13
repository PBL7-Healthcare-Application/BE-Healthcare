using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface ITrainingProcessRepository
    {
        ApiResponse AddListTrainingProcess(Guid idDoctor, List<AddTrainingProcessModel> trainingProcesses);
        void AddTrainingProcess(Guid idDoctor, AddTrainingProcessModel trainingProcess);
        void Save();
        ApiResponse AddOneTrainingProcess(Guid idDoctor, AddTrainingProcessModel trainingProcess);
        List<TrainingProcessModel>? GetTrainingProcessByIdDoctor(Guid id);

    }
}
