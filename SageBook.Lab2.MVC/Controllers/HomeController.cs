using Microsoft.AspNetCore.Mvc;
using SageBook.Data.Models;
using SageBook.Lab2.MVC.Models;
using System.Diagnostics;

namespace SageBook.Lab2.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SageBookContext _context;

        public HomeController(ILogger<HomeController> logger, SageBookContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
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