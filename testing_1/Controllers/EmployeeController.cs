using Microsoft.AspNetCore.Mvc;
using testing_1.Models;
using testing_1.Services;

namespace testing_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _service;

        public EmployeeController(EmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = _service.GetEmployees();
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            var createdEmployee = _service.CreateEmployee(employee);
            return Ok(createdEmployee);
        }
    }
}