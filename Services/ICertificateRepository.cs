using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Certificate;
using BE_Healthcare.Models.Partner;

namespace BE_Healthcare.Services
{
    public interface ICertificateRepository
    {
        Task<ApiResponse> AddListCertificate(Guid idDoctor, List<AddCertificateModel> certificates);
        void AddCertificate(Guid idDoctor, AddCertificateModel certificate);
        void Save();
        ApiResponse AddOneCertificate(Guid idDoctor, AddCertificateModel certificate);
        List<CertificateModel>? GetCertificateByIdDoctor(Guid id);
        int GetNumberOfCertificateWaitingForApproval(Guid idDoctor);
        Certificate? GetCertificateOfDoctorByIdCertificate(Guid idDoctor, int idCertificate);
        void VerifyCertificate(VerifyCertificateModel model);
        Task<ApiResponse> UpdateCertificate(Guid idDoctor, UpdateCertificateModel model);
        ApiResponse DeleteCertificate(Guid idDoctor, int idCertificate);

    }
}
