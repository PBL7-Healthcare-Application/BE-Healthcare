﻿using BE_Healthcare.Models.TrainingProcess;
using BE_Healthcare.Models.WorkingProcess;
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
        public async Task<IActionResult> AddListWorkingProcess(List<AddWorkingProcessModel> model)
        {
            try
            {
                var checkIdDoctor = User.Claims.FirstOrDefault(u => u.Type == "IdDoctor")?.Value;
                if (checkIdDoctor == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return Ok(await _workingProcessRepository.AddListWorkingProcess(Guid.Parse(checkIdDoctor), model));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError);

            }
        }
        [HttpPut("UpdateWorkingProcess")]
        public async Task<IActionResult> UpdateWorkingProcess(UpdateWorkingProcessModel model)
        {
            try
            {
                var checkIdDoctor = User.Claims.FirstOrDefault(u => u.Type == "IdDoctor")?.Value;
                if (checkIdDoctor == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return Ok(await _workingProcessRepository.UpdateWorkingProcess(Guid.Parse(checkIdDoctor), model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("DeleteWorkingProcess/{id}")]
        public IActionResult DeleteWorkingProcess(int id)
        {
            try
            {
                var checkIdDoctor = User.Claims.FirstOrDefault(u => u.Type == "IdDoctor")?.Value;
                if (checkIdDoctor == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return Ok(_workingProcessRepository.DeleteWorkingProcess(Guid.Parse(checkIdDoctor), id));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
