using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Partner;
using BE_Healthcare.Models.TrainingProcess;
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
            UpdateIsVerifiedInfoTrainingProcess(idDoctor, false);
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
            UpdateIsVerifiedInfoTrainingProcess(idDoctor, false);
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
            return _context.TrainingProcesses.Include(e => e.Doctor)
            .AsQueryable().Where(e => e.IdDoctor == idDoctor).FirstOrDefault(c => c.IdTrainingProcess == idTrainingProcess);
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

        private void UpdateTrainingProcess(TrainingProcess trainingProcess, UpdateTrainingProcessModel model)
        {
            try
            {
                if (model.SchoolName != null) trainingProcess.SchoolName = model.SchoolName;
                if (model.StartYear != null) trainingProcess.StartYear = model.StartYear;
                if (model.EndYear != null) trainingProcess.EndYear = model.EndYear;
                if (model.Major != null) trainingProcess.Major = model.Major;
                trainingProcess.UpdatedAt = DateTime.Now;
                trainingProcess.StatusVerified = AppNumber.PENDING;
                _context.TrainingProcesses.Update(trainingProcess);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private Doctor? GetDoctorByIdDoctor(Guid idDoctor)
        {
            return _context.Doctors.Include(p => p.User).Include(q => q.MedicalSpecialty).FirstOrDefault(e => e.IdDoctor == idDoctor);
        }

        private void UpdateIsVerifiedInfoTrainingProcess(Guid idDoctor, bool IsVerified)
        {
            var doctor = GetDoctorByIdDoctor(idDoctor);

            if (doctor != null)
            {
                doctor.IsVerifiedInfoTrainingProcess = IsVerified;
                _context.Doctors.Update(doctor);
                _context.SaveChanges();
            }
        }
        public ApiResponse UpdateTrainingProcess(Guid idDoctor, UpdateTrainingProcessModel model)
        {
            try
            {
                var trainingProcess = GetTrainingProcessOfDoctorByIdTrainingProcess(idDoctor, model.IdTrainingProcess);
                if (trainingProcess == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_CERTIFICATE,
                    };
                }

                UpdateTrainingProcess(trainingProcess, model);
                UpdateIsVerifiedInfoTrainingProcess(idDoctor, false);

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_UPDATETRAININGPROCESS_SUCCESS,
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
        private void DeleteTrainingProcess(TrainingProcess trainingProcess)
        {
            try
            {
                _context.TrainingProcesses.Remove(trainingProcess);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void CheckListTrainingProcessRemainingIsVerified(Guid idDoctor)
        {
            var listTrainingProcess = GetTrainingProcess(idDoctor);
            if (listTrainingProcess == null) UpdateIsVerifiedInfoTrainingProcess(idDoctor, true);
            else
            {
                bool update = true;
                foreach (var c in listTrainingProcess)
                {
                    if (c.StatusVerified == AppNumber.PENDING)
                    {
                        update = false;
                        break;
                    }
                }
                if (update) UpdateIsVerifiedInfoTrainingProcess(idDoctor, true);
            }
        }
        public ApiResponse DeleteTrainingProcess(Guid idDoctor, int idTrainingProcess)
        {
            try
            {
                var trainingProcess = GetTrainingProcessOfDoctorByIdTrainingProcess(idDoctor, idTrainingProcess);
                bool checkListTrainingProcessAgain = false;
                if (trainingProcess == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_TRAININGPROCESS,
                    };
                }

                if (trainingProcess.StatusVerified == AppNumber.PENDING) checkListTrainingProcessAgain = true;
                DeleteTrainingProcess(trainingProcess);


                //Check list Certificate of Doctor is Verified?
                if (checkListTrainingProcessAgain)
                {
                    CheckListTrainingProcessRemainingIsVerified(idDoctor);
                }

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_DELETETRAININGPROCESS_SUCCESS,
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
