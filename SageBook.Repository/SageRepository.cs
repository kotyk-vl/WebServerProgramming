using Microsoft.EntityFrameworkCore;
using SageBook.Data.Models;
using SageBook.Repository.Interfaces;

namespace SageBook.Repository
{
    public class SageRepository : ISageRepository
    {
        private readonly SageBookContext _context;

        public SageRepository()
        {
            _context = new SageBookContext();
        }

        public IQueryable<Sage> GetSages()
        {
            return _context.Sages.Include(x => x.Books).AsNoTracking();
        }

        public Sage AddNewSage(Sage sage)
        {
            _context.Sages.Add(sage);
            _context.SaveChanges();
            return sage;
        }

        public Sage EditSage(Sage sage)
        {
            var sageToUpdate = _context.Sages.Include(s => s.Books).First(x => x.SageId == sage.SageId);

            sageToUpdate.Name = sage.Name;
            sageToUpdate.Age = sage.Age;
            sageToUpdate.City = sage.City;
            sageToUpdate.Photo = sage.Photo;

            sageToUpdate.Books.Clear();

            foreach (var item in sage.Books)
            {
                var book = _context.Books.Find(item.BookId);
                sageToUpdate.Books.Add(book);
            }

            _context.SaveChanges();

            return sage;
        }

        public void DeleteSage(int id)
        {
            var sage = _context.Sages.Include(s => s.Books).First(x => x.SageId == id);
            sage.Books.Clear();
            _context.Sages.Remove(sage);
            _context.SaveChanges();
        }
    }
}