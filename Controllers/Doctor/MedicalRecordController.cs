using BE_Healthcare.Models;
using BE_Healthcare.Models.MedicalRecord;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.Doctor
{
    [Route("api/Doctor/[controller]")]
    [ApiController]
    [Authorize(Roles = "Doctor")]
    public class MedicalRecordController : ControllerBase
    {
        private readonly IMedicalRecordRepository _medicalRecordRepository;

        public MedicalRecordController(IMedicalRecordRepository medicalRecordRepository)
        {
            _medicalRecordRepository = medicalRecordRepository;
        }

        [HttpPost("CreateMedicalRecord")]
        public IActionResult CreateMedicalRecord(MedicalRecordModel model)
        {
            try
            {
                var checkIdDoctor = User.Claims.FirstOrDefault(u => u.Type == "IdDoctor")?.Value;
                if (checkIdDoctor == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                model.IdDoctor = Guid.Parse(checkIdDoctor);
                return Ok(_medicalRecordRepository.CreateMedicalRecord(model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
