using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly MyDbContext _context;
        private readonly IUserRepository _userRepository;

        public ProfileRepository(MyDbContext context, IUserRepository userRepository)
        {
            _context = context;
            _userRepository = userRepository;
        }

        public ApiResponse GetPersonalInfo(string email)
        {
            if(email == null) 
            {
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_EMAIL_NULL,
                };
            }
            var info = _userRepository.getUserByEmail(email);
            var res = new ProfileModel
            {
                Email = info.Email,
                Name = info.Name,
                DOB = info.DOB,
                Gender = info.Gender,
                PhoneNumber = info.PhoneNumber,
                Address = info.Address,
                Avatar = info.Avatar,
            };
            return new ApiResponse
            {
                StatusCode = StatusCode.SUCCESS,
                Message = AppString.MESSAGE_GETDATA_SUCCESS,
                Data = res
            };
        }
    }
}
