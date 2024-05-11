﻿using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IDoctorRepository
    {
        ApiResponse GetAllDoctor(string? search = null, int? exp = null, double? from = null, double? to = null, string? sortBy = null, int? id_specialty = null, string? filterAvailable = null, int page = 1);
        Doctor? GetDoctorById(Guid id);
        Doctor? GetDoctorByIdUser(Guid id);

        ApiResponse GetDoctorDetail(Guid id, List<SlotAppointmentModel> list);
        List<TimeOffModel> GetTimeOffByIdDoctor(Guid id);
        IQueryable<Doctor> GetAll();
        int GetTotalAppointmentByIdDoctor(DateTime d, Guid idDoctor);
        int CalculateFreeSlot(Guid idDoctor, DateTime d, string WorkingTimeStart, string WorkingTimeEnd, int DurationPerAppointment);
        void AddDoctor(Doctor doctor);
    }
}
