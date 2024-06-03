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
        public async Task AddDocumentAsync(string collectionId, 
            NotificationForDoctorModel? notification = null, 
            NotificationCancelAppointmentModel? notifCancel = null, 
            NotificationReschedulingForUserModel? noticeRescheduling = null,
            NotificationRegisteringDoctorModel? noticeRegisteringDoctor = null,
            NotificationVerifyingDoctorModel? notificationVerifyingDoctorModel= null,
            NotificationForNewRatingModel? notificationForNewRatingModel = null,
            NotificationDoctorAddOrEditInfoModel? notificationDoctorAddOrEditInfo = null)
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

                if (noticeRegisteringDoctor != null)
                {
                    notificationData = new Dictionary<string, object>
                    {
                        { "title",  noticeRegisteringDoctor.Title },
                        { "body",  noticeRegisteringDoctor.Body},
                        { "isRead", noticeRegisteringDoctor.IsRead},
                        { "createAt", noticeRegisteringDoctor.CreatedAt.ToString()},
                        { "notificationType", noticeRegisteringDoctor.NotificationType },
                        { "idDoctor",  noticeRegisteringDoctor.IdDoctor.ToString() },
                        { "NameDoctor",  noticeRegisteringDoctor.NameDoctor.ToString() },
                        { "idAdmin",  noticeRegisteringDoctor.IdAdmin.ToString() },
                        { "timestamp", Timestamp.GetCurrentTimestamp()},
                    };
                    CollectionReference collectionRef = _db.Collection(collectionId);
                    await collectionRef.AddAsync(notificationData);
                }

                if (notificationVerifyingDoctorModel != null)
                {
                    notificationData = new Dictionary<string, object>
                    {
                        { "title",  notificationVerifyingDoctorModel.Title },
                        { "body",  notificationVerifyingDoctorModel.Body},
                        { "isRead", notificationVerifyingDoctorModel.IsRead},
                        { "createAt", notificationVerifyingDoctorModel.CreatedAt.ToString()},
                        { "notificationType", notificationVerifyingDoctorModel.NotificationType },
                        { "idDoctor",  notificationVerifyingDoctorModel.IdDoctor.ToString() },
                        { "timestamp", Timestamp.GetCurrentTimestamp()},
                    };
                    CollectionReference collectionRef = _db.Collection(collectionId);
                    await collectionRef.AddAsync(notificationData);
                }

                if (notificationForNewRatingModel != null)
                {
                    notificationData = new Dictionary<string, object>
                    {
                        { "title",  notificationForNewRatingModel.Title },
                        { "body",  notificationForNewRatingModel.Body},
                        { "nameUser",  notificationForNewRatingModel.NameUser},
                        { "isRead", notificationForNewRatingModel.IsRead},
                        { "createAt", notificationForNewRatingModel.CreatedAt.ToString()},
                        { "notificationType", notificationForNewRatingModel.NotificationType },
                        { "idDoctor",  notificationForNewRatingModel.IdDoctor.ToString() },
                        { "timestamp", Timestamp.GetCurrentTimestamp()},
                    };
                    CollectionReference collectionRef = _db.Collection(collectionId);
                    await collectionRef.AddAsync(notificationData);
                }

                if (notificationDoctorAddOrEditInfo != null)
                {
                    notificationData = new Dictionary<string, object>
                    {
                        { "title",  notificationDoctorAddOrEditInfo.Title },
                        { "body",  notificationDoctorAddOrEditInfo.Body},
                        { "isRead", notificationDoctorAddOrEditInfo.IsRead},
                        { "createAt", notificationDoctorAddOrEditInfo.CreatedAt.ToString()},
                        { "notificationType", notificationDoctorAddOrEditInfo.NotificationType },
                        { "idDoctor",  notificationDoctorAddOrEditInfo.IdDoctor.ToString() },
                        { "NameDoctor",  notificationDoctorAddOrEditInfo.NameDoctor.ToString() },
                        { "idAdmin",  notificationDoctorAddOrEditInfo.IdAdmin.ToString() },
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
