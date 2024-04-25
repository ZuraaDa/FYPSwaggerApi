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
    public class user_modelController : ControllerBase
    {
        private readonly AppDbContext _context;

        public user_modelController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/user_model
        [HttpGet]
        public async Task<ActionResult<IEnumerable<user_model>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/user_model/5
        [HttpGet("{id}")]
        public async Task<ActionResult<user_model>> Getuser_model(int id)
        {
            var user_model = await _context.Users.FindAsync(id);

            if (user_model == null)
            {
                return NotFound();
            }

            return user_model;
        }

        // PUT: api/user_model/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putuser_model(int id, user_model user_model)
        {
            if (id != user_model.userId)
            {
                return BadRequest();
            }

            _context.Entry(user_model).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!user_modelExists(id))
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

        // POST: api/user_model
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<user_model>> Postuser_model(user_model user_model)
        {
            _context.Users.Add(user_model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getuser_model", new { id = user_model.userId }, user_model);
        }

        // DELETE: api/user_model/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteuser_model(int id)
        {
            var user_model = await _context.Users.FindAsync(id);
            if (user_model == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user_model);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool user_modelExists(int id)
        {
            return _context.Users.Any(e => e.userId == id);
        }
    }
}
