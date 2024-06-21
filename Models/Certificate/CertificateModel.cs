using BE_Healthcare.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Models.Certificate
{
    public class CertificateModel : AddCertificateModel
    {
        public int IdCertificate { get; set; }
        public int? StatusVerified { get; set; } //0: Pending - 1: Approved - 2: Rejected

    }
}
