using Microsoft.EntityFrameworkCore;
using PetHospital.Domain;
using PetHospital.Domain.Core;
using PetHospital.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Infrastructure.Core
{
    public class BaseRepositoy<T>(AppointmentsContext context) : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppointmentsContext _context = context;
        protected readonly DbSet<T> DbSet = context.Set<T>();

        public async Task<bool> CreateAsync(T entity)
        {
            await DbSet.AddAsync(entity);
            return true;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            DbSet.Remove(entity);
            return true;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entityDb = await DbSet.FindAsync(id);
            if (entityDb == null)
            {
                throw new Exception("Not found");
            }

            return entityDb;
        }

        public async Task SaveChangesAync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            DbSet.Update(entity);
            return true;
        }
    }
}
