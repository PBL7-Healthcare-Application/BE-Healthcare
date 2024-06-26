﻿using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IAppointmentRepository
    {
        List<Appointment>? GetListAppointmentByIdDoctor(Guid idDoctor, int? Status = 1, string? search = null);
        Task<ApiResponse> CreateAppointment(Guid idUser, AppointmentModel model); 
        int AddAppointment(Guid idUser, AppointmentModel model);
        //public int CalculateFreeSlot(Guid idDoctor);
        ApiResponse GetAppointmentByIdUser(Guid idUser, int? Status = null);
        Task<ApiResponse> CancelAppointment(CancelAppointmentModel model, Guid? idUserCancel = null, Guid? idDoctorCancel = null);
        ApiResponse GetAppointmentByIdDoctor(Guid idDoctor, AppointmentSearchCriteriaModel criteria);
        void UpdateStatusAppointment(Guid? idDoctor = null, Guid? idUser = null);
        Appointment? GetAppointmentByIdAppointment(int idAppointment);
        List<SlotAppointmentModel>? GetListAppointmentofDoctorDetail(Guid idDoctor);
        ApiResponse GetAppointmentDetail(int id);
        ApiResponse? CheckTimeIsValid(TimeSpan startTime, TimeSpan WorkingTimeStart, TimeSpan WorkingTimeEnd);
        //Task<ApiResponse> SendNotification();
        void UpdateAppointment(Appointment appointment);
        void UpdateAppointmentCompleted(int idAppointment);
        Task<ApiResponse> ScheduleFollowupAppointment(ScheduleFollowupAppointmentModel model);

        ApiResponse GetAllAppointment(AdminSearchAppointmentCriteriaModel criteria);

        Task<ApiResponse> UpdateAppointment(UpdateAppointmentModel model);


    }
}
