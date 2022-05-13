using Labb4_MVCRazor.Data.Base;
using Labb4_MVCRazor.Models;
using Labb4_MVCRazor.Models.ViewModels;

namespace Labb4_MVCRazor.Data.Services.BorrowHistoryService
{
    public interface IBorrowHistoryService : IEntityBaseRepository<ActiveBorrows>
    {
        Task<List<ActiveBorrows>> GetAllIncludedActiveBorrowsAsync();
        Task<List<ReturnedBorrows>> GetAllIncludedReturnedBorrowsAsync();
        Task<ActiveBorrows> GetIncludedBorrowHistory(int id);
        Task AddNewBorrowHistoryAsync(ActiveBorrowsViewModel data);

        Task ReturnIssuedBookAsync(ActiveBorrows data);

    }
}
