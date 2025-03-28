using System;
using System.ComponentModel.DataAnnotations;

namespace PetHospitals.Web.Models.Entities
{ 
public class AppointmentViewModel
{
    [Key]
    public int IdCita { get; set; }
    public DateTime Fecha { get; set; }
    public DateTime Hora { get; set; }
    public int? IdPet { get; set; }
    public int? IdVeterinario { get; set; }
    public string? MotivoCita { get; set; }
    
}
}