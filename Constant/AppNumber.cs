namespace BE_Healthcare.Constant
{
    public class AppNumber
    {
        public static int BUSY = 1;
        public static int BREAK = 2;

        public static int PENDING = 0;
        public static int APPROVED = 1;
        public static int REJECTED = 2;
        public static int ROLE_USER = 1;
        public static int ROLE_DOCTOR = 2;
        public static int ROLE_ADMIN = 3;
        public static int ROLE_ALL = 0;

        public static int APPOINTMENT_CONFIRMED = 1;
        public static int APPOINTMENT_CANCELED = 2;
        public static int APPOINTMENT_COMPLETED = 3;
        
        public static int PAGE_SIZE = 3;

        public static int STATUS_ALL = -1;
        public static int STATUS_ACTIVE = 0;
        public static int STATUS_LOCKED = 1;

        public static int NOTIFICATIONTYPE_APPOINTMENT = 1;
        public static int NOTIFICATIONTYPE_APPLYINGDOCTOR = 2;


        public static int TYPEPARTNER_PARTNER_REGISTRATIONFORM = 1;
        public static int TYPEPARTNER_DOCTOR_INFORMATION_PENDING_APPROVAL = 2;

    }
}
