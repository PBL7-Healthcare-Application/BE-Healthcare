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





    }
}
