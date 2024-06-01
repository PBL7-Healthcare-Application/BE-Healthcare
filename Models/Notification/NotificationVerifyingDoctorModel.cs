namespace BE_Healthcare.Models.Notification
{
    public class NotificationVerifyingDoctorModel
    {
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public bool IsRead { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public Guid IdDoctor { get; set; }

        public int NotificationType { get; set; } //1: Notification of Appointment; 2: Notification of Applying Doctor
    }
}
