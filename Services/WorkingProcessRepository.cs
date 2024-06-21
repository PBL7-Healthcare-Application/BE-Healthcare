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
        private readonly INotificationRepository _notificationRepository;

        public WorkingProcessRepository(MyDbContext context, INotificationRepository notificationRepository)
        {
            _context = context;
            _notificationRepository = notificationRepository;
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
            UpdateIsVerifiedInfoWorkingProcess(idDoctor, false);
            return new ApiResponse
            {
                StatusCode = StatusCode.SUCCESS,
                Message = AppString.MESSAGE_ADDWORKINGPROCESS_SUCCESS,
            };
        }
        public async Task<ApiResponse> AddListWorkingProcess(Guid idDoctor, List<AddWorkingProcessModel> workingprocesses)
        {
            foreach (var workingprocess in workingprocesses)
            {
                AddWorkingProcess(idDoctor, workingprocess);
            }
            Save();
            UpdateIsVerifiedInfoWorkingProcess(idDoctor, false);

            var doctor = _context.Doctors.Include(p => p.User).FirstOrDefault(q => q.IdDoctor == idDoctor);

            var admin = _context.Users.Include(p => p.Role).FirstOrDefault(x => x.idRole == AppNumber.ROLE_ADMIN);
            if (admin != null && doctor != null)
                await _notificationRepository.CreateNotificationDoctorAddNewInfo(admin.IdUser, idDoctor, doctor.User.Name);

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
        private Doctor? GetDoctorByIdDoctor(Guid idDoctor)
        {
            return _context.Doctors.Include(p => p.User).Include(q => q.MedicalSpecialty).FirstOrDefault(e => e.IdDoctor == idDoctor);
        }

        private void UpdateIsVerifiedInfoWorkingProcess(Guid idDoctor, bool IsVerified)
        {
            var doctor = GetDoctorByIdDoctor(idDoctor);

            if (doctor != null)
            {
                doctor.IsVerifiedInfoWorkingProcess = IsVerified;
                _context.Doctors.Update(doctor);
                _context.SaveChanges();
            }
        }
        public async Task<ApiResponse> UpdateWorkingProcess(Guid idDoctor, UpdateWorkingProcessModel model)
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

                var doctor = _context.Doctors.Include(p => p.User).FirstOrDefault(q => q.IdDoctor == idDoctor);

                var admin = _context.Users.Include(p => p.Role).FirstOrDefault(x => x.idRole == AppNumber.ROLE_ADMIN);
                if (admin != null && doctor != null)
                    await _notificationRepository.CreateNotificationDoctorAddNewInfo(admin.IdUser, idDoctor, doctor.User.Name);

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
        private void DeleteWorkingProcess(WorkingProcess workingProcess)
        {
            try
            {
                _context.WorkingProcesses.Remove(workingProcess);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void CheckListWorkingProcessRemainingIsVerified(Guid idDoctor)
        {
            var listWorkingProcess = GetWorkingProcess(idDoctor);
            if (listWorkingProcess == null) UpdateIsVerifiedInfoWorkingProcess(idDoctor, true);
            else
            {
                bool update = true;
                foreach (var c in listWorkingProcess)
                {
                    if (c.StatusVerified == AppNumber.PENDING)
                    {
                        update = false;
                        break;
                    }
                }
                if (update) UpdateIsVerifiedInfoWorkingProcess(idDoctor, true);
            }
        } 
        public ApiResponse DeleteWorkingProcess(Guid idDoctor, int idWorkingProcess)
        {
            try
            {
                var workingProcess = GetWorkingProcessOfDoctorByIdWorkingProcess(idDoctor, idWorkingProcess);
                bool checkListWorkingProcessAgain = false;
                if (workingProcess == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_WORKINGPROCESS,
                    };
                }

                if (workingProcess.StatusVerified == AppNumber.PENDING) checkListWorkingProcessAgain = true;
                DeleteWorkingProcess(workingProcess);


                //Check list Certificate of Doctor is Verified?
                if (checkListWorkingProcessAgain)
                {
                    CheckListWorkingProcessRemainingIsVerified(idDoctor);
                }

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_DELETEWORKINGPROCESS_SUCCESS,
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
