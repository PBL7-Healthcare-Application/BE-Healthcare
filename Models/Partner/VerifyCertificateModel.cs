using BE_Healthcare.Models.Certificate;

namespace BE_Healthcare.Models.Partner
{
    public class VerifyCertificateModel
    {
        public Guid IdDoctor { get; set; }
        public List<CertificateModel> Certificates { get; set; }

    }
}
