using Microsoft.EntityFrameworkCore;
using SageBook.Data.Models;

namespace SageBook.Repository.Interfaces
{
    public interface IBookRepository
    {
       IEnumerable<Book> GetBooks();
       Book GetBooksById(int id);
       Book AddNewBook(Book book);
       Book EditBook(Book book);
       void DeleteBook(int id);
       List<Book> SearchBook(string searchTerm);
    }
}