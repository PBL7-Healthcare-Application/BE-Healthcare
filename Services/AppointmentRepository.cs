using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Authentication.SignUp;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace BE_Healthcare.Services
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly MyDbContext _context;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IUserRepository _userRepository;


        public AppointmentRepository(MyDbContext context, IDoctorRepository doctorRepository, IUserRepository userRepository)
        {
            _context = context;
            _doctorRepository = doctorRepository;
            _userRepository = userRepository;
        }
        public List<Appointment>? GetAppointmentByIdDoctor(Guid idDoctor)
        {
            try
            {
                var listAppointment = _context.Appointments.Include(e => e.Doctor)
                    .AsQueryable().Where(e => e.IdDoctor == idDoctor);

                if (listAppointment.Any())
                {
                    //listAppointment = listAppointment.OrderBy(a => a.StartTime);
                    return listAppointment.ToList();
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }



        public ApiResponse CreateAppointment(Guid idUser, AppointmentModel model)
        {
            //1. Check idDoctor is null or not
            var doctor = _doctorRepository.GetDoctorById(model.IdDoctor);
            if (doctor == null)
            {
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_NOTFOUND_DOCTOR,
                };
            }

            //2. Check idUser of doctor != idUser 
            if(doctor.User.IdUser == idUser)
            {
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_BOOKAPPOINTMENT_ERROR,
                };
            }


            //3. Check time book is valid

            TimeSpan startTime_Book = TimeSpan.Parse(model.StartTime);
            TimeSpan endTime_Book = TimeSpan.Parse(model.EndTime);

            if (doctor.WorkingTimeStart != null && doctor.WorkingTimeEnd != null && doctor.DurationPerAppointment != null)
            {
                if (startTime_Book < TimeSpan.Parse(doctor.WorkingTimeStart) && startTime_Book >= TimeSpan.Parse(doctor.WorkingTimeEnd))
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_ERROR_INVALID_TIME,
                    };
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




            //4. Check Time Off of Doctor
            var date_book = model.Date;
            Console.WriteLine("Day book: " + date_book.ToShortDateString() + "\n");
            var list_TimeOff = _doctorRepository.GetTimeOffByIdDoctor(model.IdDoctor).Where(d => d.Date.ToShortDateString() == date_book.ToShortDateString());

            foreach (var i in list_TimeOff)
            {
                TimeSpan startTime_timeoff = TimeSpan.Parse(i.StartTime);
                TimeSpan endTime_timeoff = TimeSpan.Parse(i.EndTime);
                if (startTime_Book >= startTime_timeoff && startTime_Book < endTime_timeoff) // Book time is overlaps with off time
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_OVERLAP_TIMEOFF,
                    };
                }
            }

            //5. Check List Appointment of Doctor

            var list_appointment = GetAppointmentByIdDoctor(model.IdDoctor).Where(e => e.Date.ToShortDateString() == date_book.ToShortDateString());

            if(list_appointment.Any())
            {
                foreach (var i in list_appointment)
                {
                    TimeSpan startTime_appointmentbooked = TimeSpan.Parse(i.StartTime);
                    TimeSpan endTime_appointmentbooked = TimeSpan.Parse(i.EndTime);
                    if (startTime_Book >= startTime_appointmentbooked && startTime_Book < endTime_appointmentbooked) // Book time is overlaps with another appoOntment
                    {
                        return new ApiResponse
                        {
                            StatusCode = StatusCode.FAILED,
                            Message = AppString.MESSAGE_ERROR_TIMESLOT_ISSET,
                        };
                    }
                }
            }

            //check success
            AddAppointment(idUser, model);

            // Update free slot
            _context.SaveChanges();

            var dataUser = _userRepository.getUserById(idUser);
            var res = new ScheduleAppointmentSuccessfulModel
            {
                IdDoctor = model.IdDoctor,
                Name = doctor.User.Name,
                Address = doctor.User.Address,
                StartTime = model.StartTime,
                EndTime = model.EndTime,
                Date = model.Date,
                Issue = model.Issue,
                Type = model.Type,
                Price = doctor.Price,
                Avatar_Doctor = doctor.User.Avatar,
                IdUser = idUser,
                Name_User = dataUser.Name,
                Avatar_User = dataUser.Avatar,
            };

            return new ApiResponse
            {
                StatusCode = StatusCode.SUCCESS,
                Message = AppString.MESSAGE_SCHEDULED_SUCCESSFUL,
                Data = res
            };


            throw new NotImplementedException();
        }

        public void AddAppointment(Guid idUser, AppointmentModel model)
        {
            try
            {
                var _appointment = new Appointment
                {
                    StartTime = model.StartTime,
                    EndTime = model.EndTime,
                    Date = model.Date,
                    Issue = model.Issue,
                    Status = 1,  //Status: 1 - Approved; 2 - Reject
                    Type = model.Type,
                    IdDoctor = model.IdDoctor,
                    IdUser = idUser
                };

                _context.Add(_appointment);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //public int CalculateFreeSlot(Guid idDoctor)
        //{
        //    var doctor = _doctorRepository.GetDoctorById(idDoctor);
        //    if (doctor == null)
        //    {
        //        return -1;
        //    }
        //    TimeSpan startTime = TimeSpan.Parse(doctor.WorkingTimeStart);
        //    TimeSpan endTime= TimeSpan.Parse(doctor.WorkingTimeEnd);
        //    TimeSpan totalHours = endTime - startTime;
        //    int count = (int)totalHours.TotalHours;
        //    int totalSlot = count / (doctor.DurationPerAppointment);
        //    var listAppointment = GetAppointmentByIdDoctor(idDoctor);
        //    int SlotAppointment = 0;
        //    if(listAppointment != null)
        //    {
        //        SlotAppointment = listAppointment.Count; 
        //    }
        //    return totalSlot-SlotAppointment;
        //}


    }
}
