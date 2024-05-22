using BE_Healthcare.Models;
using BE_Healthcare.Models.Partner;

namespace BE_Healthcare.Services
{
    public interface IPartnerRepository
    {
        ApiResponse RegisterAsDoctor(Guid idUser, RegistrationFormDoctorModel model);
        ApiResponse GetPartner(PartnerSearchCriteriaModel model);
        ApiResponse VerifyInfoPartner(VerifyPartnerModel model);
        ApiResponse VerifyCertificate(VerifyCertificateModel model);
        ApiResponse VerifyWorkingProcess(VerifyWorkingProcessModel model);
        ApiResponse VerifyTrainingProcess(VerifyTrainingProcessModel model);


    }
}
