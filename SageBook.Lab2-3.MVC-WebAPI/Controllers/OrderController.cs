using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SageBook.Lab2_3.MVC_WebAPI.Models;
using SageBook.Lab2_3.MVC_WebAPI.Models.Order;
using SageBook.Service.Interfaces;
using SageBook.Service.Models.Order;
using System.Diagnostics;

namespace SageBook.Lab2_3.MVC_WebAPI.Controllers
{
    public class OrderController : SageBaseController
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IBookService _bookService;
        private readonly ISageService _sageService;
        private readonly IOrderService _orderService;
        private readonly SignInManager<IdentityUser> _signInManager;

        public OrderController(ILogger<OrderController> logger
            , IBookService bookService
            , ISageService sageService
            , IOrderService orderService
            , SignInManager<IdentityUser> signInManager)
        {
            _logger = logger;
            _bookService = bookService;
            _sageService = sageService;
            _orderService = orderService;
            _signInManager = signInManager;
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

            var orders = OrderBooks;

            if (orders.Select(x => x.Id).Contains(id))
            {
            }
            else
            {
                orders.Add(book);
                OrderBooks = orders;
            }

            return GetOrderBooks();
        }

        public IActionResult CancelOrder(int id)
        {
            var orders = OrderBooks;
            var order = orders.FirstOrDefault(o => o.Id == id);
            orders.Remove(order);

            OrderBooks = orders;

            return RedirectToAction("Index");
        }

        public IActionResult GetOrderBooks()
        {
            var orders = OrderBooks;
            return PartialView("_OrderBooks", orders);
        }

        public IActionResult CompleteOrder()
        {
            var isSignedIn = _signInManager.IsSignedIn(User);

            if (!isSignedIn)
            {
                return RedirectToAction("Index");
            }

            var orderBooks = OrderBooks;
            var userId = _signInManager.UserManager.GetUserId(User);

            if (orderBooks != null)
            {
                foreach (var orderBook in orderBooks)
                {
                    _orderService.AddNewOrder(new OrderModel
                    {
                        BookId = orderBook.Id,
                        UserId = userId,
                        CreatedDate = DateTime.Now
                    });
                }
            }

            ClearOrders();

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