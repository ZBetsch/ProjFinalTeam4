using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjFinalTeam4.Models;

namespace ProjFinalTeam4.Data
{
    public class ProjFinalTeam4Context : DbContext
    {
        public ProjFinalTeam4Context (DbContextOptions<ProjFinalTeam4Context> options)
            : base(options)
        {
        }

        public DbSet<ProjFinalTeam4.Models.Hobbies> Hobbies { get; set; } = default!;
    }
}
