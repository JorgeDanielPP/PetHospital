using Microsoft.EntityFrameworkCore;
using PetHospital.Domain.Entities;
using PetHospital.PetHospital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Domain
{
    public class AppointmentsContext : DbContext
    {
        public AppointmentsContext(DbContextOptions<AppointmentsContext> options) : base(options)
        {
        }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Pets> Pets { get; set; }
        public DbSet<MedicalHistory> MedicalHistory { get; set; }
        public DbSet<VeterinaryDoctor> VeterinaryDoctor { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //  modelBuilder.Entity<Appointments>().HasIndex(c => c.IdCita).IsUnique();
            //  modelBuilder.Entity<Pets>().HasIndex(c => c.IdPet).IsUnique();
            //  modelBuilder.Entity<MedicalHistory>().HasIndex(c => c.IdHistorial).IsUnique();
            //  modelBuilder.Entity<VeterinaryDoctor>().HasIndex(c => c.IdVeterinario).IsUnique();

            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.HasKey(p => p.IdCita);
            });

            modelBuilder.Entity<Pets>(entity =>
            {
                entity.HasKey(p => p.IdPet);
            });
            modelBuilder.Entity<MedicalHistory>(entity =>
            {
                entity.HasKey(p => p.IdHistorial);
            });
            modelBuilder.Entity<VeterinaryDoctor>(entity =>
            {
                entity.HasKey(p => p.IdVeterinario);
            });

        }
           
    }
}
