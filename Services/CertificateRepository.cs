using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Certificate;
using BE_Healthcare.Models.Partner;
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
        public Certificate? GetCertificateOfDoctorByIdCertificate(Guid idDoctor, int idCertificate)
        {
            return _context.Certificates.Include(e => e.Doctor)
            .AsQueryable().Where(e => e.IdDoctor == idDoctor).FirstOrDefault(c => c.IdCertificate == idCertificate);
        }
        public int GetNumberOfCertificateWaitingForApproval(Guid idDoctor)
        {
            try
            {
                var certificate = GetCertificate(idDoctor);
                if (certificate == null) return 0;
                else return certificate.Where(p => p.StatusVerified == 0).Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }
        public void VerifyCertificate(VerifyCertificateModel model)
        {
            try
            {
                foreach (var certificateModel in model.Certificates)
                {
                    var cer = GetCertificateOfDoctorByIdCertificate(model.IdDoctor, certificateModel.IdCertificate);
                    if (cer != null)
                    {
                        cer.StatusVerified = certificateModel.StatusVerified;
                        _context.Certificates.Update(cer);
                    }
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void UpdateCertificate(Certificate certificate, UpdateCertificateModel model)
        {
            try
            {
                if (model.Name != null) certificate.Name = model.Name;
                if (model.Year != null) certificate.Year = model.Year;
                if (model.Image != null) certificate.Image = model.Image;
                certificate.UpdatedAt = DateTime.Now;
                certificate.StatusVerified = AppNumber.PENDING;
                _context.Certificates.Update(certificate);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void UpdateIsVerifiedInfoCertificate(Guid idDoctor, bool IsVerified)
        {
            var doctor = _context.Doctors.Include(p => p.User).Include(q => q.MedicalSpecialty).FirstOrDefault(e => e.IdDoctor == idDoctor);

            if (doctor != null)
            {
                doctor.IsVerifiedInfoCertificate = IsVerified;
                _context.Doctors.Update(doctor);
                _context.SaveChanges();
            }
        }
        public ApiResponse UpdateCertificate(Guid idDoctor, UpdateCertificateModel model)
        {
            try
            {
                var certificate = GetCertificateOfDoctorByIdCertificate(idDoctor, model.IdCertificate);
                if (certificate == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_CERTIFICATE,
                    };
                }

                UpdateCertificate(certificate, model);
                UpdateIsVerifiedInfoCertificate(idDoctor, false);

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_UPDATECERTIFICATE_SUCCESS,
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_SERVER_ERROR,
                };
            }
        }


    }
}
