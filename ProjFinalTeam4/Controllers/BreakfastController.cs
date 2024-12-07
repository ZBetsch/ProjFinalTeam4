using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjFinalTeam4.Data;
using ProjFinalTeam4.Models;

namespace ProjFinalTeam4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreakfastController : ControllerBase
    {
        private readonly ProjFinalTeam4Context _context;

        public BreakfastController(ProjFinalTeam4Context context)
        {
            _context = context;
        }

        // GET: api/Breakfast
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Breakfast>>> GetBreakfast()
        {
            return await _context.Breakfast.ToListAsync();
        }

        // GET: api/Breakfast/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Breakfast>> GetBreakfast(int id)
        {
            if (id == null || id == 0)
            {
                return Ok(_context.Breakfast.Take(5).ToList());
            }

            var breakfast = _context.Breakfast.Find(id);

            if (breakfast == null)
            {
                return NotFound();
            }

            return Ok(breakfast); ;
        }

        // PUT: api/Breakfast/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBreakfast(int id, Breakfast breakfast)
        {
            if (id != breakfast.BreakfastId)
            {
                return BadRequest();
            }

            _context.Entry(breakfast).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BreakfastExists(id))
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

        // POST: api/Breakfast
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Breakfast>> PostBreakfast(Breakfast breakfast)
        {
            _context.Breakfast.Add(breakfast);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBreakfast", new { id = breakfast.BreakfastId }, breakfast);
        }

        // DELETE: api/Breakfast/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBreakfast(int id)
        {
            var breakfast = await _context.Breakfast.FindAsync(id);
            if (breakfast == null)
            {
                return NotFound();
            }

            _context.Breakfast.Remove(breakfast);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BreakfastExists(int id)
        {
            return _context.Breakfast.Any(e => e.BreakfastId == id);
        }
    }
}
