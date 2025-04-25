using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Application.DTOs
{
    public class MedicalHistoryDTO
    {
        public int IdHistorial { get; set; }
        public required int IdPet { get; set; }
        public required int IdCita { get; set; }
        public required string? HistorialVacunas { get; set; }
        public DateTime FechaCreacion { get; set; }
        public required string? MedicamentosRecetados { get; set; }
        public required string? Diagnostico { get; set; }
    }
}
