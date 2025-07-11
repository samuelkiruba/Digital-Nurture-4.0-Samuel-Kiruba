using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_API_Hands_on.Filters;
using Web_API_Hands_on.Models;

namespace Web_API_Hands_On.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class EmployeeController : ControllerBase
    {

        private static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Salary = 5000,
                Permanent = true,
                DateOfBirth = new DateTime(1990, 1, 1),
                Department = new Department { DeptId = 1, DeptName = "HR" },
                Skills = new List<Skill>
                {
                    new Skill { SkillId = 1, SkillName = "C#" },
                    new Skill { SkillId = 2, SkillName = "SQL" }
                }
            }
        };

        [HttpGet("standard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> GetStandard()
        {
            return Ok(employees);
        }

        [HttpPut("standard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Employee> UpdateEmployee([FromBody] Employee emp)
        {
            if (emp.Id <= 0)
                return BadRequest("Invalid employee id");

            var existing = employees.FirstOrDefault(e => e.Id == emp.Id);
            if (existing == null)
                return BadRequest("Invalid employee id");

            existing.Name = emp.Name;
            existing.Salary = emp.Salary;
            existing.Permanent = emp.Permanent;
            existing.DateOfBirth = emp.DateOfBirth;
            existing.Department = emp.Department;
            existing.Skills = emp.Skills;

            return Ok(existing);
        }

        [HttpPost("standard")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Employee> CreateEmployee([FromBody] Employee emp)
        {
            if (emp.Id <= 0)
                return BadRequest("Invalid employee id");

            if (employees.Any(e => e.Id == emp.Id))
                return BadRequest("Employee with this ID already exists");

            employees.Add(emp);
            return CreatedAtAction(nameof(GetStandard), new { id = emp.Id }, emp);
        }

        [HttpDelete("standard/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteEmployee(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var existing = employees.FirstOrDefault(e => e.Id == id);
            if (existing == null)
                return BadRequest("Invalid employee id");

            employees.Remove(existing);
            return Ok($"Employee with ID {id} deleted successfully.");
        }

        //[HttpGet("cause-error")]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public IActionResult CauseError()
        //{
        //    throw new Exception("This is a test exception from GET method.");
        //}
    }
}
