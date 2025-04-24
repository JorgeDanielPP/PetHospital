using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Domain.DTOs
{
    public class AppointmentsDTO
    {
        public int IdCita { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int? IdPet { get; set; }
        public int? IdVeterinario { get; set; }
        public string? MotivoCita { get; set; }
    }
}
