using PetHospital.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Application.Interfaces
{
    public interface IPetsServices
    {
        Task<IEnumerable<PetsDTO>> GetAllAsync();
        Task<PetsDTO?> GetByIdAsync(Guid id);
        Task<PetsDTO> CreateAsync(AppointmentsDTO dto);
        Task<bool> UpdateAsync(int id, PetsDTO dto);
        Task<bool> DeleteAsync(int id);
    }
}
