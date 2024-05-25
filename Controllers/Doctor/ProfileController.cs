﻿using BE_Healthcare.Models;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.Doctor
{
    [Route("api/Doctor/[controller]")]
    [ApiController]
    [Authorize(Roles = "Doctor")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileRepository _profileRepository;
        public ProfileController(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        [HttpGet("GetPersonalInfo")]
        public IActionResult GetPersonalInfo()
        {
            try
            {
                var checkIdDoctor = User.Claims.FirstOrDefault(u => u.Type == "IdDoctor")?.Value;
                if (checkIdDoctor == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return Ok(_profileRepository.GetPersonalDoctorInfo(Guid.Parse(checkIdDoctor)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("UpdateProfile")]
        public IActionResult UpdateProfileDoctor (UpdateProfileDoctorModel model)
        {
            try
            {
                var checkIdDoctor = User.Claims.FirstOrDefault(u => u.Type == "IdDoctor")?.Value;
                if (checkIdDoctor == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return Ok(_profileRepository.UpdateProfileDoctor(Guid.Parse(checkIdDoctor), model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
