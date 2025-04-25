using PetHospital.Infraestructure.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace PetHospital.Infraestructure.Entities
{ 
public class Appointments : BaseEntity
    {
    [Key]
    public int IdCita { get; set; }
    public DateTime Fecha { get; set; }
    public DateTime Hora { get; set; }
    public int? IdPet { get; set; }
    public int? IdVeterinario { get; set; }
    [StringLength(50)]
    public string? MotivoCita { get; set; }
    
}
}