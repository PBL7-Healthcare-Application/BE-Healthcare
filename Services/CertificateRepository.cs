using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public class CertificateRepository : ICertificateRepository
    {
        private readonly MyDbContext _context;

        public CertificateRepository(MyDbContext context)
        {
            _context = context;
        }

        public void AddCertificate(Guid idDoctor, AddCertificateModel certificate)
        {
            var cer = new Certificate
            {
                Name = certificate.Name,
                Year = certificate.Year,
                Image = certificate.Image,
                IdDoctor = idDoctor
            };
            _context.Certificates.Add(cer);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public ApiResponse AddOneCertificate(Guid idDoctor, AddCertificateModel certificate)
        {
            AddCertificate(idDoctor, certificate);
            Save();
            return new ApiResponse
            {
                StatusCode = StatusCode.SUCCESS,
                Message = AppString.MESSAGE_ADDCERTIFICATE_SUCCESS,
            };
        }
        public ApiResponse AddListCertificate(Guid idDoctor, List<AddCertificateModel> certificates)
        {
            foreach (var certificate in certificates)
            {
                AddCertificate(idDoctor, certificate);
            }
            Save();
            return new ApiResponse
            {
                StatusCode = StatusCode.SUCCESS,
                Message = AppString.MESSAGE_ADDLISTCERTIFICATE_SUCCESS,
            };
        }
    }
}
