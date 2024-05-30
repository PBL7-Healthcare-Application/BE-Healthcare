namespace BE_Healthcare.Constant
{
    public class AppString
    {
        public static string MESSAGE_INCORRECT_EMAIL = "The format of the email address isn't correct";
        public static string MESSAGE_INVALID_PASSWORD = "Password must have at least 8 characters and 1 uppercase letter and 1 special character.";
        public static string MESSAGE_NOTFOUND_USER = "User is not found!";
        public static string MESSAGE_SERVER_ERROR = "Internal Server Error";
        public static string MESSAGE_AUTH_SUCCESS= "Authenticate success";
        public static string MESSAGE_ACCESSTOKEN_NOT_EXPIRED = "Access token has not yet expired";
        public static string MESSAGE_REFRESHTOKEN_NOT_EXIST= "Refresh token does not exist";
        public static string MESSAGE_REFRESHTOKEN_USED = "Refresh token has been used";
        public static string MESSAGE_REFRESHTOKEN_REVOKED = "Refresh token has been revoked";
        public static string MESSAGE_ACCESSTOKEN_NOT_MATCHED = "Token doesn't match";
        public static string MESSAGE_RENEW_TOKEN_SUCCESS = "Renew token success";
        public static string MESSAGE_INVALID_TOKEN = "Invalid Token";
        public static string MESSAGE_PASSWORD_NOT_MATCH = "Password is not match!";
        public static string MESSAGE_EMAIL_EXIST = "The email address is already exist!";
        public static string MESSAGE_EMAIL_SUBJECT = "OTP Confirmation for your Enclinic account";
        public static string MESSAGE_EMAIL_CONTENT = " is your code to validate your account. Your code expires in 2 minutes.";
        public static string MESSAGE_EMAIL_VERIFIED = "Email Verified Successfully";
        public static string MESSAGE_OTP_EXPIRED = "OTP code is expired";
        public static string MESSAGE_OTP_NOTMATCH = "OTP Code doesn't match";
        public static string MESSAGE_OTP_SENT_SUCCESSFUL= "An OTP has been sent to your email. Please enter the OTP to complete registration.";
        public static string MESSAGE_OTP_RESEND = "OTP is resent successful, please check your email.";
        public static string MESSAGE_OTP_CREATIONTIME_NULL = "OTP creation time is null.";
        public static string MESSAGE_GETDATA_SUCCESS = "Get data success";
        public static string MESSAGE_NOTFOUND_DOCTOR = "Doctor is not found!";
        public static string MESSAGE_EMAIL_NULL = "Email is null!";
        public static string MESSAGE_BOOKAPPOINTMENT_ERROR = "You (Doctor) cannot make your own appointments";
        public static string MESSAGE_OVERLAP_TIMEOFF = "Can't book this time because doctor is off at this time";
        public static string MESSAGE_OVERLAP_TIMEOFF_BREAK = "Can't book this time because doctor is resting at this time";
        public static string MESSAGE_ERROR_TIMESLOT_ISSET = "This time slot has been booked in advance, please check again";
        public static string MESSAGE_ERROR_INVALID_TIME = "Invalid time!";
        public static string MESSAGE_SCHEDULED_SUCCESSFUL = "Successfully scheduled a medical examination!";
        public static string MESSAGE_ERROR_DOCTOR_NOTSETUPCHEDULES = "This doctor hasn't set up his schedules.";
        public static string MESSAGE_REGISTERDOCTOR_SUCCESS = "Your information has been submitted, please wait for Admin to approve your information.";
        public static string MESSAGE_ADDCERTIFICATE_SUCCESS = "Add certificate successfully!";
        public static string MESSAGE_ADDLISTCERTIFICATE_SUCCESS = "Add list certificate successfully!";
        public static string MESSAGE_ADDWORKINGPROCESS_SUCCESS = "Add working process successfully!";
        public static string MESSAGE_ADDLISTWORKINGPROCESS_SUCCESS = "Add list working process successfully!";
        public static string MESSAGE_ADDTRAININGPROCESS_SUCCESS = "Add training process successfully!";
        public static string MESSAGE_ADDLISTTRAININGPROCESS_SUCCESS = "Add list training process successfully!";
        public static string MESSAGE_LISTAPPOINTMENT_EMPTY = "There are no upcoming appointments.";

        public static string MESSAGE_EMAIL_SUBJECT_RESETPASS = "Reset Password for your Enclinic account";
        public static string MESSAGE_EMAIL_CONTENT_RESETPASS = "Here is the new password for your account. Use it to login then change your password: \n\n";
        public static string MESSAGE_RESETPASSWORD_SUCCESS = "Reset password successfully. Please Please check your email to get new password.";
        
        public static string MESSAGE_CHANGEPASSWORD_SUCCESS = "Change password successfully!";
        public static string MESSAGE_UPDATEPROFILE_SUCCESS = "Update Profile Successfully!";
        public static string MESSAGE_SIGNOUT_SUCCESS = "Sign out Successfully!";

        public static string MESSAGE_LOCKACCOUNT_SUCCESS = "Lock Account Successfully!";
        public static string MESSAGE_NOTFOUND_APPOINTMENT = "Appointment is not found!";
        public static string MESSAGE_CANCEL_APPOINTMENT_SUCCESS = "Cancel Appointment Successfully!";
        
        public static string MESSAGE_ERROR_INVALID_INFOR_CREATION = "Appointment creation information is invalid!";
        public static string MESSAGE_SETUP_SCHEDULE_SUCCESS = "Setup schedule successfully!";
        public static string MESSAGE_NOTALLOWED_SETUPSCHEDULE = "Not allowed to set up appointment schedules!";

        public static string MESSAGE_NOTALLOWED_CANCELAPPOINTMENT = "You are not allowed to cancel this appointment because this is not your appointment!";

        public static string MESSAGE_DISABLEACCOUNT_SUCCESS = "Disable Account Successfully!";
        public static string MESSAGE_ERROR_ACCOUNTDISABLED = "This account cannot be disabled because the admin has disabled it before.";
        public static string MESSAGE_ERROR_CANNOTDISABLEACCOUNT_USERHADDISABLED = "This account cannot be disabled because the user has already disabled it!";

        public static string MESSAGE_ERROR_ACCOUNT_DISABLED = "Your account has been disabled";
        
        public static string MESSAGE_LISTTIMEOFF_EMPTY = "There are no Time Off.";
        public static string MESSAGE_ERROR_LISTTIMEOFF_EMPTY = "Error no input data.";
        public static string MESSAGE_ERROR_TIMELINE_ESTABLISHED = "This timeline has been established!";
        
        public static string MESSAGE_ADDTIMEOFF_SUCCESS = "Add Time Off successfully!";

        public static string MESSAGE_SEND_NOTIFICATION_SUCCESS = "Send Notification successfully!";

        public static string TITLE_CREATENEWAPPOINTMENT = "New Appointment";
        public static string BODY_CREATENEWAPPOINTMENT = "You have a new medical appointment.";

        public static string TITLE_CANCELAPPOINTMENT = "Cancel Appointment";
        public static string BODY_CANCELAPPOINTMENT = "Your medical appointment has been cancelled.";
        public static string PATH_CREDENTIALS = @"F:\PBL7\healthcare-2d0e4-firebase-adminsdk-20q4k-d55b92ccba.json";

        public static string MESSAGE_LISTPARTNER_EMPTY = "Partner list is empty.";
        public static string MESSAGE_NOTFOUND_PARTNER = "Partner is not found!";
        
        public static string MESSAGE_ERROR_APPLYPARTNER = "You have registered to become our partner, please wait for admin to approve your information!";
        public static string MESSAGE_VERIFYINFPARTNER_SUCCESS = "Verify information of doctor successfully.";
        public static string MESSAGE_VERIFYCERTIFICATE_SUCCESS = "Verify information of certificate successfully.";
        public static string MESSAGE_VERIFYWORKINGPROCESS_SUCCESS = "Verify information of working process successfully.";
        public static string MESSAGE_VERIFYTRAININGPROCESS_SUCCESS = "Verify information of training process successfully.";

        public static string MESSAGE_ERROR_APPOINTMENT_ISEVALUATED = "This appointment has been evaluated!";
        public static string MESSAGE_EVALUATED_SUCCESS = "You have rated this doctor successfully!";

        public static string MESSAGE_LISTRATING_EMPTY = "List rating is empty!";
        public static string MESSAGE_ADDMEDICALRECORD_SUCCESS = "Add Medical record successfully!";

        public static string MESSAGE_ERROR_MEDICALRECORD_NOTALLOWTOCREATE = "You are not allow to create this medical record!";
        public static string MESSAGE_UPDATEPROFILEDOCTOR_SUCCESS = "Update Profile Doctor Successfully!";

        public static string MESSAGE_ERROR_EDITWORKINGTIME_CONFLICTWITHAPPOINTMENT = "There is a conflict with some appointments: Appointments outside of working hours that you want to update. If you click confirm update, the system will cancel all those appointments and update the working time again";
        
        public static string MESSAGE_ERROR_ACCOUNTNOTDISABLED = "This account has not been disabled, so you do not need to unlock it.";
        public static string MESSAGE_ERROR_CANNOTUNLOCKACCOUNT_USERHADDISABLED = "You cannot unlock this account because the user has already disabled it!";

        public static string MESSAGE_UNLOCKACCOUNT_SUCCESS = "Unlock Account Successfully!";
        public static string MESSAGE_LISTEXAMINATION_EMPTY = "There are no upcoming examinations.";
        
        public static string MESSAGE_NOTFOUND_CERTIFICATE = "Certificate is not found!";
        public static string MESSAGE_ERROR_UPDATECERTIFICATE_NOTALLOWTOUPDATE = "This certificate is not yours. Therefore, you do not have permission to edit it!";
        public static string MESSAGE_UPDATECERTIFICATE_SUCCESS = "Update Certificate Successfully!";
        public static string MESSAGE_UPDATETRAININGPROCESS_SUCCESS = "Update Training Process Successfully!";
        public static string MESSAGE_UPDATEWORKINGPROCESS_SUCCESS = "Update Working Process Successfully!";

        public static string MESSAGE_DELETECERTIFICATE_SUCCESS = "Delete Certificate Successfully!";
        
        
        public static string MESSAGE_NOTFOUND_WORKINGPROCESS = "Working Process is not found!";
        public static string MESSAGE_DELETEWORKINGPROCESS_SUCCESS = "Delete Working Process Successfully!";

        public static string MESSAGE_NOTFOUND_TRAININGPROCESS = "Training Process is not found!";
        public static string MESSAGE_DELETETRAININGPROCESS_SUCCESS = "Delete Training Process Successfully!";
        
        public static string MESSAGE_ERROR_IDDOCTOR_NOTNULL = "IdDoctor is not null!";
        public static string MESSAGE_RESCHEDULE_APPOINTMENT = "Book a follow-up examination.";

        public static string MESSAGE_RESCHEDULED_SUCCESSFUL = "Successfully rescheduled a medical examination!";
        public static string TITLE_CREATEREEXAMINATIONAPPOINTMENT = "Re-examination appointment";
        public static string BODY_CREATEREEXAMINATIONAPPOINTMENT = "You have a new re-examination medical appointment.";

        public static string MESSAGE_ERROR_GETDETAIL_ADMIN = "Can't get infomation of admin!";

    }
}
