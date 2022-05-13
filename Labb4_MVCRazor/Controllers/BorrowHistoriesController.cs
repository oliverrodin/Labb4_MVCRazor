using Labb4_MVCRazor.Data.Services.BookService;
using Labb4_MVCRazor.Data.Services.BorrowHistoryService;
using Labb4_MVCRazor.Data.Services.CustomerService;
using Labb4_MVCRazor.Models;
using Labb4_MVCRazor.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Labb4_MVCRazor.Controllers
{
    public class BorrowHistoriesController : Controller
    {
        private readonly IBorrowHistoryService _borrowHistory;
        private readonly IBookService _bookService;
        private readonly ICustomerService _customerService;

        public BorrowHistoriesController(IBorrowHistoryService borrowHistory,
            IBookService bookService, ICustomerService customerService)
        {
            _borrowHistory = borrowHistory;
            _bookService = bookService;
            _customerService = customerService;
        }
        public async Task<IActionResult> Index()
        {
            var model = new ActiveAndReturnedBooksModelView();
            model.ReturnedBorrows = await _borrowHistory.GetAllIncludedReturnedBorrowsAsync();
            model.ActiveBorrows = await _borrowHistory.GetAllIncludedActiveBorrowsAsync();

            return View(model);
        }

        public async Task<IActionResult> Create()
        {
            var history = await _borrowHistory.GetAllIncludedActiveBorrowsAsync();
            var books = await _bookService.GetAllAsync();
            var customers = await _customerService.GetAllAsync();

            ViewBag.Books = new SelectList(books, "Id", "Title");
            ViewBag.Customers = new SelectList(customers, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("BookId, CustomerId")] ActiveBorrowsViewModel borrowHistory)
        {
            if (ModelState.IsValid)
            {
                borrowHistory.IssueDate = DateTime.Now;
                borrowHistory.ExpireDate = DateTime.Now.AddDays(14);
                await _borrowHistory.AddNewBorrowHistoryAsync(borrowHistory);
                return RedirectToAction("Index");
            }

            var books = await _bookService.GetAllAsync();
            var customers = await _customerService.GetAllAsync();
            ViewBag.Books = new SelectList(books, "Id", "Title");
            ViewBag.Customers = new SelectList(customers, "Id", "Name");
            return View();
        }

        public async Task<IActionResult> Return(int id)
        {
            var history = await _borrowHistory.GetIncludedBorrowHistory(id);

            if (history == null) return View("NotFound");

            return View(history);
        }

        [HttpPost, ActionName("Return")]
        public async Task<IActionResult> ConfirmReturn(int id)
        {
            var bookToReturn = await _borrowHistory.GetByIdAsync(id);

            await _borrowHistory.ReturnIssuedBookAsync(bookToReturn);
            return RedirectToAction("Index", "BorrowHistories");


        }
    }
}
