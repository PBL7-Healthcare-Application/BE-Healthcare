using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();
        ApiResponse GetAllUser(UserSearchCriteriaModel criteria);
        ApiResponse DisableAccount(DisableAccountModel model);
        ApiResponse UnlockAccount(DisableAccountModel model);
        ApiResponse GetUserDetail(Guid idUser);
    }
}
