using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetHospital.Domain;
using PetHospital.Domain.Entities;
using PetHospital.Domain.Migrations;
using System.Collections.Generic;
namespace PetHospital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly AppointmentsContext _appointmentsContext;

        public PetsController(AppointmentsContext appointmentsContext)
        {
            _appointmentsContext = appointmentsContext;
        }

        [HttpPost]
        [Route("crear")]
        public async Task<IActionResult> CrearMascota(Pets pets)
        {
            await _appointmentsContext.AddAsync(pets);
            await _appointmentsContext.SaveChangesAsync();

            return Ok();
        }
        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<Pets>>> GetMascota()
        {
            var pets = await _appointmentsContext.Pets.ToListAsync();
            return Ok(pets);

        }

        [HttpGet]
        [Route("consultar")]
        public async Task<ActionResult> ConsultarMascota(int id)
        {
            var pets = await _appointmentsContext.Pets.FindAsync(id);

            if (pets == null)
            {
                return NotFound();
            }

            return Ok(pets);

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
