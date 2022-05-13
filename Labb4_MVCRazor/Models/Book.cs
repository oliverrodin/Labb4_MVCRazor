using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Labb4_MVCRazor.Data.Base;
using Labb4_MVCRazor.Data.Enums;

namespace Labb4_MVCRazor.Models
{
    public class Book : IEntityBase
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = string.Empty;

        [DisplayName("Image Url")]
        [Required(ErrorMessage = "Image Url is required")]
        public string ImageUrl { get; set; } = string.Empty;

        [DisplayName("Book category")]
        [Required(ErrorMessage = "Book Category is required")]
        public BookCategory BookCategory { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }

        [DisplayName("Publish Year")]
        [Required(ErrorMessage = "Publish year is required")]
        public int Published { get; set; }

        [DisplayName("Serial Number")]
        [Required(ErrorMessage = "Serial number is required")]
        public string SerialNumber { get; set; }


        public ICollection<ActiveBorrows> ActiveBorrows { get; set; } = new List<ActiveBorrows>();
        public ICollection<ReturnedBorrows> ReturnedBorrows { get; set;} = new List<ReturnedBorrows>();


    }
}

