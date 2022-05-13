using Labb4_MVCRazor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labb4_MVCRazor.Data.EntityConfigurations
{
    public class BorrowHistoryConfiguration : IEntityTypeConfiguration<ActiveBorrows>
    {
        public void Configure(EntityTypeBuilder<ActiveBorrows> builder)
        {
            
        }
    }
}
