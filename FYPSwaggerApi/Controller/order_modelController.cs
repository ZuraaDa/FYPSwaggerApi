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
    public class order_modelController : ControllerBase
    {
        private readonly AppDbContext _context;

        public order_modelController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/order_model
        [HttpGet]
        public async Task<ActionResult<IEnumerable<order_model>>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        // GET: api/order_model/5
        [HttpGet("{id}")]
        public async Task<ActionResult<order_model>> Getorder_model(int id)
        {
            var order_model = await _context.Orders.FindAsync(id);

            if (order_model == null)
            {
                return NotFound();
            }

            return order_model;
        }

        // PUT: api/order_model/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putorder_model(int id, order_model order_model)
        {
            if (id != order_model.orderId)
            {
                return BadRequest();
            }

            _context.Entry(order_model).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!order_modelExists(id))
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

        // POST: api/order_model
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<order_model>> Postorder_model(order_model order_model)
        {
            _context.Orders.Add(order_model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getorder_model", new { id = order_model.orderId }, order_model);
        }

        // DELETE: api/order_model/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteorder_model(int id)
        {
            var order_model = await _context.Orders.FindAsync(id);
            if (order_model == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order_model);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool order_modelExists(int id)
        {
            return _context.Orders.Any(e => e.orderId == id);
        }
    }
}
