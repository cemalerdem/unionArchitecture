using UnionArcDemo.ApplicationCore.Entities;
using UnionArcDemo.ApplicationCore.Interfaces.EFInitialize;

namespace UnionArcDemo.ApplicationCore.Interfaces.Repositories
{
    public interface ICustomerRepository : IEFRepository<Customer>
    {
        
    }
}