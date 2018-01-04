using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCV.Models;

namespace MyCV.Models
{
    public class MyCVContext : DbContext
    {
        public MyCVContext (DbContextOptions<MyCVContext> options)
            : base(options)
        {
        }

        public DbSet<MyCV.Models.WorkExperience> WorkExperience { get; set; }

        public DbSet<MyCV.Models.Projects> Projects { get; set; }

        public DbSet<MyCV.Models.Skills> Skills { get; set; }
    }
}
