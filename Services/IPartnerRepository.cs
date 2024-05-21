using BE_Healthcare.Models;
using BE_Healthcare.Models.Partner;

namespace BE_Healthcare.Services
{
    public interface IPartnerRepository
    {
        ApiResponse RegisterAsDoctor(Guid idUser, RegistrationFormDoctorModel model);
        ApiResponse GetPartner(PartnerSearchCriteriaModel model);
        ApiResponse VerifyInfoPartner(VerifyPartnerModel model);

    }
}
