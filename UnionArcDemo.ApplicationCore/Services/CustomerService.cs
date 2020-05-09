using UnionArcDemo.ApplicationCore.Interfaces.EFInitialize;
using UnionArcDemo.ApplicationCore.Interfaces.Repositories;
using UnionArcDemo.ApplicationCore.Interfaces.Services;

namespace UnionArcDemo.ApplicationCore.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CustomerService(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }
    }
}