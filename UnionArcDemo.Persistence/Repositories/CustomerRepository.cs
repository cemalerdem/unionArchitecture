using UnionArcDemo.ApplicationCore.Entities;
using UnionArcDemo.ApplicationCore.Interfaces.Repositories;
using UnionArcDemo.Infrastructure.Repositories.Base;
using UnionArcDemo.Persistence;

namespace UnionArcDemo.Infrastructure.Repositories
{
    public class CustomerRepository : EFRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(NorthwindContext context) : base(context)
        { }
    }
}