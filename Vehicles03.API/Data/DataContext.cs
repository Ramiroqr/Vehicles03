using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles03.API.Data.Entities;

namespace Vehicles03.API.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Detail> Details { get; set; }

        public DbSet<DocumentType> DocumentTypes { get; set; }

        public DbSet<History> Histories { get; set; }

        public DbSet<Procedure> Procedures { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<VehiclePhoto> VehiclePhotos { get; set; }

        public DbSet<VehicleType> VehicleTypes { get; set; }


        //Para que la descripcion de la tabla VehicleType dea unica ponemos lo siguiente
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Procedure>()
                .HasIndex(x => x.Description).IsUnique();

            modelBuilder.Entity<VehicleType>()
                .HasIndex(x => x.Desription).IsUnique();

            modelBuilder.Entity<Brand>()
                .HasIndex(x => x.Desription).IsUnique();

            modelBuilder.Entity<DocumentType>()
                .HasIndex(x => x.Desription).IsUnique();

            modelBuilder.Entity<Vehicle>()
                .HasIndex(x => x.Plaque).IsUnique();
        }
    }
}
