using ApiDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiInterfaces
{
    public interface ICustomerService
    {
        Task<bool> CreateAsync(Customer customer);

        Task<Customer?> GetAsync(Guid id);

        Task<IEnumerable<Customer>> GetAllAsync();

        Task<bool> UpdateAsync(Customer customer);

        Task<bool> DeleteAsync(Guid id);
       
    }
}
