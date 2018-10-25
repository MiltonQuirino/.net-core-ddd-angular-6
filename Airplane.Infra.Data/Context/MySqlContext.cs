using System;
using Airplane.Domain.Entities;
using Airplane.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;


namespace Airplane.Infra.Data.Context
{
    public class MySqlContext : DbContext
    {
        public DbSet<Plane> Plane { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=Gol;Uid=quirino;Pwd=qwerty");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Plane>(new PlaneMap().Configure);
        }
    }
}
