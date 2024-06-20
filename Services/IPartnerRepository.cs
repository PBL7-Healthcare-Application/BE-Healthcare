using BE_Healthcare.Models;
using BE_Healthcare.Models.Partner;

namespace BE_Healthcare.Services
{
    public interface IPartnerRepository
    {
        Task<ApiResponse> RegisterAsDoctor(Guid idUser, RegistrationFormDoctorModel model);
        ApiResponse GetPartner(PartnerSearchCriteriaModel model);
        Task<ApiResponse> VerifyInfoPartner(VerifyPartnerModel model);
        Task<ApiResponse> VerifyCertificate(VerifyCertificateModel model);
        Task<ApiResponse> VerifyWorkingProcess(VerifyWorkingProcessModel model);
        Task<ApiResponse> VerifyTrainingProcess(VerifyTrainingProcessModel model);
        ApiResponse GetFilledForm(Guid idUser);


    }
}
