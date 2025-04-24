using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Domain.DTOs
{
    public class PetsDTO
    {
        public int IdPet { get; set; }
        public string? Raza { get; set; }
        public int Edad { get; set; }
        public string? Sexo { get; set; }
        public string? Color { get; set; }
        public string? NombrePet { get; set; }
        public string? Direccion { get; set; }
        public string? NombrePropietario { get; set; }
        public string? CedulaPropietario { get; set; }
        public string? Telefono { get; set; }
    }
}
