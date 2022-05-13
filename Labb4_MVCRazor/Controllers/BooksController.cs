using Labb4_MVCRazor.Data.Services.BookService;
using Labb4_MVCRazor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labb4_MVCRazor.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public async Task<IActionResult> Index()
        {
            var allBooks = await _bookService.GetAllBooksIncludeAsync();
            return View(allBooks);
        }

        public async Task<IActionResult> Details(int id)
        {
            var book = await _bookService.GetByIdAsync(id);
            if (book == null)
                return View("NotFound");

            return View(book);
        }

        //GET: Books/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Title, Description, ImageUrl, BookCategory, Author, Published, SerialNumber")] Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            await _bookService.AddAsync(book);
            return RedirectToAction(nameof(Index));
        }

        //GET: Books/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var book = await _bookService.GetByIdAsync(id);
            if (book == null) return View("NotFound");

            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Title, Description, ImageUrl, BookCategory, Author, Published, SerialNumber")] Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            await _bookService.UpdateAsync(id, book);
            return RedirectToAction(nameof(Index));
        }
    }
}
