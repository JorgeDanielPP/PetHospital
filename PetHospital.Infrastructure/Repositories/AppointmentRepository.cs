using Microsoft.EntityFrameworkCore;
using PetHospital.Application.DTOs;
using PetHospital.Infraestructure.Entities;
using PetHospital.Infraestructure;
using PetHospital.Infrastructure.Core;
using PetHospital.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Infrastructure.Repositories
{
    public class AppointmentRepository : BaseRepository<Appointments>, IAppointmentRepository   
    {
        public AppointmentRepository(AppointmentsContext context) : base(context) {  }
        public async Task<Appointments> Add(AppointmentsDTO dto)
        {
            return await Add(dto);
        }

        public async Task<bool> Delete(int id)
        {
            return await Delete(id);
        }

     //   public async Task<List<AppointmentsDTO>> GetAll()
       // {
         //   return await _context.ToListAsync();
         //   context.Students.ToList();

//        }

        public async Task<bool> Update(Appointments dto)
        {
        return await Update(dto);
    }

  //      async Task<IEnumerable<AppointmentsDTO>> IAppointmentRepository.GetByIdAsync(int id)
    //    {
      //      return await _context.AppointmentsDTO.FindAsync(id);
       // }
    }
}
