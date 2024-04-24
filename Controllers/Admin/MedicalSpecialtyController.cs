using BE_Healthcare.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
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
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
