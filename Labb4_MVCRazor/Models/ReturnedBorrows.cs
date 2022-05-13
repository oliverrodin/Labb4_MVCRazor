namespace Labb4_MVCRazor.Models
{
    public class ReturnedBorrows
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
