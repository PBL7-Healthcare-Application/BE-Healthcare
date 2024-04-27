using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IDoctorRepository
    {
        ApiResponse GetAllDoctor(string? search = null, int? exp = null, double? from = null, double? to = null, string? sortBy = null, int? id_specialty = null);
        ApiResponse GetDoctorById(Guid id);
    }
}
