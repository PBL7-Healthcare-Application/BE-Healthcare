using BE_Healthcare.Models;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.User
{
    [Route("api/User/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingController(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        [HttpPost("CreateRating")]
        [Authorize(Roles = "User")]
        public IActionResult CreateRating(RatingModel model)
        {
            try
            {
                var checkIdUser = User.Claims.FirstOrDefault(u => u.Type == "IdUser")?.Value;
                if (checkIdUser == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                return Ok( _ratingRepository.CreateRating(Guid.Parse(checkIdUser), model));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
