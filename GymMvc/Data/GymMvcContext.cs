using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GymMvc.Models;

namespace GymMvc.Data
{
    public class GymMvcContext : DbContext
    {
        public GymMvcContext (DbContextOptions<GymMvcContext> options)
            : base(options)
        {
        }

        public DbSet<GymMvc.Models.Instructor> Instructor { get; set; }
    }
}
