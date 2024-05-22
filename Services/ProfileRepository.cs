﻿using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Extensions;
using BE_Healthcare.Models;
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
        public ProfileRepository(MyDbContext context, IAuthRepository authRepository, 
            IDoctorRepository doctorRepository, ICertificateRepository certificateRepository,
            IWorkingProcessRepository workingProcessRepository, ITrainingProcessRepository trainingProcessRepository)
        {
            _context = context;
            _authRepository = authRepository;
            _doctorRepository = doctorRepository;
            _certificateRepository = certificateRepository;
            _workingProcessRepository = workingProcessRepository;
            _trainingProcessRepository = trainingProcessRepository;
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
    }
}
