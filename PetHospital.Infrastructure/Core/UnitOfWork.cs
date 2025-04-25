using PetHospital.Infraestructure;
using PetHospital.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHospital.Infrastructure.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppointmentsContext _context;
        private bool disposedValue;


        public UnitOfWork(AppointmentsContext context)
        {
            _context = context;
        }

        public async Task BeginTransactionAsync()
        {
            await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            await _context.Database.CommitTransactionAsync();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task RollbackTransactionAsync()
        {
            await _context.Database.RollbackTransactionAsync();
        }

    }
}
