using Microsoft.EntityFrameworkCore;
using SageBook.Data.Models;

namespace SageBook.Repository.Interfaces
{
    public interface ISageRepository
    {
        IEnumerable<Sage> GetSages();
        Sage GetSagesById(int id);
        Sage AddNewSage(Sage sage);
        Sage EditSage(Sage sage);
        void DeleteSage(int id);
    }
}