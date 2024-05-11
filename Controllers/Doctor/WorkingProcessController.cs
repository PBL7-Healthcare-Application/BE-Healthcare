using BE_Healthcare.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_Healthcare.Controllers.Doctor
{
    [Route("api/Doctor/[controller]")]
    [ApiController]
    public class WorkingProcessController : ControllerBase
    {
        private readonly IWorkingProcessRepository _workingProcessRepository;

        public WorkingProcessController(IWorkingProcessRepository workingProcessRepository)
        {
            _workingProcessRepository = workingProcessRepository;
        }
    }
}
