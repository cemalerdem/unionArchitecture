using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnionArcDemo.ApplicationCore.Interfaces.EFInitialize;
using UnionArcDemo.Persistence;

namespace UnionArcDemo.Infrastructure.Repositories.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed;
        private readonly NorthwindContext _context;

        public UnitOfWork(NorthwindContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int Commit()
        {
            return  SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await SaveChangesAsync();
        }

        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        private async Task<int> SaveChangesAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        private int SaveChanges()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}