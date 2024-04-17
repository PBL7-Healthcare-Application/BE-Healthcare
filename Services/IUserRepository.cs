using API_Login.Models;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IUserRepository
    {
        ApiResponse Validate(LoginModel model);

        TokenModel GenerateToken(User user);
        ApiResponse RenewToken(TokenModel model);


    }
}
