using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FYPSwaggerApi.Models;

namespace FYPSwaggerApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class employee_modelController : ControllerBase
    {
        private readonly AppDbContext _context;

        public employee_modelController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/employee_model
        [HttpGet]
        public async Task<ActionResult<IEnumerable<employee_model>>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        // GET: api/employee_model/5
        [HttpGet("{id}")]
        public async Task<ActionResult<employee_model>> Getemployee_model(int id)
        {
            var employee_model = await _context.Employees.FindAsync(id);

            if (employee_model == null)
            {
                return NotFound();
            }

            return employee_model;
        }

        // PUT: api/employee_model/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putemployee_model(int id, employee_model employee_model)
        {
            if (id != employee_model.employeeId)
            {
                return BadRequest();
            }

            _context.Entry(employee_model).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!employee_modelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/employee_model
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<employee_model>> Postemployee_model(employee_model employee_model)
        {
            _context.Employees.Add(employee_model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getemployee_model", new { id = employee_model.employeeId }, employee_model);
        }

        // DELETE: api/employee_model/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteemployee_model(int id)
        {
            var employee_model = await _context.Employees.FindAsync(id);
            if (employee_model == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee_model);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool employee_modelExists(int id)
        {
            return _context.Employees.Any(e => e.employeeId == id);
        }
    }
}
