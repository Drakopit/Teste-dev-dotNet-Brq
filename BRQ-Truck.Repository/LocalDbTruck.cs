using BRQ_Truck.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace BRQ_Truck.Repository
{
    public class LocalDbTruck : DbContext
    {
        public LocalDbTruck(DbContextOptions<LocalDbTruck> options) : base(options) {}

        public DbSet<Truck> Truck { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Truck>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property<string>(t => t.Model).HasMaxLength(2).IsRequired();
                entity.Property<DateTime>(t => t.YearModel).IsRequired();
                entity.Property<DateTime>(t => t.YearOfManufacture).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
