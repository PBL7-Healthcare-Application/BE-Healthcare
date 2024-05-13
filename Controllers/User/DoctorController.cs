using BE_Healthcare.Models;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace BE_Healthcare.Controllers.User
{
    [Route("api/User/[controller]")]
    [ApiController]
    //[Authorize(Roles = "User")]
    //[Authorize(Roles = "Doctor")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        public DoctorController(IDoctorRepository doctorRepository, IAppointmentRepository appointmentRepository) 
        {
            _doctorRepository = doctorRepository;
            _appointmentRepository = appointmentRepository;
        }

        [HttpGet("GetDoctor")]
        public IActionResult GetDoctor(DoctorSearchCriteriaModel model)
        {
            try
            {
                return Ok(_doctorRepository.GetAllDoctor(model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [HttpGet("GetDoctorDetail/{id}")]
        public IActionResult GetDoctorDetail(Guid id)
        {
            try
            {
                var listAppointment = _appointmentRepository.GetListAppointmentofDoctorDetail(id);
                return Ok(_doctorRepository.GetDoctorDetail(id, listAppointment));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
