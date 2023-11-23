using Microsoft.EntityFrameworkCore;
using SageBook.Data.Models;
using SageBook.Repository.Interfaces;

namespace SageBook.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly SageBookContext _context;

        public BookRepository()
        {
            _context = new SageBookContext();
        }

        public IQueryable<Book> GetBooks()
        {
            return _context.Books.Include(s => s.Sages).AsNoTracking();
        }

        public Book AddNewBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }

        public Book EditBook(Book book)
        {
            var bookToUpdate = _context.Books.First(b => b.BookId == book.BookId);

            bookToUpdate.Name = book.Name;
            bookToUpdate.Description = book.Description;

            if (book.Sages.Count > 0)
            {
                bookToUpdate.Sages.Clear();
                foreach (var sage in book.Sages)
                {
                    bookToUpdate.Sages.Add(sage);
                }
            }
            _context.SaveChanges();
            return book;
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.First(x => x.BookId == id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}