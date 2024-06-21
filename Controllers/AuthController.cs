using BE_Healthcare.Extensions;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Authentication.Login;
using BE_Healthcare.Models.Authentication.SignUp;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("SignIn")]
        public IActionResult Validate(LoginModel model)
        {
            try
            {
                var res = _authRepository.Validate(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("RenewToken")]
        public IActionResult RenewToken(RenewTokenModel model)
        {
            try
            {
                var res = _authRepository.RenewToken(model);
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
                var res = _authRepository.SignUp(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("ConfirmEmail")]
        public IActionResult ConfirmEmail(ConfirmMailModel model)
            {
            try
            {
                var res = _authRepository.ConfirmEmail(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("ResendOTP")]
        public IActionResult ResendOTP(MailModel model)
        {
            try
            {
                var res = _authRepository.ResendOTP(model.email);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("ResetPassword")]
        public IActionResult ResetPassword(MailModel model)
        {
            try
            {
                var res = _authRepository.ResetPassword(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("SignOut")]
        [Authorize]
        public IActionResult SignOut()
        {
            try
            {

                var checkId = User.Claims.FirstOrDefault(u => u.Type == "IdUser")?.Value;
                if (checkId == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                var res = _authRepository.SignOut(Guid.Parse(checkId));
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
