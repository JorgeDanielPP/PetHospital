using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Domain.DTOs
{
    public class VeterinaryDoctorDTO
    {
        public int IdVeterinario { get; set; }
        public string NombreVeterinario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
    }
}
