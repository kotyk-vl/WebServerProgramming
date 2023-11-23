using SageBook.Data.Models;
using SageBook.Repository.Interfaces;
using SageBook.Service.Interfaces;
using SageBook.Service.Models.Sage;

namespace SageBook.Service.Services
{
    public class SageService : ISageService
    {
        private readonly ISageRepository _sageRepository;

        public SageService(ISageRepository sageRepository)
        {
            _sageRepository = sageRepository;
        }

        public IQueryable<SageModel> GetSages()
        {
            return _sageRepository.GetSages()
                .Select(SageToModel)
                .AsQueryable();
        }

        public SageModel? GetSageById(int id)
        {
            return _sageRepository.GetSages()
                .Where(s => s.SageId == id)
                .Select(SageToModel)
                .FirstOrDefault();
        }

        public void AddSage(SageModel sage)
        {
            _sageRepository.AddNewSage(new Sage
            {
                Name = sage.Name,
                Age = sage.Age,
                Photo = sage.Photo,
                City = sage.City,
            });
        }

        public void EditSage(SageModel sage)
        {
            _sageRepository.EditSage(SageFromModel(sage));
        }

        public void DeleteSage(int id)
        {
            _sageRepository.DeleteSage(id);
        }

        private readonly Func<Sage, SageModel> SageToModel = (sage) => new SageModel
        {
            Id = sage.SageId,
            Name = sage.Name,
            Age = sage.Age,
            Photo = sage.Photo,
            City = sage.City,
            BookIds = sage.Books
                        .Select(b => b.BookId)
                        .ToList()
        };

        private readonly Func<SageModel, Sage> SageFromModel = (sage) => new Sage
        {
            SageId = sage.Id,
            Name = sage.Name,
            Age = sage.Age,
            Photo = sage.Photo,
            City = sage.City,
            Books = sage.BookIds
                    .Select(bookId => new Book { BookId = bookId })
                    .ToList()
        };
    }
}