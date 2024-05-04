using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using Org.BouncyCastle.Ocsp;
using Org.BouncyCastle.Tls;

namespace BE_Healthcare.Services
{
    public class TrainingProcessRepository : ITrainingProcessRepository
    {
        private readonly MyDbContext _context;

        public TrainingProcessRepository(MyDbContext context)
        {
            _context = context;
        }

        public void AddTrainingProcess(Guid idDoctor, AddTrainingProcessModel trainingProcess)
        {
            var train = new TrainingProcess
            {
                SchoolName = trainingProcess.SchoolName,
                StartYear = trainingProcess.StartYear,
                EndYear = trainingProcess.EndYear,
                Major = trainingProcess.Major,
                IdDoctor = idDoctor
            };
            _context.TrainingProcesses.Add(train);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public ApiResponse AddListTrainingProcess(Guid idDoctor, List<AddTrainingProcessModel> trainingProcesses)
        {
            foreach (var trainingProcess in trainingProcesses)
            {
                AddTrainingProcess(idDoctor, trainingProcess);
            }
            Save();
            return new ApiResponse
            {
                StatusCode = StatusCode.SUCCESS,
                Message = AppString.MESSAGE_ADDLISTTRAININGPROCESS_SUCCESS,
            };
        }

        public ApiResponse AddOneTrainingProcess(Guid idDoctor, AddTrainingProcessModel trainingProcess)
        {
            AddTrainingProcess(idDoctor, trainingProcess);
            Save();
            return new ApiResponse
            {
                StatusCode = StatusCode.SUCCESS,
                Message = AppString.MESSAGE_ADDTRAININGPROCESS_SUCCESS,
            };
        }
    }
}
