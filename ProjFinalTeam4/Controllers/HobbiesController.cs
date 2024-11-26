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
        public IActionResult GetHobbies()
        {
            return Ok(_context.Hobbies.ToList());
        }

        // GET: api/Hobbies/{id?}
        [HttpGet("{id?}")]
        public IActionResult GetHobbies(int? id)
        {
            //if the id is left blank or set to 0, return the first 5 results from the table
            if (!id.HasValue || id == 0)
            {
                var topFiveHobbies = _context.Hobbies.Take(5).ToList();
                return Ok(topFiveHobbies);
            }

            Hobbies hobbies = _context.Hobbies.Find(id);

            //if there is no hobby with the specified parameter
            if (hobbies == null)
            {
                return NotFound();
            }

            return Ok(hobbies);
        }

        // PUT: api/Hobbies/{id}
        [HttpPut("{id}")]
        public IActionResult PutHobbies(Hobbies hobbies)
        {
            try
            {
                _context.Entry(hobbies).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult PostHobbies(Hobbies hobbies)
        {
            _context.Hobbies.Add(hobbies);
            //Must save changes
            _context.SaveChanges();
            return Ok();
        }

        // DELETE: api/Hobbies/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteHobby(int id)
        {
            //find and store the hobby obj
            Hobbies hobbies = _context.Hobbies.Find(id);

            //check if hobby exists, exit if not
            if (hobbies == null)
                return NotFound();

            //remove the hobby using the _context action method
            try
            {
                _context.Hobbies.Remove(hobbies);
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