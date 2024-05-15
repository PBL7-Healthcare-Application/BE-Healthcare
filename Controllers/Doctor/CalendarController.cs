using BE_Healthcare.Models;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.Doctor
{
    [Route("api/Doctor/[controller]")]
    [ApiController]
    [Authorize(Roles = "Doctor")]
    public class CalendarController : ControllerBase
    {
        private readonly ICalendarRepository _calendarRepository;

        public CalendarController(ICalendarRepository calendarRepository)
        {
            _calendarRepository = calendarRepository;
        }

        [HttpGet("GetCalendar")]
        public IActionResult GetCalendar()
        {
            try
            {
                var checkIdDoctor = User.Claims.FirstOrDefault(u => u.Type == "IdDoctor")?.Value;
                if (checkIdDoctor == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                return Ok(_calendarRepository.GetCalendar(Guid.Parse(checkIdDoctor)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
