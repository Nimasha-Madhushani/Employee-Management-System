using FullStack_API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FullStack_API.Models;

namespace FullStack_API.Controllers
{
    [ApiController]
    [Route("/api/employees")]
    public class EmployeeController : Controller
    {

        private readonly FullStackDbContext _fullStackDbContext;
        public EmployeeController(FullStackDbContext fullStackDbContext)
        {
            _fullStackDbContext = fullStackDbContext;
            //this.fullStackDbContext = fullStackDbContext;(inplace of _ can use this)
        }
        [HttpGet]

        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _fullStackDbContext.Employees.ToListAsync();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody]Employee employeeRequest)
        {
            employeeRequest.Id=Guid.NewGuid();
            await _fullStackDbContext.Employees.AddAsync(employeeRequest);
            await _fullStackDbContext.SaveChangesAsync();
            return Ok(employeeRequest);
        }
    }
}
