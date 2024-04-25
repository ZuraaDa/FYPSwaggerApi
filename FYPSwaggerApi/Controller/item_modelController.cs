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
    public class item_modelController : ControllerBase
    {
        private readonly AppDbContext _context;

        public item_modelController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/item_model
        [HttpGet]
        public async Task<ActionResult<IEnumerable<item_model>>> GetItems()
        {
            return await _context.Items.ToListAsync();
        }

        // GET: api/item_model/5
        [HttpGet("{id}")]
        public async Task<ActionResult<item_model>> Getitem_model(int id)
        {
            var item_model = await _context.Items.FindAsync(id);

            if (item_model == null)
            {
                return NotFound();
            }

            return item_model;
        }

        // PUT: api/item_model/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putitem_model(int id, item_model item_model)
        {
            if (id != item_model.itemId)
            {
                return BadRequest();
            }

            _context.Entry(item_model).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!item_modelExists(id))
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

        // POST: api/item_model
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<item_model>> Postitem_model(item_model item_model)
        {
            _context.Items.Add(item_model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getitem_model", new { id = item_model.itemId }, item_model);
        }

        // DELETE: api/item_model/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteitem_model(int id)
        {
            var item_model = await _context.Items.FindAsync(id);
            if (item_model == null)
            {
                return NotFound();
            }

            _context.Items.Remove(item_model);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool item_modelExists(int id)
        {
            return _context.Items.Any(e => e.itemId == id);
        }
    }
}
