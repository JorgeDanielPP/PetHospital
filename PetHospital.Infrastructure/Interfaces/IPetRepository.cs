using PetHospital.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Infrastructure.Interfaces
{
    public interface IPetRepository
    {
        Task<IEnumerable<PetsDTO>> GetByIdAsync(int id);

        Task<List<PetsDTO>> GetAll(string filter);

        Task<PetsDTO> Add(PetsDTO dto);

        Task<bool> Update(PetsDTO dto);

        Task<bool> Delete(int id);
    }
}
