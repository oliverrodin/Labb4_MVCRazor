using Labb4_MVCRazor.Data.Services.CustomerService;
using Labb4_MVCRazor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labb4_MVCRazor.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public async Task<IActionResult> Index()
        {
            var allCustomers = await _customerService.GetAllAsync();
            return View(allCustomers);
        }


        //GET: Customer/create
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, Email, PhoneNumber, Address")]Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }

            await _customerService.AddAsync(customer);
            return RedirectToAction(nameof(Index));
        }

        //GET: Customer/delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            if (customer == null)
                return View("NotFound");
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            if (customer == null)
                return View("NotFound");

            await _customerService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //GET: Customer/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            if (customer == null)
                return View("NotFound");
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([Bind("Id, Name, Email, PhoneNumber, Address")] int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }

            await _customerService.UpdateAsync(id, customer);
            return RedirectToAction(nameof(Index));
        }

        //GET: Customer/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var customer = await _customerService.GetCustomerIncludeBooksByIdAsync(id);
            if (customer == null)
                return View("NotFound");
            return View(customer);
        }
    }
}
