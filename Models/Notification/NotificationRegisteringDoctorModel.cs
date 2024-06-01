namespace BE_Healthcare.Models.Notification
{
    public class NotificationRegisteringDoctorModel : NotificationVerifyingDoctorModel
    {
        public string NameDoctor { get; set; } = null!;
        public Guid IdAdmin { get; set; }

    }
}
