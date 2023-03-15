using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService service)
        {
            _employeeService = service;
        }
         
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetAll()
        {
            return new List<Employee>();
            {
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName="Test",
                    LastName="Test",
                    DepartmentId=Guid.NewGuid(),
                    PaycheckId=Guid.NewGuid(),
                    Email="test@test.com"
                };
            };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<Employee> Get(Guid id)
        {
            return new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = "Test",
                LastName = "Test",
                DepartmentId = Guid.NewGuid(),
                PaycheckId = Guid.NewGuid(),
                Email = "test@test.com"
            };
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task Post([FromQuery] EmployeeDTO employee)
        {
            await _employeeService.AddEmployee(employee);
        }   
    }
}
