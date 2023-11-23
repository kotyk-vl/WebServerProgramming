using SageBook.Data.Models;
using SageBook.Repository.Interfaces;
using SageBook.Service.Interfaces;
using SageBook.Service.Models.Book;

namespace SageBook.Service.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IQueryable<BookModel> GetBooks()
        {
            return _bookRepository.GetBooks()
                .Select(BookToModel)
                .AsQueryable();
        }

        public BookModel? GetBookById(int id)
        {
            return _bookRepository.GetBooks()
                .Where(b => b.BookId == id)
                .Select(BookToModel)
                .FirstOrDefault();
        }

        public void AddNewBook(BookModel book)
        {
            _bookRepository.AddNewBook(new Book
            {
                Description = book.Description,
                Name = book.Name,
            });
        }

        public void EditBook(BookModel book)
        {
            _bookRepository.EditBook(BookFromModel(book));
        }

        public void DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
        }

        public IQueryable<BookModel> SearchBook(string searchPattern)
        {
            return _bookRepository.GetBooks()
                .Where(x => x.Name.Contains(searchPattern)
                    || x.Description.Contains(searchPattern)
                    || x.Sages.Select(s => s.Name).Contains(searchPattern))
                .Select(BookToModel)
                .AsQueryable();
        }

        private readonly Func<Book, BookModel> BookToModel = (book) => new BookModel
        {
            Id = book.BookId,
            Name = book.Name,
            Description = book.Description,
            SageIds = book.Sages == null || book.Sages.Count == 0
                ? new List<int>()
                : book.Sages
                .Select(sage => sage.SageId)
                .ToList()
        };

        private readonly Func<BookModel, Book> BookFromModel = (book) => new Book
        {
            BookId = book.Id,
            Description = book.Description,
            Name = book.Name,
            Sages = book.SageIds
                    .Select(sageId => new Sage { SageId = sageId })
                    .ToList()
        };
    }
}