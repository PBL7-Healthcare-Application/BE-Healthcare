using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using Microsoft.EntityFrameworkCore;

namespace BE_Healthcare.Services
{
    public class CertificateRepository : ICertificateRepository
    {
        private readonly MyDbContext _context;

        public CertificateRepository(MyDbContext context)
        {
            _context = context;
        }
        private IQueryable<Certificate>? GetCertificate(Guid id)
        {
            var list_Certificate = _context.Certificates.Include(e => e.Doctor)
                .AsQueryable().Where(e => e.IdDoctor == id);
            return list_Certificate;
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

        public List<CertificateModel>? GetCertificateByIdDoctor(Guid id)
        {
            var list_Certificate = GetCertificate(id);
            if (list_Certificate == null) return null;
            var result_certificate = list_Certificate.Select(c => new CertificateModel
            {
                IdCertificate = c.IdCertificate,
                Name = c.Name,
                Year = c.Year,
                Image = c.Image,
                StatusVerified = c.StatusVerified
            }).ToList();
            return result_certificate;
        }
    }
}
