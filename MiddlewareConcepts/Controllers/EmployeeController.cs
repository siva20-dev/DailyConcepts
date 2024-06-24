using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Day25Concepts.Models;
using System.Collections.Generic;
using System;
using Day25Concepts.Repository;

namespace Day25Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("")]
        public Employee GetEmployees()
        {
            return new Employee() { Id = 1, Name = "Employee1" };
        }
        
        [Route("{id}")]
        public IActionResult GetEmployees(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return Ok(new List<Employee>() {
                new Employee() { Id = 1, Name = "Employee1" },
                new Employee() { Id = 2, Name = "Employee2" } }
            );
        }

        [Route("{id}/basic")]
        public ActionResult<Employee> GetEmployeeBasicDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return new Employee() { Id = 3, Name = "Employee3" };
        }

        [HttpGet("name")]
        public IActionResult GetName([FromServices] IProductRepository _productRepository)
        {
            var name = _productRepository.GetName();

            return Ok(name);
        }
    }
}
