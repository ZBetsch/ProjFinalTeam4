using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        // GET
        [HttpGet]
        public IActionResult GetTravel()
        {
            return Ok(_context.Travel.ToList());
        }

        // GET(ID)
        [HttpGet("{id}")]
        public IActionResult GetTravel(int? id)
        {
         

            //if the id is left blank or set to 0, return the first 5 results from the table
            if (!id.HasValue || id == 0)
            {
                var topFiveHobbies = _context.Hobbies.Take(5).ToList();
                return Ok(topFiveHobbies);
            }
            Travel travel = _context.Travel.Find(id);

            if (travel == null)
                return NotFound();
            return Ok(travel);
        }

        // PUT
        [HttpPut("{id}")]
        public IActionResult PutTravel(Travel travel)
        {
            try
            {
                _context.Entry(travel).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok();
        }

        // POST
        [HttpPost]
        public IActionResult PostTravel(Travel travel)
        {
            _context.Travel.Add(travel);
            _context.SaveChanges();
            return Ok();
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult DeleteTravel(int id)
        {
            Travel travel = _context.Travel.Find(id);
            if (travel == null)
                return NotFound();

            try
            {
                _context.Travel.Remove(travel);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            _context.Travel.Remove(travel);

            return Ok();
        }

        [HttpPut]
        public IActionResult PutStudent(Travel travel)
        {
            try
            {
                _context.Entry(travel).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok();

            //Below are Codes Generated Automatically:
            //// GET: api/ExtracurricularActivities
            //[HttpGet]
            //public async Task<ActionResult<IEnumerable<ExtracurricularActivity>>> GetExtracurricularActivity()
            //{
            //    return await _context.ExtracurricularActivity.ToListAsync();
            //}

            //// GET: api/ExtracurricularActivities/5
            //[HttpGet("{id}")]
            //public async Task<ActionResult<ExtracurricularActivity>> GetExtracurricularActivity(int id)
            //{
            //    var extracurricularActivity = await _context.ExtracurricularActivity.FindAsync(id);

            //    if (extracurricularActivity == null)
            //    {
            //        return NotFound();
            //    }

            //    return extracurricularActivity;
            //}

            //// PUT: api/ExtracurricularActivities/5
            //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            //[HttpPut("{id}")]
            //public async Task<IActionResult> PutExtracurricularActivity(int id, ExtracurricularActivity extracurricularActivity)
            //{
            //    if (id != extracurricularActivity.activityId)
            //    {
            //        return BadRequest();
            //    }

            //    _context.Entry(extracurricularActivity).State = EntityState.Modified;

            //    try
            //    {
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!ExtracurricularActivityExists(id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }

            //    return NoContent();
            //}

            //// POST: api/ExtracurricularActivities
            //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            //[HttpPost]
            //public async Task<ActionResult<ExtracurricularActivity>> PostExtracurricularActivity(ExtracurricularActivity extracurricularActivity)
            //{
            //    _context.ExtracurricularActivity.Add(extracurricularActivity);
            //    await _context.SaveChangesAsync();

            //    return CreatedAtAction("GetExtracurricularActivity", new { id = extracurricularActivity.activityId }, extracurricularActivity);
            //}

            //// DELETE
            //[HttpDelete("{id}")]
            //public async Task<IActionResult> DeleteExtracurricularActivity(int id)
            //{
            //    var extracurricularActivity = await _context.ExtracurricularActivity.FindAsync(id);
            //    if (extracurricularActivity == null)
            //    {
            //        return NotFound();
            //    }

            //    _context.ExtracurricularActivity.Remove(extracurricularActivity);
            //    await _context.SaveChangesAsync();

            //    return NoContent();
            //}

            //private bool ExtracurricularActivityExists(int id)
            //{
            //    return _context.ExtracurricularActivity.Any(e => e.activityId == id);
            //}
        }
    }
}
