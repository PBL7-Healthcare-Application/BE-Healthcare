using BE_Healthcare.Models.TrainingProcess;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.Doctor
{
    [Route("api/Doctor/[controller]")]
    [ApiController]
    [Authorize(Roles = "Doctor")]
    public class TrainingProcessController : ControllerBase
    {
        private readonly ITrainingProcessRepository _trainingProcessRepository;

        public TrainingProcessController(ITrainingProcessRepository trainingProcessRepository)
        {
            _trainingProcessRepository = trainingProcessRepository;
        }

        [HttpPost("AddListTrainingProcess")]
        public IActionResult AddListTrainingProcess(List<AddTrainingProcessModel> model)
        {
            try
            {
                var checkIdDoctor = User.Claims.FirstOrDefault(u => u.Type == "IdDoctor")?.Value;
                if (checkIdDoctor == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return Ok(_trainingProcessRepository.AddListTrainingProcess(Guid.Parse(checkIdDoctor), model));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError);

            }
        }
        [HttpPut("UpdateTrainingProcess")]
        public IActionResult UpdateTrainingProcess(UpdateTrainingProcessModel model)
        {
            try
            {
                var checkIdDoctor = User.Claims.FirstOrDefault(u => u.Type == "IdDoctor")?.Value;
                if (checkIdDoctor == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return Ok(_trainingProcessRepository.UpdateTrainingProcess(Guid.Parse(checkIdDoctor), model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
