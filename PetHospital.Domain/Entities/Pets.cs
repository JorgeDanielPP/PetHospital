using PetHospital.Infraestructure.Core;
using System.ComponentModel.DataAnnotations;

namespace PetHospital.PetHospital.Domain.Entities
{
    public class Pets : BaseEntity
    {
        [Key]
        public int IdPet { get; set; }
        [StringLength(50)]
        public string? Raza { get; set; }
        public int Edad { get; set; }
        [StringLength(1)]
        public string? Sexo { get; set; }
        [StringLength(50)]
        public string? Color { get; set; }
        [StringLength(50)]
        public string? NombrePet { get; set; }
        [StringLength(100)]
        public string? Direccion { get; set; }
        [StringLength(50)]
        public string? NombrePropietario { get; set; }
        public string? CedulaPropietario { get; set; }
        public string? Telefono { get; set; }

    }
}
