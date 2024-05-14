using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Authentication.SignUp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Numerics;

namespace BE_Healthcare.Services
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly MyDbContext _context;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IAuthRepository _authRepository;


        public AppointmentRepository(MyDbContext context, IDoctorRepository doctorRepository, IAuthRepository authRepository)
        {
            _context = context;
            _doctorRepository = doctorRepository;
            _authRepository = authRepository;
        }
        public List<Appointment>? GetListAppointmentByIdDoctor(Guid idDoctor, int? Status = 1, string? search = null)
        {
            try
            {
                var listAppointment = _context.Appointments.Include(e => e.User).Include(d => d.Doctor)
                    .Where(e => e.IdDoctor == idDoctor);
                if(Status > 0 && Status <= 3)
                {
                    listAppointment = listAppointment.Where(e => e.Status == Status);
                }
                if (listAppointment == null)
                {
                    //listAppointment = listAppointment.OrderBy(a => a.StartTime);
                    return null;

                }

                //Filter
                if(search != null)
                {
                    listAppointment = listAppointment.Where(p => p.User.Name.Contains(search));
                }
                return listAppointment.ToList();
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
            //Console.WriteLine("Day book: " + date_book.ToShortDateString() + "\n");
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

            var list_appointment = GetListAppointmentByIdDoctor(model.IdDoctor).Where(e => e.Date.ToShortDateString() == date_book.ToShortDateString());

            if(list_appointment != null)
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
            model.Price = doctor.Price;
            //check success
            AddAppointment(idUser, model);

            // Update free slot
            _context.SaveChanges();

            var dataUser = _authRepository.getUserById(idUser);
            if (dataUser == null)
            {
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_NOTFOUND_USER,
                };
            }
            var res = new ScheduleAppointmentSuccessfulModel
            {
                IdDoctor = model.IdDoctor,
                NameDoctor = doctor.User.Name,
                Address = doctor.User.Address,
                StartTime = model.StartTime,
                EndTime = model.EndTime,
                Date = model.Date,
                Issue = model.Issue,
                Type = model.Type,
                Price = doctor.Price,
                AvatarDoctor = doctor.User.Avatar,
                IdUser = idUser,
                NameUser = dataUser.Name,
                AvatarUser = dataUser.Avatar,
                EmailUser = dataUser.Email,
                NameClinic = doctor.NameClinic,
                NameMedicalSpecialty = doctor.MedicalSpecialty.Name

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
                    Status = 1,  //Status: 1 - Approved; 2 - Reject; 3 - Completed
                    Type = model.Type,
                    IdDoctor = model.IdDoctor,
                    IdUser = idUser,
                    Price = model.Price
                };

                _context.Add(_appointment);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public ApiResponse GetAppointmentByIdUser(Guid idUser, int? Status = null)
        {
            try
            {
                UpdateStatusAppointment(null,idUser);

                var listAppointment = _context.Appointments.Include(e => e.User).Include(d => d.Doctor)
                    .AsQueryable().Where(e => e.IdUser == idUser); // 

                //Filtering
                if (Status.HasValue)
                {
                    listAppointment = listAppointment.Where(l => l.Status == Status);
                }

                //Sorting
                listAppointment = listAppointment.OrderBy(e => e.IdAppointment);


                if (listAppointment.Any())
                {
                    var res = listAppointment.Select(a => new MyAppointmentModel
                    {
                        IdDoctor = (Guid)a.IdDoctor,
                        NameDoctor = a.Doctor.User.Name,
                        MedicalSpecialty = a.Doctor.MedicalSpecialty.Name,
                        AvatarDoctor = a.User.Avatar,
                        IdAppointment = a.IdAppointment,
                        StartTime = a.StartTime,
                        EndTime = a.EndTime,
                        Date = a.Date,
                        Type = a.Type,
                        Status = a.Status,
                        Issue = a.Issue,
                        Address = a.Doctor.User.Address,
                        NameClinic = a.Doctor.NameClinic,
                        Price = a.Price,
                        
                        
                    });
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.SUCCESS,
                        Message = AppString.MESSAGE_GETDATA_SUCCESS,
                        Data = res
                    };
                }
                else
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_LISTAPPOINTMENT_EMPTY,
                    };
                }
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

        public ApiResponse CancelAppointment(CancelAppointmentModel model, Guid? idUserCancel = null, Guid? idDoctorCancel = null)
        {
            try
            {
                var appointment = GetAppointmentByIdAppointment(model.idAppointment);
                if(appointment == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_APPOINTMENT,
                    };
                }



                if(idUserCancel != null)
                {
                    if(appointment.IdUser != idUserCancel)
                    {
                        return new ApiResponse
                        {
                            StatusCode = StatusCode.FAILED,
                            Message = AppString.MESSAGE_NOTALLOWED_CANCELAPPOINTMENT,
                        };
                    }
                    appointment.idUserCancel = idUserCancel;
                }
                else if(idDoctorCancel != null)
                {
                    if (appointment.IdDoctor != idDoctorCancel)
                    {
                        return new ApiResponse
                        {
                            StatusCode = StatusCode.FAILED,
                            Message = AppString.MESSAGE_NOTALLOWED_CANCELAPPOINTMENT,
                        };
                    }
                    appointment.idDoctorCancel = idDoctorCancel;
                }
                appointment.Reason = model.Reason;
                appointment.Status = 2;

                _context.Update(appointment);
                _context.SaveChanges();
                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_CANCEL_APPOINTMENT_SUCCESS,
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

        public ApiResponse GetAppointmentByIdDoctor(Guid idDoctor, AppointmentSearchCriteriaModel criteria) // Default APPOINTMENT_CONFIRMED
        {
            try
            {
                if(criteria.Status == AppNumber.APPOINTMENT_CONFIRMED)
                {
                    UpdateStatusAppointment(idDoctor);
                }
                var listAppointment = GetListAppointmentByIdDoctor(idDoctor, criteria.Status, criteria.search);

                //Filtering
                if (criteria.filterAvailable != null)
                {
                    DateTime t;
                    if (criteria.filterAvailable == "TODAY")
                    {
                        t = DateTime.Now.Date;
                        listAppointment = listAppointment.Where(d => d.Date == t).ToList();
                    }
                    if (criteria.filterAvailable == "TOMORROW")
                    {
                        t = DateTime.Now.AddDays(1).Date;
                        listAppointment = listAppointment.Where(d => d.Date == t).ToList();
                    }
                }

                //Sorting
                if (listAppointment == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_LISTAPPOINTMENT_EMPTY,
                    };
                }
                
                listAppointment = listAppointment.OrderBy(e => e.IdAppointment).ToList();

                listAppointment = listAppointment.Skip((criteria.page - 1) * AppNumber.PAGE_SIZE).Take(AppNumber.PAGE_SIZE).ToList();

                var res = listAppointment.Select(a => new AppointmentManagementModel
                {
                    IdAppointment = a.IdAppointment,
                    StartTime = a.StartTime,
                    EndTime = a.EndTime,
                    Date = a.Date,
                    NamePatient = a.User.Name,
                    PhoneNumber = a.User.PhoneNumber,
                    Email = a.User.Email,
                    Status = a.Status,
                });
                return new ApiResponseWithPaging
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_GETDATA_SUCCESS,
                    Data = res,
                    PagingInfo = new PagingInfoModel
                    {
                        TotalItems = listAppointment.Count(),
                        CurrentPage = criteria.page,
                        ItemsPerPage = AppNumber.PAGE_SIZE
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
        private List<Appointment>? GetListAppointmentNotUpdate(Guid? idDoctor = null, Guid? idUser = null)
        {
            if (idDoctor == null && idUser == null) return null;
            var listAppointmentCompleted = _context.Appointments.Include(e => e.User).Include(d => d.Doctor)
            .Where(e => e.Date <= DateTime.UtcNow.Date && e.Status == AppNumber.APPROVED);
            if (idDoctor != null)
            {
                listAppointmentCompleted = listAppointmentCompleted.Where(e => e.IdDoctor == idDoctor);
            }
            else if (idUser != null)
            {
                listAppointmentCompleted = listAppointmentCompleted.Where(e => e.IdUser == idUser);
            }

            return listAppointmentCompleted.ToList();
        }
        public void UpdateStatusAppointment (Guid? idDoctor = null, Guid? idUser = null)
        {
            //var listAppointmentCompleted = _context.Appointments.Include(e => e.User).Include(d => d.Doctor)
            //    .Where(e => e.IdDoctor == idDoctor && e.Date <= DateTime.UtcNow.Date && e.Status == AppNumber.APPROVED ).ToList();

            //var listAppointmentCompleted = listAppointment.Where(e => e.Date <= DateTime.UtcNow.Date && e.Status == AppNumber.APPROVED);
            var listAppointmentCompleted = GetListAppointmentNotUpdate(idDoctor, idUser);
            if (listAppointmentCompleted != null)
            {
                foreach (var item in listAppointmentCompleted)
                {
                    if (item.Date == DateTime.UtcNow.Date && !IsTimeAppointmentCompleted(item.Date.Date, item.EndTime))   //The present day
                    {
                        continue;
                    }
                    item.Status = AppNumber.APPOINTMENT_COMPLETED;
                }
                _context.Appointments.UpdateRange(listAppointmentCompleted);
                _context.SaveChanges();
            }
        }
        private bool IsTimeAppointmentCompleted (DateTime date, string timeEnd)
        {
            string dateOnly = date.ToString("M/d/yyyy");
            string dateTimeString = $"{dateOnly} {timeEnd}";

            DateTime TimeEndAppointment = DateTime.ParseExact(dateTimeString, "M/d/yyyy H:mm", null);

            // So sánh với thời điểm hiện tại
            if (TimeEndAppointment >= DateTime.Now)
            {
                return false;
            }
            return true;
        }

        public Appointment? GetAppointmentByIdAppointment(int idAppointment)
        {
            try
            {
                var appointment = _context.Appointments.Include(q  => q.User).Include(p => p.Doctor).ThenInclude(p => p.User)
                    .Where(e => e.IdAppointment == idAppointment).FirstOrDefault();
                if (appointment != null)
                {
                    //listAppointment = listAppointment.OrderBy(a => a.StartTime);
                    return appointment;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public ApiResponse SetupSchedule(Guid idDoctor, SetupScheduleModel model)
        {
            try
            {
                var doctor = _doctorRepository.GetDoctorById(idDoctor);
                if (doctor == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_DOCTOR,
                    };
                }
                if (doctor.StatusVerified == AppNumber.APPROVED && doctor.WorkingTimeStart == null)     //Doctor setup schedule the first time
                {
                    if (model.StartTime == null || model.EndTime == null || model.DurationPerAppointment < 0)
                    {
                        return new ApiResponse
                        {
                            StatusCode = StatusCode.FAILED,
                            Message = AppString.MESSAGE_ERROR_INVALID_INFOR_CREATION,
                        };

                    }
                    //UPDATE
                    doctor.WorkingTimeStart = model.StartTime;
                    doctor.WorkingTimeEnd = model.EndTime;
                    doctor.DurationPerAppointment = model.DurationPerAppointment;
                    _context.Doctors.Update(doctor);
                    _context.SaveChanges();
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.SUCCESS,
                        Message = AppString.MESSAGE_SETUP_SCHEDULE_SUCCESS,
                    };
                }
                else
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTALLOWED_SETUPSCHEDULE,
                    };
                }
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

        public List<SlotAppointmentModel>? GetListAppointmentofDoctorDetail(Guid idDoctor) // Default APPOINTMENT_CONFIRMED
        {
            UpdateStatusAppointment(idDoctor);

            var listAppointment = GetListAppointmentByIdDoctor(idDoctor);

            if (listAppointment == null)
            {
                return null;
            }

            var res = listAppointment.Select(a => new SlotAppointmentModel
            {
                StartTime = a.StartTime,
                EndTime = a.EndTime,
                Date = a.Date.Date,
            }).ToList();
            return res;


        }

        public ApiResponse GetAppointmentDetail(int id)
        {
            try
            {
                var appointment = GetAppointmentByIdAppointment(id);

                if (appointment == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_APPOINTMENT,
                    };
                }
                var res = new AppointmentDetailOfDoctorModel
                {
                    IdDoctor = (Guid)appointment.IdDoctor,
                    NameUser = appointment.User.Name,
                    AvatarUser = appointment.User.Avatar,

                    IdAppointment = appointment.IdAppointment,
                    StartTime = appointment.StartTime,
                    EndTime = appointment.EndTime,
                    Date = appointment.Date,
                    Type = appointment.Type,
                    Status = appointment.Status,
                    Issue = appointment.Issue,
                    Address = appointment.Doctor.User.Address,
                    NameClinic = appointment.Doctor.NameClinic,
                    Price = appointment.Price,
                };

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_GETDATA_SUCCESS,
                    Data = res
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
