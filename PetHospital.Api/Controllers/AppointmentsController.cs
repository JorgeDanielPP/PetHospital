using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetHospital.Domain;
using PetHospital.Domain.Entities;
using System.Collections.Generic;

namespace PetHospital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly AppointmentsContext _appointmentsContext;

        public AppointmentsController(AppointmentsContext appointmentsContext)
        {
            _appointmentsContext = appointmentsContext;
        }
        [HttpPost]
        [Route("crear")]
        public async Task<IActionResult> CrearCita(Appointments appointments)
        {
            await _appointmentsContext.AddAsync(appointments);
            await _appointmentsContext.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<Appointments>>> GetCita()
        {
            var appointments = await _appointmentsContext.Appointments.ToListAsync();
            return Ok(appointments);

        }

        [HttpGet]
        [Route("consultar")]
        public async Task<IActionResult> ConsultarCita(int id)
        {
            Appointments appointments = await _appointmentsContext.Appointments.FindAsync(id);

            if (appointments == null)
            {
                return NotFound();
            }

            return Ok(appointments);

        }
        [HttpPut]
        [Route("editar")]
        public async Task<IActionResult> ModificarCita(int id, Appointments appointments)
        {
            var appointmentExistente = await _appointmentsContext.Appointments.FindAsync(id);

            appointmentExistente.IdVeterinario = appointments.IdVeterinario;
            appointmentExistente.IdPet = appointments.IdPet;
            appointmentExistente.Hora = appointments.Hora;
            appointmentExistente.IdVeterinario = appointments.IdVeterinario;
            appointmentExistente.MotivoCita = appointments.MotivoCita;

            await _appointmentsContext.SaveChangesAsync();


            return Ok();

        }
        [HttpDelete]
        [Route("delete")]
        public async Task<ActionResult> EliminarCita(int id)
        {
            var citaEliminada = await _appointmentsContext.Appointments.FindAsync(id);
            _appointmentsContext.Appointments.Remove(citaEliminada);
            await _appointmentsContext.SaveChangesAsync();
            return Ok();
        }

   

        
    }
}



