using System.ComponentModel.DataAnnotations;

namespace PetHospital.Web.Models.Entities
{
    public class VeterinaryDoctorViewModel
    {
        [Key]
        public int IdVeterinario { get; set; }
        public string NombreVeterinario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }

    }
}