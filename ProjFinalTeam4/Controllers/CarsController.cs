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
    public class CarsController : ControllerBase
    {
        private readonly ProjFinalTeam4Context _context;

        public CarsController(ProjFinalTeam4Context context)
        {
            _context = context;
        }

        // GET: api/Cars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cars>>> GetCars()
        {
            return await _context.Cars.ToListAsync();
        }

        // GET: api/Cars/5
        [HttpGet("{id}")]
        public IActionResult GetCars(int id)
        {
            //if the id does not exist or is set to 0, return the first 5 results from the table
            var x = _context.Cars.Find(id);
            if (x == null || id == 0)
            {
                var topFiveResults = _context.Cars.Take(5).ToList();
                return Ok(topFiveResults);
            }
            return Ok(x);
        }
        
        [HttpPost]
        public IActionResult PostCar(Cars cars)
        {
            _context.Cars.Add(cars);
            _context.SaveChanges();
            return Ok();
        }

        // PUT
        [HttpPut("{id}")]
        public IActionResult PutCar(Cars cars)
        {
            try
            {
                _context.Entry(cars).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok();
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int id)
        {
            Cars car = _context.Cars.Find(id);
            if (car == null)
                return NotFound();

            try
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            _context.Cars.Remove(car);

            return Ok();
        }
    }
}
