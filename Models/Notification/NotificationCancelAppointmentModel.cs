namespace BE_Healthcare.Models.Notification
{
    public class NotificationCancelAppointmentModel : NotificationModel
    {
        public string? Reason { get; set; } = null;
        public Guid? idDoctorCancel { get; set; } = null!;
        public Guid? idUserCancel { get; set; } = null!;
        public Guid? idReceiver { get; set; } = null!;
    }
}
