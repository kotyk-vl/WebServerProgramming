using SageBook.Data.Models;

namespace SageBook.Repository.Interfaces
{
    public interface ISageRepository
    {
        IEnumerable<Sage> GetSages();

        Sage AddNewSage(Sage sage);

        Sage EditSage(Sage sage);

        void DeleteSage(int id);
    }
}