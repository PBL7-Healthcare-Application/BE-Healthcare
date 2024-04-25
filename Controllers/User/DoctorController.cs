using BE_Healthcare.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;
        public DoctorController(IDoctorRepository doctorRepository) 
        {
            _doctorRepository = doctorRepository;
        }

        [HttpGet("GetDoctor")]
        public IActionResult GetDoctor(string? search = null, int? exp = null, double? from = null, double? to = null, string? sortBy = null, int? id_specialty = null)
        {
            try
            {
                return Ok(_doctorRepository.GetAllDoctor(search, exp, from, to, sortBy, id_specialty));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
