using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Partner;
using BE_Healthcare.Models.TrainingProcess;
using BE_Healthcare.Models.WorkingProcess;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Tls;

namespace BE_Healthcare.Services
{
    public class WorkingProcessRepository : IWorkingProcessRepository
    {
        private readonly MyDbContext _context;

        public WorkingProcessRepository(MyDbContext context)
        {
            _context = context;
        }
        private IQueryable<WorkingProcess>? GetWorkingProcess(Guid id)
        {
            var list_WorkingProcess = _context.WorkingProcesses.Include(e => e.Doctor)
                .AsQueryable().Where(e => e.IdDoctor == id);
            return list_WorkingProcess;
        }

        public void AddWorkingProcess(Guid idDoctor, AddWorkingProcessModel workingprocess)
        {
            var wor = new WorkingProcess
            {
                Position = workingprocess.Position,
                StartYear = workingprocess.StartYear,
                EndYear = workingprocess.EndYear,
                Workplace = workingprocess.Workplace,
                IdDoctor = idDoctor
            };
            _context.WorkingProcesses.Add(wor);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public ApiResponse AddOneWorkingProcess(Guid idDoctor, AddWorkingProcessModel workingprocess)
        {
            AddWorkingProcess(idDoctor, workingprocess);
            Save();
            return new ApiResponse
            {
                StatusCode = StatusCode.SUCCESS,
                Message = AppString.MESSAGE_ADDWORKINGPROCESS_SUCCESS,
            };
        }
        public ApiResponse AddListWorkingProcess(Guid idDoctor, List<AddWorkingProcessModel> workingprocesses)
        {
            foreach (var workingprocess in workingprocesses)
            {
                AddWorkingProcess(idDoctor, workingprocess);
            }
            Save();
            return new ApiResponse
            {
                StatusCode = StatusCode.SUCCESS,
                Message = AppString.MESSAGE_ADDLISTWORKINGPROCESS_SUCCESS,
            };
        }
        public List<WorkingProcessModel>? GetWorkingProcessByIdDoctor(Guid id)
        {
            var list_WorkingProcess = GetWorkingProcess(id);
            if (list_WorkingProcess == null) return null;
            var result_WorkingProcess = list_WorkingProcess.Select(c => new WorkingProcessModel
            {
                IdWorkingProcess = c.IdWorkingProcess,
                Position = c.Position,
                StartYear = c.StartYear,
                EndYear = c.EndYear,
                Workplace = c.Workplace,
                StatusVerified = c.StatusVerified,
            }).ToList();
            return result_WorkingProcess;
        }
        public WorkingProcess? GetWorkingProcessOfDoctorByIdWorkingProcess(Guid idDoctor, int idWorkingProcess)
        {
            return _context.WorkingProcesses.Include(e => e.Doctor)
            .AsQueryable().Where(e => e.IdDoctor == idDoctor).FirstOrDefault(c => c.IdWorkingProcess == idWorkingProcess);
        }

        public int GetNumberOfWorkingProcessWaitingForApproval(Guid idDoctor)
        {
            try
            {
                var workingprocess = GetWorkingProcess(idDoctor);
                if (workingprocess == null) return 0;
                else return workingprocess.Where(p => p.StatusVerified == 0).Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }
        public void VerifyWorkingProcess(VerifyWorkingProcessModel model)
        {
            try
            {
                foreach (var workingprocessModel in model.WorkingProcesses)
                {
                    var workingprocess = GetWorkingProcessOfDoctorByIdWorkingProcess(model.IdDoctor, workingprocessModel.IdWorkingProcess);
                    if (workingprocess != null)
                    {
                        workingprocess.StatusVerified = workingprocessModel.StatusVerified;
                        _context.WorkingProcesses.Update(workingprocess);
                    }
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        private void UpdateWorkingProcess(WorkingProcess workingProcess, UpdateWorkingProcessModel model)
        {
            try
            {
                if (model.Position != null) workingProcess.Position = model.Position;
                if (model.StartYear != null) workingProcess.StartYear = model.StartYear;
                if (model.EndYear != null) workingProcess.EndYear = model.EndYear;
                if (model.Workplace != null) workingProcess.Workplace = model.Workplace;
                workingProcess.UpdatedAt = DateTime.Now;
                workingProcess.StatusVerified = AppNumber.PENDING;
                _context.WorkingProcesses.Update(workingProcess);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void UpdateIsVerifiedInfoWorkingProcess(Guid idDoctor, bool IsVerified)
        {
            var doctor = _context.Doctors.Include(p => p.User).Include(q => q.MedicalSpecialty).FirstOrDefault(e => e.IdDoctor == idDoctor);

            if (doctor != null)
            {
                doctor.IsVerifiedInfoWorkingProcess = IsVerified;
                _context.Doctors.Update(doctor);
                _context.SaveChanges();
            }
        }
        public ApiResponse UpdateWorkingProcess(Guid idDoctor, UpdateWorkingProcessModel model)
        {
            try
            {
                var workingProcess = GetWorkingProcessOfDoctorByIdWorkingProcess(idDoctor, model.IdWorkingProcess);
                if (workingProcess == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_CERTIFICATE,
                    };
                }

                UpdateWorkingProcess(workingProcess, model);
                UpdateIsVerifiedInfoWorkingProcess(idDoctor, false);

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_UPDATEWORKINGPROCESS_SUCCESS,
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
