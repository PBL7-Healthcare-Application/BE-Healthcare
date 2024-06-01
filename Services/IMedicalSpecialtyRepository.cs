using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IMedicalSpecialtyRepository
    {
        ApiResponse GetAllMedicalSpecialty();
        string? GetMedicalSpecialtyByIdSpecialty(int? id);


    }
}
