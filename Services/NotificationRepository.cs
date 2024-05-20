using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models.Notification;
using BE_Healthcare.Models;

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
                    IdDoctor = model.IdDoctor,
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
    }
}
