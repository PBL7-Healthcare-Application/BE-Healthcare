using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Partner;

namespace BE_Healthcare.Services
{
    public interface ITrainingProcessRepository1
    {
        ApiResponse AddListTrainingProcess(Guid idDoctor, List<AddTrainingProcessModel> trainingProcesses);
        ApiResponse AddOneTrainingProcess(Guid idDoctor, AddTrainingProcessModel trainingProcess);
        void AddTrainingProcess(Guid idDoctor, AddTrainingProcessModel trainingProcess);
        int GetNumberOfTrainingProcessWaitingForApproval(Guid idDoctor);
        List<TrainingProcessModel>? GetTrainingProcessByIdDoctor(Guid id);
        TrainingProcess? GetTrainingProcessOfDoctorByIdTrainingProcess(Guid idDoctor, int idCertificate);
        void Save();
        void VerifyTrainingProcess(VerifyCertificateModel model);
    }
}