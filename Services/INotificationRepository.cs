﻿using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Partner;

namespace BE_Healthcare.Services
{
    public interface INotificationRepository
    {
        Task CreateNotificationForCreatingAppointment(AppointmentModel model);
        Task CreateNotificationForCancellingAppointment(CancelAppointmentModel model, Appointment appointment, Guid? idReceiver);
        Task CreateNotificationForSchedulingFollowupAppointment(ScheduleFollowupAppointmentModel model);
        Task CreateNotificationForRegisteringDoctor(Guid idAdmin, Guid idDoctor, string nameDoctor);
        Task CreateNotificationForVerifyingDoctor(int StatusVerified, Guid idDoctor, bool VerifyAdditionalInformation = false);
        Task CreateNotificationDoctorAddNewInfo(Guid idAdmin, Guid idDoctor, string nameDoctor);

        Task CreateNotificationForNewRating( Guid idDoctor, string nameUser);
        Task CreateNotificationForReschedulingAppointment(UpdateAppointmentModel model, Guid idUser);

    }
}
