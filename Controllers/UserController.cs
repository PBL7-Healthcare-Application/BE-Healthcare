using BE_Healthcare.Extensions;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Authentication.Login;
using BE_Healthcare.Models.Authentication.SignUp;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("SignIn")]
        public IActionResult Validate(LoginModel model)
        {
            try
            {
                var res = _userRepository.Validate(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("RenewToken")]
        public IActionResult RenewToken(TokenModel model)
        {
            try
            {
                var res = _userRepository.RenewToken(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("SignUp")]
        public IActionResult SignUp(SignUpModel model)
        {
            try
            {
                var res = _userRepository.SignUp(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[HttpPost("ConfirmEmail")]
        //public IActionResult ConfirmEmail(string otp, string email)
        //{

        //}
    }
}
