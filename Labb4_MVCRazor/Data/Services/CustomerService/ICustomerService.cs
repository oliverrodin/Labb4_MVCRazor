using Labb4_MVCRazor.Data.Base;
using Labb4_MVCRazor.Models;

namespace Labb4_MVCRazor.Data.Services.CustomerService
{
    public interface ICustomerService : IEntityBaseRepository<Customer>
    {
        Task<Customer> GetCustomerIncludeBooksByIdAsync(int id);
    }
}
