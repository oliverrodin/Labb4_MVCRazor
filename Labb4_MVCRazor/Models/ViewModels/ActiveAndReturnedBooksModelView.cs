namespace Labb4_MVCRazor.Models.ViewModels
{
    public class ActiveAndReturnedBooksModelView
    {
        public IEnumerable<ActiveBorrows> ActiveBorrows { get; set; } = new List<ActiveBorrows>();
        public IEnumerable<ReturnedBorrows> ReturnedBorrows { get; set; } = new List<ReturnedBorrows>();

    }
}
