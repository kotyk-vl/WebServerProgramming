using SageBook.Data.Models;

namespace SageBook.Repository.Interfaces
{
    public interface ISageRepository
    {
        IQueryable<Sage> GetSages();

        Sage AddNewSage(Sage sage);

        Sage EditSage(Sage sage);

        void DeleteSage(int id);
    }
}