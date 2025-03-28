using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetHospitals.Web.Models.Entities;

namespace PetHospitals.Web.Data
{
    public class PetHospitalsWebContext : DbContext
    {
        public PetHospitalsWebContext (DbContextOptions<PetHospitalsWebContext> options)
            : base(options)
        {
        }

        public DbSet<PetHospitals.Web.Models.Entities.AppointmentViewModel> AppointmentViewModel { get; set; } = default!;
    }
}
