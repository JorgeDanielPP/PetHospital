using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetHospital.Api.Data;
using PetHospital.Api.Models.Entities;

namespace PetHospital.Api.Controllers
{
    public class VeterinaryDoctorsController : Controller
    {
        private readonly PetHospitalApiContext _context;

        public VeterinaryDoctorsController(PetHospitalApiContext context)
        {
            _context = context;
        }

        // GET: VeterinaryDoctors
        public async Task<IActionResult> Index()
        {
            return View(await _context.VeterinaryDoctor.ToListAsync());
        }

        // GET: VeterinaryDoctors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veterinaryDoctor = await _context.VeterinaryDoctor
                .FirstOrDefaultAsync(m => m.IdVeterinario == id);
            if (veterinaryDoctor == null)
            {
                return NotFound();
            }

            return View(veterinaryDoctor);
        }

        // GET: VeterinaryDoctors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VeterinaryDoctors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVeterinario,NombreVeterinario,FechaIngreso,Telefono,Direccion")] VeterinaryDoctor veterinaryDoctor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(veterinaryDoctor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(veterinaryDoctor);
        }

        // GET: VeterinaryDoctors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veterinaryDoctor = await _context.VeterinaryDoctor.FindAsync(id);
            if (veterinaryDoctor == null)
            {
                return NotFound();
            }
            return View(veterinaryDoctor);
        }

        // POST: VeterinaryDoctors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVeterinario,NombreVeterinario,FechaIngreso,Telefono,Direccion")] VeterinaryDoctor veterinaryDoctor)
        {
            if (id != veterinaryDoctor.IdVeterinario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(veterinaryDoctor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeterinaryDoctorExists(veterinaryDoctor.IdVeterinario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(veterinaryDoctor);
        }

        // GET: VeterinaryDoctors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veterinaryDoctor = await _context.VeterinaryDoctor
                .FirstOrDefaultAsync(m => m.IdVeterinario == id);
            if (veterinaryDoctor == null)
            {
                return NotFound();
            }

            return View(veterinaryDoctor);
        }

        // POST: VeterinaryDoctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var veterinaryDoctor = await _context.VeterinaryDoctor.FindAsync(id);
            if (veterinaryDoctor != null)
            {
                _context.VeterinaryDoctor.Remove(veterinaryDoctor);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeterinaryDoctorExists(int id)
        {
            return _context.VeterinaryDoctor.Any(e => e.IdVeterinario == id);
        }
    }
}
