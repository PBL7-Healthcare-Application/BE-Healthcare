using BE_Healthcare.Models;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileRepository _profileRepository;
        //private readonly IUserRepository _userRepository;

        public ProfileController(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
            //_userRepository = userRepository;
        }

        [HttpGet("GetPersonalInfo")]
        public IActionResult GetPersonalInfo()
        {
            try
            {

                var checkEmail = User.Claims.FirstOrDefault(u => u.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")?.Value;
                if (checkEmail == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return Ok(_profileRepository.GetPersonalInfo(checkEmail));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("ChangePassword")]
        public IActionResult ChangePassword(ChangePasswordModel model)
        {
            try
            {

                var checkEmail = User.Claims.FirstOrDefault(u => u.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")?.Value;
                if (checkEmail == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return Ok(_profileRepository.ChangePassword(checkEmail, model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
