﻿using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IAppointmentRepository
    {
        List<Appointment>? GetListAppointmentByIdDoctor(Guid idDoctor, int? Status = 1);
        ApiResponse CreateAppointment(Guid idUser, AppointmentModel model);
        void AddAppointment(Guid idUser, AppointmentModel model);
        //public int CalculateFreeSlot(Guid idDoctor);
        ApiResponse GetAppointmentByIdUser(Guid idUser, int? Status = null);
        ApiResponse CancelAppointment(CancelAppointmentModel model, Guid? idUserCancel = null, Guid? idDoctorCancel = null);
        ApiResponse GetAppointmentByIdDoctor(Guid idDoctor, int? Status = 1);
        void UpdateStatusAppointment(Guid? idDoctor = null, Guid? idUser = null);
        Appointment? GetAppointmentByIdAppointment(int idAppointment);
        ApiResponse SetupSchedule (Guid idDoctor, SetupScheduleModel model);
        List<SlotAppointmentModel>? GetListAppointmentofDoctorDetail(Guid idDoctor);



    }
}
