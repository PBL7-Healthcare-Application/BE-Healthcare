using BE_Healthcare.Constant;
using BE_Healthcare.Models.Notification;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BE_Healthcare.Services
{
    public class FirestoreService
    {
        private readonly FirestoreDb _db;

        public FirestoreService(string projectId)
        {
            string pathToCredentials = AppString.PATH_CREDENTIALS;
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", pathToCredentials);
            _db = FirestoreDb.Create(projectId);
        }

        //public async Task AddDocumentAsync(string collectionId, string name, AppointmentModel model)
        public async Task AddDocumentAsync(string collectionId, NotificationForDoctorModel? notification = null, 
            NotificationCancelAppointmentModel? notifCancel = null, NotificationReschedulingForUserModel? noticeRescheduling = null)
        {
            try
            {
                object notificationData;
                if (notification != null)
                {
                    notificationData = new Dictionary<string, object>
                    {
                        { "title",  notification.Title },
                        { "body",  notification.Body},
                        { "isRead", notification.IsRead},
                        { "createAt", notification.CreatedAt.ToString()},
                        { "idAppointment", notification.IdAppointment },
                        { "notificationType", notification.NotificationType },
                        { "idDoctor",  notification.IdDoctor.ToString() },
                        { "dayOfExamination",  notification.Date.ToString() },
                        { "startTime",  notification.StartTime.ToString() },
                        { "endTime",  notification.EndTime.ToString() },


                        { "timestamp", Timestamp.GetCurrentTimestamp()},
                    };
                    CollectionReference collectionRef = _db.Collection(collectionId);
                    await collectionRef.AddAsync(notificationData);
                }

                if(notifCancel != null)
                {
                    if(notifCancel.idDoctorCancel != null)
                    {
                        notificationData = new Dictionary<string, object>
                        {
                            { "title",  notifCancel.Title },
                            { "body",  notifCancel.Body},
                            { "isRead", notifCancel.IsRead},
                            { "createAt", notifCancel.CreatedAt.ToString()},
                            { "idDoctorCancel", notifCancel.idDoctorCancel.ToString()},
                            { "idReceiver", notifCancel.idReceiver.ToString()},
                            { "idAppointment", notifCancel.IdAppointment },
                            { "notificationType", notifCancel.NotificationType },
                            { "dayOfExamination",  notifCancel.Date.ToString() },
                            { "startTime",  notifCancel.StartTime.ToString() },
                            { "endTime",  notifCancel.EndTime.ToString() },

                            { "timestamp", Timestamp.GetCurrentTimestamp()},
                        };
                        CollectionReference collectionRef = _db.Collection(collectionId);
                        await collectionRef.AddAsync(notificationData);
                    }
                    else if(notifCancel.idUserCancel != null) 
                    {
                        notificationData = new Dictionary<string, object>
                        {
                            { "title",  notifCancel.Title },
                            { "body",  notifCancel.Body},
                            { "isRead", notifCancel.IsRead},
                            { "createAt", notifCancel.CreatedAt.ToString()},
                            { "idUserCancel", notifCancel.idUserCancel.ToString()},
                            { "idReceiver", notifCancel.idReceiver.ToString()},
                            { "idAppointment", notifCancel.IdAppointment },
                            { "notificationType", notifCancel.NotificationType },
                            { "dayOfExamination",  notifCancel.Date.ToString() },
                            { "startTime",  notifCancel.StartTime.ToString() },
                            { "endTime",  notifCancel.EndTime.ToString() },

                            { "timestamp", Timestamp.GetCurrentTimestamp()},
                        };
                        CollectionReference collectionRef = _db.Collection(collectionId);
                        await collectionRef.AddAsync(notificationData);
                    }
                    
                }

                if (noticeRescheduling != null)
                {
                    notificationData = new Dictionary<string, object>
                    {
                        { "title",  noticeRescheduling.Title },
                        { "body",  noticeRescheduling.Body},
                        { "isRead", noticeRescheduling.IsRead},
                        { "createAt", noticeRescheduling.CreatedAt.ToString()},
                        { "idAppointment", noticeRescheduling.IdAppointment },
                        { "notificationType", noticeRescheduling.NotificationType },
                        { "idUser",  noticeRescheduling.IdUser.ToString() },
                        { "dayOfExamination",  noticeRescheduling.Date.ToString() },
                        { "startTime",  noticeRescheduling.StartTime.ToString() },
                        { "endTime",  noticeRescheduling.EndTime.ToString() },


                        { "timestamp", Timestamp.GetCurrentTimestamp()},
                    };
                    CollectionReference collectionRef = _db.Collection(collectionId);
                    await collectionRef.AddAsync(notificationData);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
