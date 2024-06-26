﻿using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models.Notification;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Partner;

namespace BE_Healthcare.Services
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly FirestoreService _firestoreService;

        public NotificationRepository(FirestoreService firestoreService)
        {
            _firestoreService = firestoreService;
        }

        public async Task CreateNotificationForCreatingAppointment(AppointmentModel model)
        {
            try
            {
                // Notification for creating new appointment
                // Send notification to doctor
                var notif = new NotificationForDoctorModel
                {
                    Title = AppString.TITLE_CREATENEWAPPOINTMENT,
                    Body = AppString.BODY_CREATENEWAPPOINTMENT,
                    CreatedAt = DateTime.Now,
                    IdDoctor = (Guid)model.IdDoctor,
                    IdAppointment = model.IdAppointment,
                    NotificationType = AppNumber.NOTIFICATIONTYPE_APPOINTMENT,
                    Date = model.Date.Date,
                    StartTime = model.StartTime,
                    EndTime = model.EndTime
                };

                // Save the notification to Firestore
                await _firestoreService.AddDocumentAsync("notifications", notif);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public async Task CreateNotificationForCancellingAppointment(CancelAppointmentModel model, Appointment appointment, Guid? idReceiver)
        {
            try
            {
                // Notification for creating new appointment
                // Send notification to doctor
                var notif = new NotificationCancelAppointmentModel
                {
                    Title = AppString.TITLE_CANCELAPPOINTMENT,
                    Body = AppString.BODY_CANCELAPPOINTMENT,
                    CreatedAt = DateTime.Now,
                    idDoctorCancel = appointment.idDoctorCancel,
                    idUserCancel = appointment.idUserCancel,
                    idReceiver = idReceiver,

                    IdAppointment = model.idAppointment,
                    NotificationType = AppNumber.NOTIFICATIONTYPE_APPOINTMENT,
                    Date = appointment.Date.Date,
                    StartTime = appointment.StartTime,
                    EndTime = appointment.EndTime
                };

                // Save the notification to Firestore
                await _firestoreService.AddDocumentAsync("notifications",null, notif);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public async Task CreateNotificationForSchedulingFollowupAppointment(ScheduleFollowupAppointmentModel model)
        {
            try
            {
                // Notification for creating new appointment
                // Send notification to doctor
                var notice = new NotificationSchedulingFollowupAppointmentForUserModel
                {
                    Title = AppString.TITLE_SCHEDULING_FOLLOWUP_APPOINTMENT,
                    Body = AppString.BODY_SCHEDULING_FOLLOWUP_APPOINTMENT,
                    CreatedAt = DateTime.Now,
                    IdUser = model.IdUser,
                    IdAppointment = model.IdAppointment,
                    NotificationType = AppNumber.NOTIFICATIONTYPE_APPOINTMENT,
                    Date = model.Date.Date,
                    StartTime = model.StartTime,
                    EndTime = model.EndTime
                };

                // Save the notification to Firestore
                await _firestoreService.AddDocumentAsync("notifications", null, null, notice);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public async Task CreateNotificationForRegisteringDoctor(Guid idAdmin, Guid idDoctor, string nameDoctor)
        {
            try
            {
                // Notification for creating new appointment
                // Send notification to doctor
                var notice = new NotificationRegisteringDoctorModel
                {
                    Title = AppString.TITLE_NEW_REGISTRATION_APPLICATION,
                    Body = AppString.BODY_NEW_REGISTRATION_APPLICATION,
                    CreatedAt = DateTime.Now,
                    IdAdmin = idAdmin,
                    IdDoctor = idDoctor,
                    NameDoctor = nameDoctor,

                    NotificationType = AppNumber.NOTIFICATIONTYPE_APPLYINGDOCTOR,

                };

                // Save the notification to Firestore
                await _firestoreService.AddDocumentAsync("notifications", null, null, null, notice);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public async Task CreateNotificationForVerifyingDoctor(int StatusVerified, Guid idDoctor, bool VerifyAdditionalInformation = false)
        {
            try
            {
                string title;
                string body;
                // Notification for confirming approval of the application
                // Send notification to doctor
                if (VerifyAdditionalInformation)
                {
                    title = AppString.TITLE_APPROVED_INFORMATION;
                    body = AppString.BODY_APPROVED_INFORMATION;
                }
                else
                {
                    if (StatusVerified == AppNumber.APPROVED)
                    {
                        title = AppString.TITLE_REGISTRATION_APPLICATION_APPROVED;
                        body = AppString.BODY_REGISTRATION_APPLICATION_APPROVED;
                    }
                    else
                    {
                        title = AppString.TITLE_REGISTRATION_APPLICATION_REJECTED;
                        body = AppString.BODY_REGISTRATION_APPLICATION_REJECTED;
                    }
                }


                var notice = new NotificationVerifyingDoctorModel
                {
                    Title = title,
                    Body = body,
                    CreatedAt = DateTime.Now,
                    IdDoctor = idDoctor,

                    NotificationType = AppNumber.NOTIFICATIONTYPE_APPLYINGDOCTOR,

                };

                // Save the notification to Firestore
                await _firestoreService.AddDocumentAsync("notifications", null, null, null, null, notice);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public async Task CreateNotificationDoctorAddNewInfo(Guid idAdmin, Guid idDoctor, string nameDoctor)
        {
            try
            {
                // Send notification to doctor
                var notice = new NotificationDoctorAddOrEditInfoModel
                {
                    Title = AppString.TITLE_NEW_INFO_NEED_VERIFIED,
                    Body = AppString.BODY_NEW_INFO_NEED_VERIFIED,
                    CreatedAt = DateTime.Now,
                    IdAdmin = idAdmin,
                    IdDoctor = idDoctor,
                    NameDoctor = nameDoctor,

                    NotificationType = AppNumber.NOTIFICATIONTYPE_APPLYINGDOCTOR,
                };

                // Save the notification to Firestore
                await _firestoreService.AddDocumentAsync("notifications", null, null, null, null, null, null, notice);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public async Task CreateNotificationForNewRating(Guid idDoctor, string nameUser)
        {
            try
            {
                // Notification for new rating
                // Send notification to doctor
                var notice = new NotificationForNewRatingModel
                {
                    Title = AppString.TITLE_NEW_RATING,
                    Body = AppString.BODY_NEW_RATING + nameUser,
                    CreatedAt = DateTime.Now,
                    IdDoctor = idDoctor,
                    NameUser = nameUser,

                    NotificationType = AppNumber.NOTIFICATIONTYPE_RATING,

                };

                // Save the notification to Firestore
                await _firestoreService.AddDocumentAsync("notifications", null, null, null, null, null, notice);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public async Task CreateNotificationForReschedulingAppointment(UpdateAppointmentModel model, Guid idUser)
        {
            try
            {
                // Notification for creating new appointment
                // Send notification to doctor
                var notice = new NotificationReschedulingAppointmentForUserModel
                {
                    Title = AppString.TITLE_RESCHEDULED_SUCCESSFUL,
                    Body = AppString.BODY_RESCHEDULED_SUCCESSFUL,
                    CreatedAt = DateTime.Now,
                    IdUser = idUser,
                    IdAppointment = model.IdAppointment,
                    NotificationType = AppNumber.NOTIFICATIONTYPE_APPOINTMENT,
                    Date = model.Date.Date,
                    StartTime = model.StartTime,
                    EndTime = model.EndTime
                };

                // Save the notification to Firestore
                await _firestoreService.AddDocumentAsync("notifications", null, null, null, null, null, null, null, notice);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
