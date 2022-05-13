using Labb4_MVCRazor.Data.Base;

namespace Labb4_MVCRazor.Models
{
    public class ActiveBorrows : IEntityBase
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? ExpireDate { get; set; }

        
    }
}
