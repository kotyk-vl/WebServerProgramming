using SageBook.Service.Models.Sage;

namespace SageBook.Service.Interfaces
{
    public interface ISageService
    {
        IQueryable<SageModel> GetSages();

        SageModel? GetSageById(int id);

        void AddSage(SageModel sage);

        void EditSage(SageModel sage);

        void DeleteSage(int id);
    }
}