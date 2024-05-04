using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IPartnerRepository
    {
        ApiResponse RegisterAsDoctor(Guid idUser, RegistrationFormDoctorModel model);
    }
}
