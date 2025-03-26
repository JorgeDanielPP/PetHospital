using System.ComponentModel.DataAnnotations;

namespace PetHospital.Api.Models.Entities
{
    public class VeterinaryDoctor
    {
        [Key]
        public int IdVeterinario { get; set; }
        public string? NombreVeterinario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }

    }
}