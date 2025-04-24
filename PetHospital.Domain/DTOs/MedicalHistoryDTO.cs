using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Domain.DTOs
{
    public class MedicalHistoryDTO
    {
        public int IdHistorial { get; set; }
        public int IdPet { get; set; }
        public int IdCita { get; set; }
        public string? HistorialVacunas { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? MedicamentosRecetados { get; set; }
        public string? Diagnostico { get; set; }
    }
}
