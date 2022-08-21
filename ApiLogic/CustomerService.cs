using ApiContracts.Data;
using ApiDomain;
using ApiInterfaces;
using ApiMapper;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLogic
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IDatabaseInitializer DatabaseInitializer;

        public CustomerService(ICustomerRepository customerRepository, IDatabaseInitializer databaseInitializer)
        {
            _customerRepository = customerRepository;
            DatabaseInitializer = databaseInitializer;
            
        }
    
        public async Task<bool> CreateAsync(Customer customer)
        {
            var existingUser = await _customerRepository.GetAsync(customer.Id.Value);
            if (existingUser is not null)
            {
                var message = $"A user with id {customer.Id} already exists";
                throw new ValidationException(message, new[]
                {
                new ValidationFailure(nameof(Customer), message)
            });
            }

            var customerDto = customer.ToCustomerDto();
            return await _customerRepository.CreateAsync(customerDto);
        }

        public async Task<Customer?> GetAsync(Guid id)
        {
            var customerDto = await _customerRepository.GetAsync(id);
            return customerDto?.ToCustomer();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            var customerDtos = await _customerRepository.GetAllAsync();
            return customerDtos.Select(x => x.ToCustomer());
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            var customerDto = customer.ToCustomerDto();
            return await _customerRepository.UpdateAsync(customerDto);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _customerRepository.DeleteAsync(id);
        }

      
    }

}
