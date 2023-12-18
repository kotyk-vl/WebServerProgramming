using Microsoft.AspNetCore.Mvc;
using SageBook.Common.Extensions;
using SageBook.Service.Models.Book;

namespace SageBook.Lab2_3.MVC_WebAPI.Controllers
{
    public class SageBaseController : Controller
    {
        public List<BookModel> OrderBooks
        {
            get => HttpContext.Session.Get<List<BookModel>>("OrderBooks") ?? new List<BookModel>();
            set => HttpContext.Session.Set("OrderBooks", value);
        }

        public void ClearOrders()
        {
            OrderBooks = null;
        }
    }
}