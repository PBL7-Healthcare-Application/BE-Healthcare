using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IDoctorRepository
    {
        ApiResponse GetAllDoctor(string search, int? exp, double? from, double? to, string sortBy, int? id_specialty);

    }
}
