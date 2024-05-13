using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using Microsoft.EntityFrameworkCore;

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
    }

}
