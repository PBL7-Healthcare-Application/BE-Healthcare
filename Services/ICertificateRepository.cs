using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface ICertificateRepository
    {
        ApiResponse AddListCertificate(Guid idDoctor, List<AddCertificateModel> certificates);
        void AddCertificate(Guid idDoctor, AddCertificateModel certificate);
        void Save();
        ApiResponse AddOneCertificate(Guid idDoctor, AddCertificateModel certificate);
        List<CertificateModel>? GetCertificateByIdDoctor(Guid id);

    }
}
