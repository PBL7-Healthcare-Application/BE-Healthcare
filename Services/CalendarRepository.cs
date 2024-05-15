using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using Microsoft.EntityFrameworkCore;

namespace BE_Healthcare.Services
{
    public class CalendarRepository : ICalendarRepository
    {
        private readonly MyDbContext _context;
        private readonly IAppointmentRepository _appointmentRepository; 

        public CalendarRepository(MyDbContext context, IAppointmentRepository appointmentRepository)
        {
            _context = context;
            _appointmentRepository = appointmentRepository;
        }

        private IQueryable<TimeOff>? GetTimeOff(Guid id)
        {
            var listTimeOff = _context.TimeOffs.Include(e => e.Doctor)
                .AsQueryable().Where(e => e.IdDoctor == id);
            return listTimeOff;
        }

        public List<TimeOffModel>? GetTimeOffByIdDoctor(Guid id)
        {
            var listTimeOff = GetTimeOff(id);
            if (listTimeOff == null) return null;
            var result_timeOff = listTimeOff.Select(c => new TimeOffModel
            {
                IdTimeOff = c.IdTimeOff,
                Date = c.Date,
                StartTime = c.StartTime,
                EndTime = c.EndTime,
                Status = c.Status,
                Reason = c.Reason
            }).ToList();
            return result_timeOff;
        }

        private List<AppointmentManagementModel>? CreateListAppointmentModel(List<Appointment>? list)
        {
            var res = list.Select(a => new AppointmentManagementModel
            {
                IdAppointment = a.IdAppointment,
                StartTime = a.StartTime,
                EndTime = a.EndTime,
                Date = a.Date,
                NamePatient = a.User.Name,
                PhoneNumber = a.User.PhoneNumber,
                Email = a.User.Email,
                Status = a.Status,
            }).ToList();
            return res;


        }

        public ApiResponse GetCalendar(Guid id)
        {
            try
            {
                var listTimeOff = GetTimeOffByIdDoctor(id);
                if(listTimeOff == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_LISTTIMEOFF_EMPTY,
                    };
                }

                _appointmentRepository.UpdateStatusAppointment(id);
                var listAppointmentAvailable = _appointmentRepository.GetListAppointmentByIdDoctor(id).ToList();
                var listAppointment = CreateListAppointmentModel(listAppointmentAvailable);
                
                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_GETDATA_SUCCESS,
                    Data = new CalendarModel
                    {
                        TimeOffs = listTimeOff,
                        Appointments = listAppointment
                    }
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_SERVER_ERROR,
                };
            }
        }
    }
}
