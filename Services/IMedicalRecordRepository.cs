using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.MedicalRecord;

namespace BE_Healthcare.Services
{
    public interface IMedicalRecordRepository
    {
        void AddMedicalRecord(MedicalRecordModel model);
        ApiResponse CreateMedicalRecord(MedicalRecordModel model);
        ApiResponse GetMedicalRecordByIdUser(Guid idUser);
        ApiResponse GetListExaminationByIdDoctor(Guid idDoctor, string? search = null);

    }
}
