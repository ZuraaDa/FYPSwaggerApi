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
    public class note_modelController : ControllerBase
    {
        private readonly AppDbContext _context;

        public note_modelController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/note_model
        [HttpGet]
        public async Task<ActionResult<IEnumerable<note_model>>> GetNotes()
        {
            return await _context.Notes.ToListAsync();
        }

        // GET: api/note_model/5
        [HttpGet("{id}")]
        public async Task<ActionResult<note_model>> Getnote_model(int id)
        {
            var note_model = await _context.Notes.FindAsync(id);

            if (note_model == null)
            {
                return NotFound();
            }

            return note_model;
        }

        // PUT: api/note_model/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putnote_model(int id, note_model note_model)
        {
            if (id != note_model.noteId)
            {
                return BadRequest();
            }

            _context.Entry(note_model).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!note_modelExists(id))
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

        // POST: api/note_model
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<note_model>> Postnote_model(note_model note_model)
        {
            _context.Notes.Add(note_model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getnote_model", new { id = note_model.noteId }, note_model);
        }

        // DELETE: api/note_model/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletenote_model(int id)
        {
            var note_model = await _context.Notes.FindAsync(id);
            if (note_model == null)
            {
                return NotFound();
            }

            _context.Notes.Remove(note_model);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool note_modelExists(int id)
        {
            return _context.Notes.Any(e => e.noteId == id);
        }
    }
}
