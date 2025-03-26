using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetHospital.Web.Models.Entities;

namespace PetHospital.Web.Data
{
    public class PetHospitalWebContext : DbContext
    {
        public PetHospitalWebContext (DbContextOptions<PetHospitalWebContext> options)
            : base(options)
        {
        }

        public DbSet<PetHospital.Web.Models.Entities.Pets> Pets { get; set; } = default!;
        public DbSet<PetHospital.Web.Models.Entities.Appointments> Appointments { get; set; } = default!;
        public DbSet<PetHospital.Web.Models.Entities.MedicalHistory> MedicalHistory { get; set; } = default!;
        public DbSet<PetHospital.Web.Models.Entities.VeterinaryDoctor> VeterinaryDoctor { get; set; } = default!;
    }
}
