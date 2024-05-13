using BE_Healthcare.Constant;
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

        public ProfileRepository(MyDbContext context, IAuthRepository authRepository)
        {
            _context = context;
            _authRepository = authRepository;
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
        public ProfileModel CreateProfileModel(User u)
        {
            var res = new ProfileModel
            {
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

    }
}
