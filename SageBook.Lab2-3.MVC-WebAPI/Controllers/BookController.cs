using Microsoft.AspNetCore.Mvc;
using SageBook.Service.Interfaces;
using SageBook.Service.Models.Book;

namespace SageBook.Lab2.MVC.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: BookController
        public ActionResult Index()
        {
            var books = _bookService.GetBooks().ToList();
            return View(books);
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            var book = _bookService.GetBooks().FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                RedirectToAction("Index");
            }

            return View(book);
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            var book = new BookModel();

            return View(book);
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _bookService.AddNewBook(model);

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

            return View(book);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BookModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _bookService.EditBook(model);
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

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            var book = _bookService.GetBookById(id);

            if (book == null)
            {
                RedirectToAction("Index");
            }

            return View(book);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(BookModel model)
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
    }
}