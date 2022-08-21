
using ApiContracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiInterfaces
{
    public interface ICustomerRepository
    {
        Task<bool> CreateAsync(CustomerDto customer);

        Task<CustomerDto?> GetAsync(Guid id);

        Task<IEnumerable<CustomerDto>> GetAllAsync();

        Task<bool> UpdateAsync(CustomerDto customer);

        Task<bool> DeleteAsync(Guid id);
    }
}
