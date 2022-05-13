using Labb4_MVCRazor.Data.Base;
using Labb4_MVCRazor.Models;
using Labb4_MVCRazor.Models.ViewModels;

namespace Labb4_MVCRazor.Data.Services.BookService
{
    public interface IBookService : IEntityBaseRepository<Book>
    {
        Task<List<BookViewModel>> GetAllBooksIncludeAsync();
    }
}
