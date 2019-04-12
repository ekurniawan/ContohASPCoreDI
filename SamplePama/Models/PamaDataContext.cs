using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePama.Models
{
    public class PamaDataContext : DbContext
    {
        public PamaDataContext(DbContextOptions<PamaDataContext> options)
            : base(options)
        {
        }

        public DbSet<Pegawai> Pegawai { get; set; }
        public DbSet<Boss> Boss { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
