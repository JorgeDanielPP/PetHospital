using System.ComponentModel.DataAnnotations;

namespace PetHospital.Api.Models.Entities
{
    public class MedicalHistory
    {
        [Key]
        public int IdHistorial { get; set; }
        public int IdPet { get; set; }
        public int IdCita { get; set; }
        public string? HistorialVacunas { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? MedicamentosRecetados { get; set; }
        public string? Diagnostico { get; set; }
        

    }
}

