using Labb4_MVCRazor.Data.Base;
using Labb4_MVCRazor.Data.Context;
using Labb4_MVCRazor.Models;
using Labb4_MVCRazor.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Labb4_MVCRazor.Data.Services.BorrowHistoryService
{
    public class BorrowHistoryService : EntityBaseRepository<ActiveBorrows>, IBorrowHistoryService
    {
        private readonly AppDbContext _context;

        public BorrowHistoryService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<ActiveBorrows>> GetAllIncludedActiveBorrowsAsync()
        {
            var borrows = await _context.ActiveBorrows
                .Include(b => b.Book)
                .Include(c => c.Customer)
                .ToListAsync();

            return borrows;
        }

        public async Task<List<ReturnedBorrows>> GetAllIncludedReturnedBorrowsAsync()
        {
            var borrows = await _context.ReturnedBorrows
                .Include(b => b.Book)
                .Include(c => c.Customer)
                .ToListAsync();

            return borrows;
        }

        public async Task<ActiveBorrows> GetIncludedBorrowHistory(int id)
        {
            var borrow = await _context.ActiveBorrows
                .Include(b => b.Book)
                .Include(c => c.Customer)
                .FirstOrDefaultAsync(b => b.Id == id);

            return borrow;
        }

        public async Task AddNewBorrowHistoryAsync(ActiveBorrowsViewModel data)
        {
            var newBorrow = new ActiveBorrows()
            {
                BookId = data.BookId,
                CustomerId = data.CustomerId,
                IssueDate = data.IssueDate,
                ExpireDate = data.ExpireDate
            };

            await _context.ActiveBorrows.AddAsync(newBorrow);
            await _context.SaveChangesAsync();
        }

        public async Task ReturnIssuedBookAsync(ActiveBorrows data)
        {
            var newReturn = new ReturnedBorrows()
            {
                BookId = data.BookId,
                CustomerId = data.CustomerId,
                IssueDate = data.IssueDate,
                ExpireDate = data.ExpireDate,
                ReturnDate = DateTime.Now

            };

            await _context.ReturnedBorrows.AddAsync(newReturn);
            await _context.SaveChangesAsync();

            var removeFromActive = await _context.ActiveBorrows.FindAsync(data.Id);

            if (removeFromActive != null)
            {
                _context.ActiveBorrows.Remove(removeFromActive);
                await _context.SaveChangesAsync();
            }


        }
    }
}
    
