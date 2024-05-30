using BE_Healthcare.Models;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.Admin
{
    [Route("api/Admin/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]

    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentRepository _appointmentRepository;
        public AppointmentController(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        [HttpGet("ViewAppointment")]
        public IActionResult ViewAppointment([FromQuery] AdminSearchAppointmentCriteriaModel criteria)
        {
            try
            {
                return Ok(_appointmentRepository.GetAllAppointment(criteria));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("ViewAppointment/{id}")]
        public IActionResult ViewAppointmentDetail(int id)
        {
            try
            {

                return Ok(_appointmentRepository.GetAppointmentDetail(id));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
