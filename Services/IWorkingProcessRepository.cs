﻿using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Partner;

namespace BE_Healthcare.Services
{
    public interface IWorkingProcessRepository
    {
        void AddWorkingProcess(Guid idDoctor, AddWorkingProcessModel workingprocess);
        ApiResponse AddOneWorkingProcess(Guid idDoctor, AddWorkingProcessModel workingprocess);
        ApiResponse AddListWorkingProcess(Guid idDoctor, List<AddWorkingProcessModel> workingprocesses);
        List<WorkingProcessModel>? GetWorkingProcessByIdDoctor(Guid id);

        int GetNumberOfWorkingProcessWaitingForApproval(Guid idDoctor);
        WorkingProcess? GetWorkingProcessOfDoctorByIdWorkingProcess(Guid idDoctor, int idWorkingProcess);
        void VerifyWorkingProcess(VerifyWorkingProcessModel model);

    }
}
