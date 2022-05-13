using Labb4_MVCRazor.Data.Base;
using Labb4_MVCRazor.Data.Context;
using Labb4_MVCRazor.Models;
using Labb4_MVCRazor.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Labb4_MVCRazor.Data.Services.BookService
{
    public class BookService : EntityBaseRepository<Book> , IBookService
    {
        private readonly AppDbContext _context;

        public BookService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<BookViewModel>> GetAllBooksIncludeAsync()
        {
            var books = await _context.Books
                .Include(h => h.ActiveBorrows)
                .Select(b => new BookViewModel
                {
                    BookId = b.Id,
                    Title = b.Title,
                    Description = b.Description,
                    ImageUrl = b.ImageUrl,
                    BookCategory = b.BookCategory,
                    Author = b.Author,
                    Published = b.Published,
                    SerialNumber = b.SerialNumber,
                    IsAvailable = !b.ActiveBorrows
                        .Any(h => h.ExpireDate != null)
                }).ToListAsync();

            return books;
        }
    }
}
