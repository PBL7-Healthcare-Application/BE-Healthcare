using BE_Healthcare.Models;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace BE_Healthcare.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerController : ControllerBase
    {
        private readonly IPartnerRepository _partnerRepository;

        public PartnerController(IPartnerRepository partnerRepository)
        {
            _partnerRepository = partnerRepository;
        }

        [HttpPost("StartDoctoring")]
        [Authorize(Roles = "User")]
        public IActionResult StartDoctoring(RegistrationFormDoctorModel model)
        {
            try
            {
                var checkIdUser = User.Claims.FirstOrDefault(u => u.Type == "IdUser")?.Value;
                if (checkIdUser == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                return Ok(_partnerRepository.RegisterAsDoctor(Guid.Parse(checkIdUser), model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
