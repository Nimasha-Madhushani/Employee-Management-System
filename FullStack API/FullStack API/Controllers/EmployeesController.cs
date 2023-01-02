﻿using FullStack_API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStack_API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
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
    }
}
