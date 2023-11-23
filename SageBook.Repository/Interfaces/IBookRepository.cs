using SageBook.Data.Models;

namespace SageBook.Repository.Interfaces
{
    public interface IBookRepository
    {
        IQueryable<Book> GetBooks();

        Book AddNewBook(Book book);

        Book EditBook(Book book);

        void DeleteBook(int id);
    }
}