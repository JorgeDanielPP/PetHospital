using PetHospital.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Application.Interfaces
{
    public interface IAppointmentsServices
    {
        Task<IEnumerable<AppointmentsDTO>> GetAllAsync();
        Task<AppointmentsDTO?> GetByIdAsync(int id);
        Task<AppointmentsDTO> CreateAsync(AppointmentsDTO dto);
        Task<bool> UpdateAsync(int id, AppointmentsDTO dto);
        Task<bool> DeleteAsync(int id);
    }
}
