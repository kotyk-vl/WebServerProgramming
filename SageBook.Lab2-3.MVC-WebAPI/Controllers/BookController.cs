using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SageBook.Lab2_3.MVC_WebAPI.Models.Book;
using SageBook.Service.Interfaces;
using SageBook.Service.Models.Book;

namespace SageBook.Lab2.MVC.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly ISageService _sageService;

        public BookController(IBookService bookService, ISageService sageService)
        {
            _bookService = bookService;
            _sageService = sageService;
        }

        // GET: BookController
        public ActionResult Index()
        {
            var books = _bookService.GetBooks().Select(x => BookToViewModel(x));
            return View(books);
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            var model = new BookViewModel();
            var book = _bookService.GetBooks().FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                RedirectToAction("Index");
            }

            InitModel(model, book);
            model.Sages = GetSages(book);

            return View(model);
        }

        private static void InitModel(BookViewModel model, BookModel? book)
        {
            model.Id = book.Id;
            model.Name = book.Name;
            model.Description = book.Description;
        }

        private List<SelectListItem> GetSages(BookModel? book)
        {
            var list = new List<SelectListItem>();
            var sages = _sageService.GetSages().ToList();

            foreach (var sage in sages)
            {
                list.Add(new SelectListItem
                {
                    Value = sage.Id.ToString(),
                    Text = sage.Name,
                    Selected = book != null && book.SageIds.Contains(sage.Id)
                });
            }
            return list;
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            var model = new BookViewModel();
            model.Sages = GetSages(null);

            return View(model);
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _bookService.AddNewBook(BookFromViewModel(model));

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View(model);
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            var book = _bookService.GetBookById(id);

            if (book == null)
            {
                RedirectToAction("Index");
            }

            var model = BookToViewModel(book);
            model.Sages = GetSages(book);

            return View(model);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BookViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _bookService.EditBook(BookFromViewModel(model));
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var book = _bookService.GetBookById(model.Id);
                    model.Sages = GetSages(book);
                    return View(model);
                }
            }
            catch
            {
                return View(model);
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            var book = _bookService.GetBookById(id);

            if (book == null)
            {
                RedirectToAction("Index");
            }

            return View(BookToViewModel(book));
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(BookViewModel model)
        {
            try
            {
                _bookService.DeleteBook(model.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        private readonly Func<BookModel, BookViewModel> BookToViewModel = (book) => new BookViewModel
        {
            Id = book.Id,
            Description = book.Description,
            Name = book.Name
        };

        private readonly Func<BookViewModel, BookModel> BookFromViewModel = (book) => new BookModel
        {
            Id = book.Id,
            Description = book.Description,
            Name = book.Name,
            SageIds = book.Sages
                .Select(x => int.Parse(x.Value))
                .ToList()
        };
    }
}