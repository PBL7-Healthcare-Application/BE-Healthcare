using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Partner;
using Microsoft.EntityFrameworkCore;
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
        private IQueryable<TrainingProcess>? GetTrainingProcess(Guid id)
        {
            var list_trainingProcess = _context.TrainingProcesses.Include(e => e.Doctor)
                .AsQueryable().Where(e => e.IdDoctor == id);
            return list_trainingProcess;
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
        public List<TrainingProcessModel>? GetTrainingProcessByIdDoctor(Guid id)
        {
            var list_trainingProcess = GetTrainingProcess(id);
            if (list_trainingProcess == null) return null;
            var result_trainingProcess = list_trainingProcess.Select(c => new TrainingProcessModel
            {
                IdTrainingProcess = c.IdTrainingProcess,
                SchoolName = c.SchoolName,
                StartYear = c.StartYear,
                EndYear = c.EndYear,
                Major = c.Major,
                StatusVerified = c.StatusVerified

            }).ToList();
            return result_trainingProcess;
        }
        public TrainingProcess? GetTrainingProcessOfDoctorByIdTrainingProcess(Guid idDoctor, int idTrainingProcess)
        {
            var list_TrainingProcess = GetTrainingProcess(idDoctor);
            if (list_TrainingProcess == null) return null;
            return list_TrainingProcess.FirstOrDefault(c => c.IdTrainingProcess == idTrainingProcess);
        }

        public int GetNumberOfTrainingProcessWaitingForApproval(Guid idDoctor)
        {
            try
            {
                var trainingprocess = GetTrainingProcess(idDoctor);
                if (trainingprocess == null) return 0;
                else return trainingprocess.Where(p => p.StatusVerified == 0).Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }

        public void VerifyTrainingProcess(VerifyTrainingProcessModel model)
        {
            try
            {
                foreach (var trainingprocessModel in model.TrainingProcesses)
                {
                    var trainingprocess = GetTrainingProcessOfDoctorByIdTrainingProcess(model.IdDoctor, trainingprocessModel.IdTrainingProcess);
                    if (trainingprocess != null)
                    {
                        trainingprocess.StatusVerified = trainingprocessModel.StatusVerified;
                        _context.TrainingProcesses.Update(trainingprocess);
                    }
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
