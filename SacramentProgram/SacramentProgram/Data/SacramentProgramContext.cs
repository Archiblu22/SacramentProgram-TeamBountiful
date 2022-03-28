using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacramentProgram.Models;

namespace SacramentProgram.Data
{
    public class SacramentProgramContext : DbContext
    {
        public SacramentProgramContext (DbContextOptions<SacramentProgramContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentProgram.Models.SacramentProgram> SacramentProgram { get; set; }
    }
}
