using System.ComponentModel.DataAnnotations;

namespace Labb4_MVCRazor.Models.ViewModels
{
    public class ActiveBorrowsViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Book")]
        [Required(ErrorMessage = "Book is required")]
        public int BookId { get; set; }

        [Display(Name = "Customer")]
        [Required(ErrorMessage = "Customer is required")]
        public int CustomerId { get; set; }

        [Display(Name = "Issue date")]
        [Required(ErrorMessage = "Issue date is required")]
        public DateTime IssueDate { get; set; } = DateTime.Now;

        [Display(Name = "Expire Date")]
        [Required(ErrorMessage = "Return date is required")]
        public DateTime ExpireDate { get; set; }
    }
}
