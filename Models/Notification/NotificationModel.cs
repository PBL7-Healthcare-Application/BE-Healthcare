using BE_Healthcare.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Models.Notification
{
    public class NotificationModel : SlotAppointmentModel
    {
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public bool IsRead { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public int IdAppointment { get; set; }

        public int NotificationType { get; set; } //1: Notification of Appointment; 2: Notification of Applying Doctor
    }
}
