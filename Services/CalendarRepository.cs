using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BE_Healthcare.Services
{
    public class CalendarRepository : ICalendarRepository
    {
        private readonly MyDbContext _context;
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IDoctorRepository _doctorRepository;

        public CalendarRepository(MyDbContext context, IAppointmentRepository appointmentRepository, IDoctorRepository doctorRepository)
        {
            _context = context;
            _appointmentRepository = appointmentRepository;
            _doctorRepository = doctorRepository;
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
        private void AddTimeOff(Guid idDoctor, InformationTimeOffModel info)
        {
            var timeoff = new TimeOff
            {
                Date = info.Date,
                StartTime = info.StartTime,
                EndTime = info.EndTime,
                IdDoctor = idDoctor,
                Status = info.Status,
                Reason = info.Reason,
            };
            _context.TimeOffs.Add(timeoff);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        private ApiResponse? CheckTimeOffIsValid(Guid id, List<InformationTimeOffModel> listCreateTimeOff)
        {
            var doctor = _doctorRepository.GetDoctorById(id);
            if(doctor == null) return new ApiResponse
            {
                StatusCode = StatusCode.FAILED,
                Message = AppString.MESSAGE_NOTFOUND_DOCTOR,
            };
            if(doctor.WorkingTimeStart != null && doctor.WorkingTimeEnd != null && doctor.DurationPerAppointment != null)
            {
                foreach (var TimeOff in listCreateTimeOff)
                {
                     var check = _appointmentRepository.CheckTimeIsValid(TimeSpan.Parse(TimeOff.StartTime), TimeSpan.Parse(doctor.WorkingTimeStart), TimeSpan.Parse(doctor.WorkingTimeEnd));
                    if (check != null) return check;
                }
            }
            else
            {
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_ERROR_DOCTOR_NOTSETUPCHEDULES,
                };
            }
            return null;    //pass
            
        }
        public ApiResponse CreateTimeOff(Guid id, List<InformationTimeOffModel> listCreateTimeOff)
        {
            try
            {
                if(listCreateTimeOff.IsNullOrEmpty())
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_ERROR_LISTTIMEOFF_EMPTY,
                    };
                }
                var checklistTimeOffIsValid = CheckTimeOffIsValid(id, listCreateTimeOff);
                if (checklistTimeOffIsValid != null) return checklistTimeOffIsValid;

                var list = GetTimeOff(id);
                if(list != null)
                {
                    foreach(var TimeOff in listCreateTimeOff)
                    {
                        TimeSpan startTime_TimeOff = TimeSpan.Parse(TimeOff.StartTime);
                        TimeSpan endTime_TimeOff = TimeSpan.Parse(TimeOff.EndTime);
                        foreach (var item in list.Where(p => p.Date.Date == TimeOff.Date.Date || p.Status == AppNumber.BREAK).ToList())
                        {
                            if(TimeSpan.Parse(item.StartTime) == startTime_TimeOff && 
                                TimeSpan.Parse(item.EndTime) == endTime_TimeOff)
                            {
                                return new ApiResponse
                                {
                                    StatusCode = StatusCode.FAILED,
                                    Message = AppString.MESSAGE_ERROR_TIMELINE_ESTABLISHED,
                                };
                            }
                        }
                    }
                }

                foreach (var TimeOff in listCreateTimeOff)
                {
                    AddTimeOff(id, TimeOff);
                }
                Save();
                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_ADDTIMEOFF_SUCCESS,
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
