using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles03.API.Data.Entities;

namespace Vehicles03.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

        public DbSet<Procedure> Procedures { get; set; }

        public DbSet<VehicleType> VehicleTypes { get; set; }

        //Para que la descripcion de la tabla VehicleType dea unica ponemos lo siguiente
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Procedure>()
                .HasIndex(x => x.Description).IsUnique();

            modelBuilder.Entity<VehicleType>()
                .HasIndex(x => x.Desription).IsUnique();
        }
    }
}
