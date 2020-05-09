using System;
using System.Threading;
using System.Threading.Tasks;

namespace UnionArcDemo.ApplicationCore.Interfaces.EFInitialize
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
        Task<int> CommitAsync();
        void Dispose(bool disposing);

    }
}