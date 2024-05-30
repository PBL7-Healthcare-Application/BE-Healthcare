using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface INotificationRepository
    {
        Task CreateNotificationForCreatingAppointment(AppointmentModel model);
        Task CreateNotificationForCancellingAppointment(CancelAppointmentModel model, Appointment appointment, Guid? idReceiver);
        Task CreateNotificationForReExaminationAppointment(ReExaminationAppointmentModel model);


    }
}
