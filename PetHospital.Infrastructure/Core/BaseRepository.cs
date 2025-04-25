using Microsoft.EntityFrameworkCore;
using PetHospital.Infraestructure;
using PetHospital.Infraestructure.Core;
using PetHospital.Infraestructure;
using PetHospital.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Infrastructure.Core
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppointmentsContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(DbContext context)
        {
            _context = (AppointmentsContext?)context;
            _dbSet = context.Set<T>();
        }


        public async Task<bool> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            return true;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entityDb = await _dbSet.FindAsync(id);
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
            _dbSet.Update(entity);
            return true;
        }
    }
}
