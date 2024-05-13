using BE_Healthcare.Models;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.User
{
    [Route("api/User/[controller]")]
    [ApiController]
    [Authorize]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileRepository _profileRepository;

        public ProfileController(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
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
        [HttpPost("UpdateProfile")]
        public IActionResult UpdateProfile(UpdateProfileModel model)
        {
            try
            {

                var checkEmail = User.Claims.FirstOrDefault(u => u.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")?.Value;
                if (checkEmail == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return Ok(_profileRepository.UpdateProfile(checkEmail, model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("LockAccount")]
        public IActionResult LockAccount(LockAccountModel model)
        {
            try
            {

                var checkIdUser = User.Claims.FirstOrDefault(u => u.Type == "IdUser")?.Value;
                if (checkIdUser == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return Ok(_profileRepository.LockAccount(Guid.Parse(checkIdUser), model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
