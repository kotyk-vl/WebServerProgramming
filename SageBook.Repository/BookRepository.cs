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

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.Include(s => s.Sages);
        }

        public Book GetBooksById(int id)
        {
            return _context.Books.Include(s => s.Sages).First(x => x.BookId == id);
        }

        public Book AddNewBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }

        public Book EditBook(Book book)
        {
            var bookToUpdate = _context.Books.FirstOrDefault(x => x.BookId == book.BookId);

            if (bookToUpdate != null)
            {
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
            }

            return book;
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.First(x => x.BookId == id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public List<Book> SearchBook(string searchTerm)
        {
            return _context.Books.Include(s => s.Sages).Where(book =>
                book.Name.Contains(searchTerm)
                || book.Description.Contains(searchTerm)
            ).ToList();
        }
    }
}