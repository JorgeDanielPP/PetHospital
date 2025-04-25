using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Application.DTOs
{
    public class VeterinaryDoctorDTO
    {
        public int IdVeterinario { get; set; }
        public required string NombreVeterinario { get; set; }
        public required DateTime FechaIngreso { get; set; }
        public required string? Telefono { get; set; }
        public required string? Direccion { get; set; }
    }
}
