using Microsoft.AspNetCore.Mvc;
using SageBook.Lab2_3.MVC_WebAPI.Models;
using SageBook.Lab2_3.MVC_WebAPI.Models.Order;
using SageBook.Service.Interfaces;
using System.Diagnostics;

namespace SageBook.Lab2_3.MVC_WebAPI.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IBookService _bookService;
        private readonly ISageService _sageService;

        public OrderController(ILogger<OrderController> logger, IBookService bookService, ISageService sageService)
        {
            _logger = logger;
            _bookService = bookService;
            _sageService = sageService;
        }

        public IActionResult Index()
        {
            var viewModel = _bookService
                .GetBooks()
                .Select(x => new OrderViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    SageList = _sageService
                    .GetSages()
                    .Where(s => x.SageIds.Contains(s.Id))
                    .Select(n => n.Name)
                    .OrderBy(o => o)
                    .ToList()
                }).ToList();

            return View(viewModel);
        }

        public IActionResult BookOrder(int id)
        {
            var book = _bookService.GetBookById(id);

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}