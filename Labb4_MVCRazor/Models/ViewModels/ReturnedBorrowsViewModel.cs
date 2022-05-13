using System.ComponentModel.DataAnnotations;

namespace Labb4_MVCRazor.Models.ViewModels
{
    public class ReturnedBorrowsViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Book")]
        [Required(ErrorMessage = "Book is required.")]
        public int BookId { get; set; }

        [Display(Name = "Customer")]
        [Required(ErrorMessage = "Customer is required.")]
        public int CustomerId { get; set; }

        [Display(Name = "Issue Date")]
        [Required(ErrorMessage = "Issue Date is required.")]
        public DateTime IssueDate { get; set; }

        [Display(Name = "Expire Date")]
        [Required(ErrorMessage = "Expire Date is required.")]
        public DateTime ExpireDate { get; set; }

        [Display(Name = "Return Date")]
        [Required(ErrorMessage = "Return Date is required.")]
        public DateTime ReturnDate { get; set; }
    }
}
