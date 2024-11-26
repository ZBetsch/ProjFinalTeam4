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
    public class TeamDatasController : ControllerBase
    {
        private readonly ProjFinalTeam4Context _context;

        public TeamDatasController(ProjFinalTeam4Context context)
        {
            _context = context;
        }

        // GET: api/TeamData
        [HttpGet]
        public IActionResult GetTeamData()
        {
            return Ok(_context.TeamData.ToList());
        }

        // GET: api/TeamData/5
        [HttpGet("{id}")]
        public IActionResult GetTeamData(int id)
        {
            TeamData teamdata = _context.TeamData.Find(id);

            //if there is no teamdata with the specified parameter
            if (teamdata == null)
            {
                return NotFound();
            }

            //else not needed, return exits the block. If the if statement is true, the return inside will exit the code
            return Ok(teamdata);
        }

        // PUT: api/TeamData/5
        [HttpPut("{id}")]
        public IActionResult PutTeamData(TeamData teamdata)
        {
            try
            {
                _context.Entry(teamdata).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult PostTeamData(TeamData teamdata)
        {
            _context.TeamData.Add(teamdata);
            //Must save changes
            _context.SaveChanges();
            return Ok();
        }

        // DELETE: api/TeamData/5
        [HttpDelete("{id}")]
        public IActionResult DeleteTeamData(int id)
        {
            //find and store the teamdata obj
            TeamData teamdata = _context.TeamData.Find(id);

            //check if teamdata exists, exit if not
            if (teamdata == null)
                return NotFound();

            //remove the teamdata using the _context action method
            try
            {
                _context.TeamData.Remove(teamdata);
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
