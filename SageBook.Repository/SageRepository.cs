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

        public IEnumerable<Sage> GetSages()
        {
            return _context.Sages.Include(x=>x.Books);
        }

        public Sage GetSagesById(int id)
        {
            return _context.Sages.Include(s=>s.Books).First(x => x.SageId == id);
        }

        public Sage AddNewSage(Sage sage)
        {
            _context.Sages.Add(sage);
            _context.SaveChanges();
            return sage;
        }

        public Sage EditSage(Sage sage)
        {
            var sageToUpdate = _context.Sages.First(x => x.SageId == sage.SageId);

            sageToUpdate.Age = sage.Age;
            sageToUpdate.City = sage.City;
            sageToUpdate.Photo = sage.Photo;

            _context.SaveChanges();

            return sage;
        }

        public void DeleteSage(int id)
        {
            var sage = _context.Sages.First(x => x.SageId == id);
            _context.Sages.Remove(sage);
            _context.SaveChanges();
        }
    }
}