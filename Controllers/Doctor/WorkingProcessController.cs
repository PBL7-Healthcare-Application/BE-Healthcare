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
    public class WorkingProcessController : ControllerBase
    {
        private readonly IWorkingProcessRepository _workingProcessRepository;

        public WorkingProcessController(IWorkingProcessRepository workingProcessRepository)
        {
            _workingProcessRepository = workingProcessRepository;
        }

        [HttpPost("AddListWorkingProcess")]
        public IActionResult AddListWorkingProcess(List<AddWorkingProcessModel> model)
        {
            try
            {
                var checkIdDoctor = User.Claims.FirstOrDefault(u => u.Type == "IdDoctor")?.Value;
                if (checkIdDoctor == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return Ok(_workingProcessRepository.AddListWorkingProcess(Guid.Parse(checkIdDoctor), model));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError);

            }
        }
    }
}
