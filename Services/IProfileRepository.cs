using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IProfileRepository
    {
        ApiResponse GetPersonalInfo(string email);
    }
}
