using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Application.DTOs
{
    public class PetsDTO
    {
        public int IdPet { get; set; }
        public required string? Raza { get; set; }
        public required int Edad { get; set; }
        public required string? Sexo { get; set; }
        public required string? Color { get; set; }
        public required string? NombrePet { get; set; }
        public required string? Direccion { get; set; }
        public required string? NombrePropietario { get; set; }
        public required string? CedulaPropietario { get; set; }
        public required string? Telefono { get; set; }
    }
}
