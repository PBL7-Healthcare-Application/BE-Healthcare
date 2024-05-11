﻿using BE_Healthcare.Data.Entities;
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
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentController(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        [HttpGet("ViewAppointment")]
        public IActionResult ViewAppointment(int? Status = 1)
        {
            try
            {
                var checkIdDoctor = User.Claims.FirstOrDefault(u => u.Type == "IdDoctor")?.Value;
                if (checkIdDoctor == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                return Ok(_appointmentRepository.GetAppointmentByIdDoctor(Guid.Parse(checkIdDoctor), Status));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("SetupSchedule")]
        public IActionResult SetupSchedule(SetupScheduleModel model)
        {
            try
            {
                var checkIdDoctor = User.Claims.FirstOrDefault(u => u.Type == "IdDoctor")?.Value;
                if (checkIdDoctor == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                return Ok(_appointmentRepository.SetupSchedule(Guid.Parse(checkIdDoctor), model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost("CancelAppointment")]
        public IActionResult CancelAppointment(CancelAppointmentModel model)
        {
            try
            {
                var checkIdDoctor = User.Claims.FirstOrDefault(u => u.Type == "IdDoctor")?.Value;
                if (checkIdDoctor == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return Ok(_appointmentRepository.CancelAppointment(model, null, Guid.Parse(checkIdDoctor)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
