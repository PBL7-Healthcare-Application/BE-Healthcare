using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Partner;
using BE_Healthcare.Models.TrainingProcess;

namespace BE_Healthcare.Services
{
    public interface ITrainingProcessRepository
    {
        Task<ApiResponse> AddListTrainingProcess(Guid idDoctor, List<AddTrainingProcessModel> trainingProcesses);
        void AddTrainingProcess(Guid idDoctor, AddTrainingProcessModel trainingProcess);
        void Save();
        ApiResponse AddOneTrainingProcess(Guid idDoctor, AddTrainingProcessModel trainingProcess);
        List<TrainingProcessModel>? GetTrainingProcessByIdDoctor(Guid id);
        int GetNumberOfTrainingProcessWaitingForApproval(Guid idDoctor);
        TrainingProcess? GetTrainingProcessOfDoctorByIdTrainingProcess(Guid idDoctor, int idTrainingProcess);
        void VerifyTrainingProcess(VerifyTrainingProcessModel model);
        Task<ApiResponse> UpdateTrainingProcess(Guid idDoctor, UpdateTrainingProcessModel model);
        ApiResponse DeleteTrainingProcess(Guid idDoctor, int idTrainingProcess);
    }
}
