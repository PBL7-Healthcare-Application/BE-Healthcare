using BE_Healthcare.Models;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.User
{
    [Route("api/User/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentController(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        [HttpPost("BookAppointment")]
        [Authorize(Roles = "User")]
        public IActionResult BookAppointment(AppointmentModel model)
        {
            try
            {
                var checkIdUser = User.Claims.FirstOrDefault(u => u.Type == "IdUser")?.Value;
                if (checkIdUser == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                return Ok(_appointmentRepository.CreateAppointment(Guid.Parse(checkIdUser), model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("ViewAppointment")]
        [Authorize(Roles = "User, Doctor")]
        public IActionResult ViewAppointment(int? Status = null) 
        {
            try
            {
                var checkIdUser = User.Claims.FirstOrDefault(u => u.Type == "IdUser")?.Value;
                if (checkIdUser == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                return Ok(_appointmentRepository.GetAppointmentByIdUser(Guid.Parse(checkIdUser), Status));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("CancelAppointment")]
        [Authorize(Roles = "User, Doctor")]
        public IActionResult CancelAppointment(CancelAppointmentModel model)
        {
            try
            {
                return Ok(_appointmentRepository.CancelAppointment(model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
