using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IProfileRepository
    {
        ApiResponse GetPersonalInfo(string email);
        ApiResponse ChangePassword(string email, ChangePasswordModel model);
        ProfileModel CreateProfileModel(User u);

        ApiResponse UpdateProfile(string email, UpdateProfileModel model);
        
        ApiResponse LockAccount(Guid id, LockAccountModel model);

    }
}
