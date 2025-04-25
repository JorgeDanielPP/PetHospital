using PetHospital.Infraestructure.Core;
using System.ComponentModel.DataAnnotations;

namespace PetHospital.Infraestructure.Entities
{
    public class MedicalHistory : BaseEntity
    {
        [Key]
        public int IdHistorial { get; set; }
        public int IdPet { get; set; }
        public int IdCita { get; set; }
        [StringLength(500)]
        public string? HistorialVacunas { get; set; }
        public DateTime FechaCreacion { get; set; }
        [StringLength(500)]
        public string? MedicamentosRecetados { get; set; }
        [StringLength(500)]
        public string? Diagnostico { get; set; }
        

    }
}

