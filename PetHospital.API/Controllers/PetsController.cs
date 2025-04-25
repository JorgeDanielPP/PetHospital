using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetHospital.Infraestructure;
using PetHospital.Infraestructure.Entities;
using PetHospital.PetHospital.Domain.Entities;

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
        public async Task<ActionResult<IEnumerable<Pets>>> GetMascotas()
        {
            var pets = await _appointmentsContext.Pets.ToListAsync();
            return Ok(pets);

        }

        [HttpGet]
        [Route("consultar")]
        public async Task<IActionResult> ConsultarMascota(int id)
        {
            Pets pets = await _appointmentsContext.Pets.FindAsync(id);

            if (pets == null)
            {
                return NotFound();
            }

            return Ok(pets);

        }

        [HttpPut]
        [Route("editar")]
        public async Task<IActionResult> ModificarMascota(int id, Pets pets)
        {
            var petsExistente = await _appointmentsContext.Pets.FindAsync(id);

            petsExistente.Raza = pets.Raza;
            petsExistente.Edad = pets.Edad;
            petsExistente.Sexo = pets.Sexo;
            petsExistente.Color = pets.Color;
            petsExistente.NombrePet = pets.NombrePet;
            petsExistente.Direccion = pets.Direccion;
            petsExistente.NombrePropietario = pets. NombrePropietario;
            petsExistente.CedulaPropietario = pets.CedulaPropietario;
            petsExistente.Telefono = pets.Telefono;
            await _appointmentsContext.SaveChangesAsync();


            return Ok();

        }

        [HttpDelete]
        [Route("eliminar")]
        public async Task<ActionResult> EliminarMascota(int id)
        {
            var mascotaEliminada = await _appointmentsContext.Pets.FindAsync(id);
            _appointmentsContext.Pets.Remove(mascotaEliminada);
            await _appointmentsContext.SaveChangesAsync();
            return Ok();
        }




    }

}
