using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PetHospital.Api.Models.Entities
{

    public class Pets
    {
        [Key]
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
