using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Application.DTOs
{
    public class AppointmentsDTO 
    {
        public int IdCita { get; set; }
        public required DateTime Fecha { get; set; }
        public required DateTime Hora { get; set; }
        public required int? IdPet { get; set; }
        public required int? IdVeterinario { get; set; }
        public required string? MotivoCita { get; set; }
    }
}
