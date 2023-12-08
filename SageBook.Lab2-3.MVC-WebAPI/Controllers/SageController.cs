using Microsoft.AspNetCore.Mvc;
using SageBook.Common.Helpers;
using SageBook.Service.Interfaces;
using SageBook.Service.Models.Sage;

namespace SageBook.Lab2.MVC.Controllers
{
    public class SageController : Controller
    {
        private readonly ISageService _sageService;

        public SageController(ISageService sageService)
        {
            _sageService = sageService;
        }

        // GET: SageController
        public ActionResult Index()
        {
            var sages = _sageService.GetSages().ToList();
            return View(sages);
        }

        // GET: SageController/Details/5
        public ActionResult Details(int id)
        {
            var sage = _sageService.GetSages().FirstOrDefault(x => x.Id == id);

            if (sage == null)
            {
                RedirectToAction("Index");
            }

            return View(sage);
        }

        // GET: SageController/Create
        public ActionResult Create()
        {
            var sage = new SageModel();

            return View(sage);
        }

        // POST: SageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SageModel model)
        {
            try
            {
                _sageService.AddSage(model);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: SageController/Edit/5
        public ActionResult Edit(int id)
        {
            var sage = _sageService.GetSages().FirstOrDefault(x => x.Id == id);

            if (sage == null)
            {
                RedirectToAction("Index");
            }

            return View(sage);
        }

        // POST: SageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SageModel model)
        {
            try
            {
                if (Request.Form.Files.Count > 0)
                {
                    var file = Request.Form.Files[0];
                    model.Photo = ImageHelper.FormFileToByteArray(file);
                }

                _sageService.EditSage(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: SageController/Delete/5
        public ActionResult Delete(int id)
        {
            var sage = _sageService.GetSages().FirstOrDefault(x => x.Id == id);

            if (sage == null)
            {
                RedirectToAction("Index");
            }

            return View(sage);
        }

        // POST: SageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(SageModel model)
        {
            try
            {
                _sageService.DeleteSage(model.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}