using BE_Healthcare.Models;
using BE_Healthcare.Models.Partner;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.Admin
{
    [Route("api/Admin/[controller]")]
    [Authorize(Roles = "Admin")]
    [ApiController]
    public class PartnerController : ControllerBase
    {
        private readonly IPartnerRepository _partnerRepository;
        private readonly IDoctorRepository _doctorRepository;


        public PartnerController(IPartnerRepository partnerRepository, IDoctorRepository doctorRepository)
        {
            _partnerRepository = partnerRepository;
            _doctorRepository = doctorRepository;
        }

        [HttpGet("GetPartner")]
        public IActionResult GetPartner([FromQuery] PartnerSearchCriteriaModel model)
        {
            try
            {
                return Ok(_partnerRepository.GetPartner(model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpGet("GetPartnerDetail/{id}")]
        public IActionResult GetPartnerDetail(Guid id)
        {
            try
            {
                return Ok(_doctorRepository.GetDoctorDetail(id, null));

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("VerifyInfoPartner")]
        public IActionResult VerifyInfoPartner(VerifyPartnerModel model)
        {
            try
            {
                return Ok(_partnerRepository.VerifyInfoPartner(model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("VerifyCertificate")]
        public IActionResult VerifyCertificate(VerifyCertificateModel model)
        {
            try
            {
                return Ok(_partnerRepository.VerifyCertificate(model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost("VerifyWorkingProcess")]
        public IActionResult VerifyWorkingProcess(VerifyWorkingProcessModel model)
        {
            try
            {
                return Ok(_partnerRepository.VerifyWorkingProcess(model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost("VerifyTrainingProcess")]
        public IActionResult VerifyTrainingProcess(VerifyTrainingProcessModel model)
        {
            try
            {
                return Ok(_partnerRepository.VerifyTrainingProcess(model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
