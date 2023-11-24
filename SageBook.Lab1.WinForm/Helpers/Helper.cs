using SageBook.Common.Models;
using SageBook.Service.Models.Book;
using SageBook.Service.Models.Sage;

namespace SageBook.Lab1.WinForm.Helpers
{
    public static class Helper
    {
        public static readonly Func<SageModel, ComboItem> GetSageList = (sage) => new ComboItem
        {
            ID = sage.Id,
            Text = sage.Name
        };

        public static readonly Func<BookModel, ComboItem> GetBookList = (book) => new ComboItem
        {
            ID = book.Id,
            Text = book.Name
        };
    }
}