using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Labb4_MVCRazor.Data.Enums;

namespace Labb4_MVCRazor.Models.ViewModels
{
    public class BookViewModel
    {
        public int BookId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [DisplayName("Image Url")]
        public string ImageUrl { get; set; } = string.Empty;

        [DisplayName("Book category")]
        public BookCategory BookCategory { get; set; }

        public string Author { get; set; }

        [DisplayName("Publish Year")]
        public int Published { get; set; }

        [DisplayName("Serial Number")]
        public string SerialNumber { get; set; }
        public bool IsAvailable { get; set; }
    }
}
