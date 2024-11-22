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
    public class ExtracurricularActivitiesController : ControllerBase
    {
        private readonly ProjFinalTeam4Context _context;

        public ExtracurricularActivitiesController(ProjFinalTeam4Context context)
        {
            _context = context;
        }

        // GET: api/ExtracurricularActivities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExtracurricularActivity>>> GetExtracurricularActivity()
        {
            return await _context.ExtracurricularActivity.ToListAsync();
        }

        // GET: api/ExtracurricularActivities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExtracurricularActivity>> GetExtracurricularActivity(int id)
        {
            var extracurricularActivity = await _context.ExtracurricularActivity.FindAsync(id);

            if (extracurricularActivity == null)
            {
                return NotFound();
            }

            return extracurricularActivity;
        }

        // PUT: api/ExtracurricularActivities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExtracurricularActivity(int id, ExtracurricularActivity extracurricularActivity)
        {
            if (id != extracurricularActivity.activityId)
            {
                return BadRequest();
            }

            _context.Entry(extracurricularActivity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtracurricularActivityExists(id))
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

        // POST: api/ExtracurricularActivities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExtracurricularActivity>> PostExtracurricularActivity(ExtracurricularActivity extracurricularActivity)
        {
            _context.ExtracurricularActivity.Add(extracurricularActivity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExtracurricularActivity", new { id = extracurricularActivity.activityId }, extracurricularActivity);
        }

        // DELETE: api/ExtracurricularActivities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExtracurricularActivity(int id)
        {
            var extracurricularActivity = await _context.ExtracurricularActivity.FindAsync(id);
            if (extracurricularActivity == null)
            {
                return NotFound();
            }

            _context.ExtracurricularActivity.Remove(extracurricularActivity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExtracurricularActivityExists(int id)
        {
            return _context.ExtracurricularActivity.Any(e => e.activityId == id);
        }
    }
}
