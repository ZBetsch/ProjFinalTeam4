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
    public class HobbiesController : ControllerBase
    {
        private readonly ProjFinalTeam4Context _context;

        public HobbiesController(ProjFinalTeam4Context context)
        {
            _context = context;
        }

        // GET: api/Hobbies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hobbies>>> GetHobbies()
        {
            return await _context.Hobbies.ToListAsync();
        }

        // GET: api/Hobbies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hobbies>> GetHobbies(int id)
        {
            var hobbies = await _context.Hobbies.FindAsync(id);

            if (hobbies == null)
            {
                return NotFound();
            }

            return hobbies;
        }

        // PUT: api/Hobbies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHobbies(int id, Hobbies hobbies)
        {
            if (id != hobbies.hobbiesId)
            {
                return BadRequest();
            }

            _context.Entry(hobbies).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HobbiesExists(id))
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

        // POST: api/Hobbies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hobbies>> PostHobbies(Hobbies hobbies)
        {
            _context.Hobbies.Add(hobbies);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHobbies", new { id = hobbies.hobbiesId }, hobbies);
        }

        // DELETE: api/Hobbies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHobbies(int id)
        {
            var hobbies = await _context.Hobbies.FindAsync(id);
            if (hobbies == null)
            {
                return NotFound();
            }

            _context.Hobbies.Remove(hobbies);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HobbiesExists(int id)
        {
            return _context.Hobbies.Any(e => e.hobbiesId == id);
        }
    }
}
