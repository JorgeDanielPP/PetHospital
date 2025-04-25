using PetHospital.Application.DTOs;
using PetHospital.Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetHospital.Infrastructure.Interfaces
{
    public interface IAppointmentRepository
    {
    //    Task<IEnumerable<AppointmentsDTO>> GetByIdAsync(int id);

    //    Task<List<AppointmentsDTO>> GetAll();

        Task<Appointments> Add(AppointmentsDTO dto);

        Task<bool> Update(Appointments dto);

        Task<bool> Delete(int id);
    }
}
