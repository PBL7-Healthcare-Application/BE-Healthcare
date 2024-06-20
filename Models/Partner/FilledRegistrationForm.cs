using BE_Healthcare.Models.Certificate;
using BE_Healthcare.Models.TrainingProcess;
using BE_Healthcare.Models.WorkingProcess;

namespace BE_Healthcare.Models.Partner
{
    public class FilledRegistrationForm 
    {
        public string MedicalSpecialty { get; set; } = null!;
        public int? StatusVerified { get; set; } //0: Pending - 1: Approved - 2: Rejected
        public int IdSpecialty { get; set; }
        public string? NameClinic { get; set; } = null!;
        public string? BusinessLicense { get; set; } = null!;

        public List<CertificateModel>? Certificates { get; set; }
        public List<WorkingProcessModel>? WorkingProcesses { get; set; }
        public List<TrainingProcessModel>? TrainingProcesses { get; set; }
    }
}
