using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetHospital.Api.Models.Entities;

namespace PetHospital.Api.Data
{
    public class PetHospitalApiContext : DbContext
    {
        public PetHospitalApiContext (DbContextOptions<PetHospitalApiContext> options)
            : base(options)
        {
        }

        public DbSet<PetHospital.Api.Models.Entities.Appointments> Appointments { get; set; } = default!;
        public DbSet<PetHospital.Api.Models.Entities.MedicalHistory> MedicalHistory { get; set; } = default!;
        public DbSet<PetHospital.Api.Models.Entities.Pets> Pets { get; set; } = default!;
        public DbSet<PetHospital.Api.Models.Entities.VeterinaryDoctor> VeterinaryDoctor { get; set; } = default!;
    }
}
