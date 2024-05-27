using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Extensions;
using BE_Healthcare.Models;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace BE_Healthcare.Services
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly MyDbContext _context;
        private readonly IAuthRepository _authRepository;
        private readonly IDoctorRepository _doctorRepository;
        private readonly ICertificateRepository _certificateRepository;
        private readonly IWorkingProcessRepository _workingProcessRepository;
        private readonly ITrainingProcessRepository _trainingProcessRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly INotificationRepository _notificationRepository;

        public ProfileRepository(MyDbContext context, IAuthRepository authRepository, 
            IDoctorRepository doctorRepository, ICertificateRepository certificateRepository,
            IWorkingProcessRepository workingProcessRepository, ITrainingProcessRepository trainingProcessRepository,
            IAppointmentRepository appointmentRepository, INotificationRepository notificationRepository)
        {
            _context = context;
            _authRepository = authRepository;
            _doctorRepository = doctorRepository;
            _certificateRepository = certificateRepository;
            _workingProcessRepository = workingProcessRepository;
            _trainingProcessRepository = trainingProcessRepository;
            _appointmentRepository = appointmentRepository;
            _notificationRepository = notificationRepository;
        }

        public ApiResponse ChangePassword(string email, ChangePasswordModel model)
        {
            try
            {
                if (!Extension.IsValidPassword(model.NewPassword))       //Validate New Password
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_INVALID_PASSWORD,
                    };
                }

                var user = _authRepository.getUserByEmail(email);
                if (user == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_USER,
                    };
                }

                var isValidPass = _authRepository.CheckPassword(user, model.OldPassword);   // Check Old Password
                if (!isValidPass)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_PASSWORD_NOT_MATCH,
                    };
                }

                //RESET NEW PASSWORD
                using var hashFunc = new HMACSHA256();
                var passwordBytes = Encoding.UTF8.GetBytes(model.NewPassword);
                user.PasswordHash = hashFunc.ComputeHash(passwordBytes);
                user.PasswordSalt = hashFunc.Key;

                _context.Users.Update(user);
                _context.SaveChanges();

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_CHANGEPASSWORD_SUCCESS,
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
        private ProfileModel CreateProfileModel(User u)
        {
            var res = new ProfileModel
            {
                IdUser = u.IdUser,
                Email = u.Email,
                Name = u.Name,
                DOB = u.DOB,
                Gender = u.Gender,
                PhoneNumber = u.PhoneNumber,
                Address = u.Address,
                Avatar = u.Avatar,
            };
            return res;
        }
        public ApiResponse GetPersonalInfo(string email)
        {
            try
            {
                if (email == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_EMAIL_NULL,
                    };
                }
                var info = _authRepository.getUserByEmail(email);
                if (info == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_USER,
                    };
                }
                var res = CreateProfileModel(info);
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

        public ApiResponse UpdateProfile(string email, UpdateProfileModel model)
        {
            try
            {

                var user = _authRepository.getUserByEmail(email);
                if (user == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_USER,
                    };
                }

                if (model.Name != null) user.Name = model.Name;
                if (model.DOB != null) user.DOB = model.DOB;
                if (model.PhoneNumber != null) user.PhoneNumber = model.PhoneNumber;
                if (model.Address != null) user.Address = model.Address;
                if (model.Avatar != null) user.Avatar = model.Avatar;
                if (model.Gender != null) user.Gender = model.Gender;
                user.UpdatedAt = DateTime.Now;
                _context.Update(user);
                _context.SaveChanges();

                var res = CreateProfileModel(user);

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_UPDATEPROFILE_SUCCESS,
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

        public ApiResponse LockAccount(Guid id, LockAccountModel model)
        {
            try
            {
                var user = _authRepository.getUserById(id);
                if (user == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_USER,
                    };
                }

                user.ReasonLockAccount = model.Reason;
                user.IsLocked = true;

                _context.Update(user);
                _context.SaveChanges();
                _authRepository.RemoveRefreshToken(id);
                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_LOCKACCOUNT_SUCCESS,
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

        private ProfileDoctorModel CreateProfileDoctorModel(Doctor u)
        {
            var listCertificate = _certificateRepository.GetCertificateByIdDoctor(u.IdDoctor);

            var listWorkingProcess = _workingProcessRepository.GetWorkingProcessByIdDoctor(u.IdDoctor);

            var listTrainingProcess = _trainingProcessRepository.GetTrainingProcessByIdDoctor(u.IdDoctor);
            var res = new ProfileDoctorModel
            {
                IdDoctor = u.IdDoctor,
                Email = u.User.Email,
                Name = u.User.Name,
                DOB = u.User.DOB,
                Gender = u.User.Gender,
                PhoneNumber = u.User.PhoneNumber,
                Address = u.User.Address,
                Avatar = u.User.Avatar,

                YearExperience = u.YearExperience,
                Price = u.Price,
                Description = u.Description,
                MedicalSpecialty = u.MedicalSpecialty.Name,
                Certificates = listCertificate,
                WorkingProcess = listWorkingProcess,
                TrainingProcess = listTrainingProcess,

                WorkingTimeStart = u.WorkingTimeStart,
                WorkingTimeEnd = u.WorkingTimeEnd,
                DurationPerAppointment = u.DurationPerAppointment,
                NameClinic = u.NameClinic,

                StatusVerified = u.StatusVerified

            };
            return res;
        }

        public ApiResponse GetPersonalDoctorInfo(Guid id)
        {
            try
            {
                var info = _doctorRepository.GetDoctorById(id);
                if (info == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_DOCTOR,
                    };
                }
                var res = CreateProfileDoctorModel(info);
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

        public ApiResponse UpdateProfileDoctor(Guid idDoctor, UpdateProfileDoctorModel model)
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

                if (model.Name != null) doctor.User.Name = model.Name;
                if (model.DOB != null) doctor.User.DOB = model.DOB;
                if (model.PhoneNumber != null) doctor.User.PhoneNumber = model.PhoneNumber;
                if (model.Address != null) doctor.User.Address = model.Address;
                if (model.Avatar != null) doctor.User.Avatar = model.Avatar;
                if (model.Gender != null) doctor.User.Gender = model.Gender;

                if (model.YearExperience != null) doctor.YearExperience = model.YearExperience;
                if (model.Price != null) doctor.Price = model.Price;
                if (model.Description != null) doctor.Description = model.Description;
                if (model.IdSpecialty != null && model.IdSpecialty != doctor.IdSpecialty) doctor.IdSpecialty = model.IdSpecialty;

                doctor.UpdatedAt = DateTime.Now;
                _context.Doctors.Update(doctor);
                _context.SaveChanges();


                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_UPDATEPROFILE_SUCCESS,
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

        private void UpdateWorkingTime(Doctor doctor, WorkingTimeModel model)
        {
            doctor.WorkingTimeStart = model.StartTime;
            doctor.WorkingTimeEnd = model.EndTime;
            doctor.DurationPerAppointment = model.DurationPerAppointment;
            _context.Doctors.Update(doctor);
            _context.SaveChanges();
        }

        public ApiResponse SetupWorkingTime(Guid idDoctor, WorkingTimeModel model)
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
                    UpdateWorkingTime(doctor, model);
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


        public ApiResponse EditWorkingTime(Guid idDoctor, WorkingTimeModel model)
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
                if (doctor.StatusVerified != AppNumber.APPROVED )
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTALLOWED_SETUPSCHEDULE,
                    };
                }

                if (model.DurationPerAppointment <= 0)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_ERROR_INVALID_INFOR_CREATION,
                    };

                }

                //Check Appointment before Update Working Time
                _appointmentRepository.UpdateStatusAppointment(idDoctor);

                var listAppointment = _appointmentRepository.GetListAppointmentByIdDoctor(idDoctor);
                if(listAppointment == null)
                {
                    UpdateWorkingTime(doctor, model);
                }
                else
                {
                    foreach (var appointment in listAppointment)
                    {
                        if (TimeSpan.Parse(appointment.StartTime) < TimeSpan.Parse(model.StartTime) || TimeSpan.Parse(appointment.StartTime) >= TimeSpan.Parse(model.EndTime))
                        {
                            return new ApiResponse
                            {
                                StatusCode = StatusCode.CONFLICT,
                                Message = AppString.MESSAGE_ERROR_EDITWORKINGTIME_CONFLICTWITHAPPOINTMENT,
                            };
                        }
                    }

                    foreach (var appointment in listAppointment)
                    {
                        var newEndTime = TimeSpan.Parse(appointment.StartTime);
                        appointment.EndTime = newEndTime.Add(TimeSpan.FromMinutes(model.DurationPerAppointment)).ToString("hh\\:mm");
                    }
                    _context.Appointments.UpdateRange(listAppointment);
                    _context.SaveChanges();

                }


                //UPDATE
                UpdateWorkingTime(doctor, model);

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_SETUP_SCHEDULE_SUCCESS,
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

        public async Task<ApiResponse> CancelAppointmentAndUpdateWorkingTime(Guid idDoctor, CancelAppointmentAndUpdateWorkingTimeModel model)
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
                if (doctor.StatusVerified != AppNumber.APPROVED)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTALLOWED_SETUPSCHEDULE,
                    };
                }

                if (model.DurationPerAppointment <= 0)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_ERROR_INVALID_INFOR_CREATION,
                    };

                }

                //Check Appointment before Update Working Time
                _appointmentRepository.UpdateStatusAppointment(idDoctor);

                var listAppointment = _appointmentRepository.GetListAppointmentByIdDoctor(idDoctor);
                if (listAppointment != null)
                {
                    foreach (var appointment in listAppointment)
                    {
                        if (TimeSpan.Parse(appointment.StartTime) < TimeSpan.Parse(model.StartTime) || TimeSpan.Parse(appointment.StartTime) >= TimeSpan.Parse(model.EndTime))
                        {
                            //Cancel appointment
                            Guid? idReceiver = appointment.IdUser;
                            appointment.idDoctorCancel = idDoctor;
                            appointment.Reason = model.Reason;
                            appointment.Status = 2;

                            //Create Notification for cancellingappointment
                            var cancelAppointmentModel = new CancelAppointmentModel
                            {
                                idAppointment = appointment.IdAppointment,
                                Reason = model.Reason,
                            };
                            await _notificationRepository.CreateNotificationForCancellingAppointment(cancelAppointmentModel, appointment, idReceiver);
                        }
                        else
                        {
                            var newEndTime = TimeSpan.Parse(appointment.StartTime);
                            appointment.EndTime = newEndTime.Add(TimeSpan.FromMinutes(model.DurationPerAppointment)).ToString("hh\\:mm");
                        }
                    }
                    _context.Appointments.UpdateRange(listAppointment);
                    _context.SaveChanges();

                }


                //UPDATE
                UpdateWorkingTime(doctor, model);

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_SETUP_SCHEDULE_SUCCESS,
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
