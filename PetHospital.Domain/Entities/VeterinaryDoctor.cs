using PetHospital.Infraestructure.Core;
using System.ComponentModel.DataAnnotations;

namespace PetHospital.Infraestructure.Entities
{
    public class VeterinaryDoctor : BaseEntity
    {
        [Key]
        public int IdVeterinario { get; set; }
        [StringLength(50)]
        public string NombreVeterinario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string? Telefono { get; set; }
        [StringLength(100)]
        public string? Direccion { get; set; }

    }
}