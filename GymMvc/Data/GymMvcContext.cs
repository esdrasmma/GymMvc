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

        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Modality> Modality { get; set; }
        public DbSet<Membership> Membership { get; set; }


    }
}
