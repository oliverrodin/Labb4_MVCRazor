using Labb4_MVCRazor.Data.Base;
using Labb4_MVCRazor.Data.Context;
using Labb4_MVCRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4_MVCRazor.Data.Services.CustomerService
{
    public class CustomerService : EntityBaseRepository<Customer> , ICustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Customer> GetCustomerIncludeBooksByIdAsync(int id)
        {
            var customer = await _context.Customers
                .Include(x => x.ActiveBorrows)
                .ThenInclude(b => b.Book)
                .Include(x => x.ReturnedBorrows)
                .ThenInclude(b => b.Book)
                .FirstOrDefaultAsync(c => c.Id == id);

            return customer;
        }
    }
}
