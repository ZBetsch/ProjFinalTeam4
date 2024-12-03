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
    public class TravelsController : ControllerBase
    {
        private readonly ProjFinalTeam4Context _context;

        public TravelsController(ProjFinalTeam4Context context)
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
                var topFiveTravels = _context.Travel.Take(5).ToList();
                return Ok(topFiveTravels);
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
        }
    }
}
            // GET: api/Travels
            //[HttpGet]
            //public async Task<ActionResult<IEnumerable<Travel>>> GetTravel()
            // {
            //return await _context.Travel.ToListAsync();
            //  }

            // GET: api/Travels/5
            // [HttpGet("{id}")]
            //  public async Task<ActionResult<Travel>> GetTravel(int id)
            // {
            //  var travel = await _context.Travel.FindAsync(id);

            //  if (travel == null)
            //   {
            //    return NotFound();
            //   }

            // //   return travel;
            // }

            // PUT: api/Travels/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            //  [HttpPut("{id}")]
            //   public async Task<IActionResult> PutTravel(int id, Travel travel)
            //   {
            //   if (id != travel.travelId)
            //   {
            //       return BadRequest();
            //    }

            //    _context.Entry(travel).State = EntityState.Modified;

            //     try
            //     {
            //       await _context.SaveChangesAsync();
            //  }
            // catch (DbUpdateConcurrencyException)
           // {
          //      if (!TravelExists(id))
          //      {
            //        return NotFound();
         //       }
         //       else
         //       {
          //          throw;
         //       }
        //    }

        //    return NoContent();
      //  }

        // POST: api/Travels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
      //  [HttpPost]
     //   public async Task<ActionResult<Travel>> PostTravel(Travel travel)
     //   {
     //       _context.Travel.Add(travel);
      //      await _context.SaveChangesAsync();

     //       return CreatedAtAction("GetTravel", new { id = travel.travelId }, travel);
     //   }

    //    // DELETE: api/Travels/5
    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> DeleteTravel(int id)
      //  {
       //     var travel = await _context.Travel.FindAsync(id);
       //     if (travel == null)
       //     {
       //         return NotFound();
      //      }

      //      _context.Travel.Remove(travel);
        //    await _context.SaveChangesAsync();

      //      return NoContent();
      //  }
//
     //   private bool TravelExists(int id)
     //   {
     //       return _context.Travel.Any(e => e.travelId == id);
     //   }
  //  }
//}
