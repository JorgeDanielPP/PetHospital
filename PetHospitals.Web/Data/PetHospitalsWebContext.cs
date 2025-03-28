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

        public DbSet<PetHospital.Web.Models.Entities.AppointmentViewModel> AppointmentViewModel { get; set; } = default!;
    }
}
