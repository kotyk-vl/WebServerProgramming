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
            var bookToUpdate = _context.Books.Include(s => s.Sages).First(x => x.BookId == book.BookId);

            bookToUpdate.Name = book.Name;
            bookToUpdate.Description = book.Description;

            bookToUpdate.Sages.Clear();

            foreach (var item in book.Sages)
            {
                var sage = _context.Sages.Find(item.SageId);
                bookToUpdate.Sages.Add(sage);
            }
            _context.SaveChanges();

            return book;
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.Include(s => s.Sages).First(x => x.BookId == id);
            book.Sages.Clear();
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}