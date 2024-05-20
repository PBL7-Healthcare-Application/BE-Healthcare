using BE_Healthcare.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Models.Notification
{
    public class NotificationForDoctorModel : NotificationModel
    {
        public Guid IdDoctor { get; set; }
    }
}
