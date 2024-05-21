using BE_Healthcare.Data.Entities;

namespace BE_Healthcare.Models.Partner
{
    public class RegistrationFormDoctorModel
    {
        //public int YearExperience { get; set; }
        //public double Price { get; set; }
        //public string Description { get; set; } = null!;
        public int IdSpecialty { get; set; }
        public string NameClinic { get; set; } = null!;
        public string BusinessLicense { get; set; } = null!;

        public List<AddCertificateModel>? Certificates { get; set; }
        public List<AddWorkingProcessModel>? WorkingProcesses { get; set; }
        public List<AddTrainingProcessModel>? TrainingProcesses { get; set; }
    }
}
