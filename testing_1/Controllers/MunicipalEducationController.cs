using Microsoft.AspNetCore.Mvc;
using testing_1.Models;
using testing_1.Services;

namespace testing_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipalEducationController : ControllerBase
    {
        private readonly MunicipalEducationService _service;

        public MunicipalEducationController(MunicipalEducationService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var educations = _service.GetAll();
            return Ok(educations);
        }

        [HttpPost]
        public IActionResult Create([FromBody] MunicipalEducation education)
        {
            var createdEducation = _service.Create(education);
            return Ok(createdEducation);
        }
    }
}