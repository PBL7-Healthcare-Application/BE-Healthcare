using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly MyDbContext _context;
        private readonly ICertificateRepository _certificateRepository;
        private readonly IWorkingProcessRepository _workingProcessRepository;
        private readonly ITrainingProcessRepository _trainingProcessRepository;
        private readonly IDoctorRepository _doctorRepository;


        public PartnerRepository(MyDbContext context, ICertificateRepository certificateRepository, 
            IWorkingProcessRepository workingProcessRepository, ITrainingProcessRepository trainingProcessRepository,
            IDoctorRepository doctorRepository)
        {
            _context = context;
            _certificateRepository = certificateRepository;
            _workingProcessRepository = workingProcessRepository;
            _trainingProcessRepository = trainingProcessRepository;
            _doctorRepository = doctorRepository;


        }

        public ApiResponse RegisterAsDoctor(Guid idUser, RegistrationFormDoctorModel model)
        {
            try
            {
                var newDoctor = new Doctor
                {
                    IdDoctor = Guid.NewGuid(),
                    //YearExperience = model.YearExperience,
                    //Price = model.Price,
                    //Description = model.Description,
                    IdSpecialty = model.IdSpecialty,
                    IdUser = idUser,
                    StatusVerified = AppNumber.PENDING,
                    BusinessLicense = model.BusinessLicense,
                };

                _doctorRepository.AddDoctor(newDoctor);


                if(model.Certificates != null)
                {
                    _certificateRepository.AddListCertificate(newDoctor.IdDoctor, model.Certificates);
                }
                if(model.WorkingProcesses != null)
                {
                    _workingProcessRepository.AddListWorkingProcess(newDoctor.IdDoctor, model.WorkingProcesses);
                }
                if(model.TrainingProcesses != null)
                {
                    _trainingProcessRepository.AddListTrainingProcess(newDoctor.IdDoctor, model.TrainingProcesses);
                }

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_REGISTERDOCTOR_SUCCESS
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
