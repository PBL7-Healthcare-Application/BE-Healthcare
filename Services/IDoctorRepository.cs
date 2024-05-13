﻿using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IDoctorRepository
    {
        ApiResponse GetAllDoctor(DoctorSearchCriteriaModel model);
        Doctor? GetDoctorById(Guid id);
        Doctor? GetDoctorByIdUser(Guid id);

        ApiResponse GetDoctorDetail(Guid id, List<SlotAppointmentModel> list);
        List<TimeOffModel>? GetTimeOffByIdDoctor(Guid id);
        IQueryable<Doctor> GetAll();
        int GetTotalAppointmentByIdDoctor(DateTime d, Guid idDoctor);
        int CalculateFreeSlots(Guid idDoctor, DateTime d, string WorkingTimeStart, string WorkingTimeEnd, int DurationPerAppointment);
        void AddDoctor(Doctor doctor);
    }
}
