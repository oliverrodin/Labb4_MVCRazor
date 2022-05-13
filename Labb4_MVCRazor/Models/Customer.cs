using System.ComponentModel.DataAnnotations;
using Labb4_MVCRazor.Data.Base;

namespace Labb4_MVCRazor.Models
{
    public class Customer : IEntityBase
    {
        [Key] public int Id { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number is required.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = string.Empty;


        public ICollection<ActiveBorrows> ActiveBorrows { get; set; } = new List<ActiveBorrows>();
        public ICollection<ReturnedBorrows> ReturnedBorrows { get; set; } = new List<ReturnedBorrows>();
    }

}
