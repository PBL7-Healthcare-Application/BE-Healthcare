using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IAppointmentRepository
    {
        List<Appointment>? GetAppointmentByIdDoctor(Guid idDoctor);
        ApiResponse CreateAppointment(Guid idUser, AppointmentModel model);
        void AddAppointment(Guid idUser, AppointmentModel model);
        //public int CalculateFreeSlot(Guid idDoctor);
    }
}
