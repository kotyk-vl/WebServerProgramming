using SageBook.Service.Models.Book;

namespace SageBook.Service.Interfaces
{
    public interface IBookService
    {
        IQueryable<BookModel> GetBooks();

        BookModel? GetBookById(int id);

        void AddNewBook(BookModel book);

        void EditBook(BookModel book);

        void DeleteBook(int id);

        IQueryable<BookModel> SearchBook(string searchPattern);
    }
}