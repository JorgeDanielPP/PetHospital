using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetHospital.Web.Models.Entities;

namespace PetHospital.Web.Data
{
    public class PetHospitalsWebContext : DbContext
    {
        public PetHospitalsWebContext (DbContextOptions<PetHospitalsWebContext> options)
            : base(options)
        {
        }

        public DbSet<AppointmentViewModel> AppointmentViewModel { get; set; } = default!;
        public DbSet<PetViewModel> PetViewModel { get; set; } = default!;
    }
}
