using BE_Healthcare.Models.Partner;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace BE_Healthcare.Controllers.User
{
    [Route("api/User/[controller]")]
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
        public async Task<IActionResult> StartDoctoring(RegistrationFormDoctorModel model)
        {
            try
            {
                var checkIdUser = User.Claims.FirstOrDefault(u => u.Type == "IdUser")?.Value;
                if (checkIdUser == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                return Ok( await _partnerRepository.RegisterAsDoctor(Guid.Parse(checkIdUser), model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
