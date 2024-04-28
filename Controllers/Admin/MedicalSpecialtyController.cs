using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin|Doctor")]

    public class MedicalSpecialtyController : ControllerBase
    {
        private readonly IMedicalSpecialtyRepository _medicalSpecialtyRepository;
        public MedicalSpecialtyController(IMedicalSpecialtyRepository medicalSpecialtyRepository)
        {
            _medicalSpecialtyRepository = medicalSpecialtyRepository;
        }

        [HttpGet("GetAllMedicalSpecialty")]
        public IActionResult GetAllMedicalSpecialty()
        {
            try
            {
                return Ok(_medicalSpecialtyRepository.GetAllMedicalSpecialty());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
