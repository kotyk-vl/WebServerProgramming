using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SageBook.Lab2_3.MVC_WebAPI.Models.WebAPI;
using SageBook.Service.Interfaces;
using SageBook.Service.Models.Order;

namespace SageBook.Lab2_3.MVC_WebAPI.Controllers.WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookOrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IBookService _bookService;
        private readonly UserManager<IdentityUser> _userManager;

        public BookOrderController(IOrderService orderService,
            UserManager<IdentityUser> userManager,
            IBookService bookService)
        {
            _orderService = orderService;
            _userManager = userManager;
            _bookService = bookService;
        }

        // GET: api/<BookOrderController>
        [HttpGet]
        public async Task<List<OrderAPIResponse>> GetOrders()
        {
            var orders = _orderService.GetOrders().ToList();

            var response = new List<OrderAPIResponse>();

            foreach (var order in orders)
            {
                response.Add(new OrderAPIResponse
                {
                    Id = order.Id,
                    BookId = order.BookId,
                    UserId = order.UserId,
                    CreatedDate = order.CreatedDate,
                    CanceledDate = order.CanceledDate,
                    UserName = (await _userManager.FindByIdAsync(order.UserId)).UserName,
                    BookName = _bookService.GetBookById(order.BookId).Name
                });
            }
            return response;
        }

        // GET api/<BookOrderController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var order = _orderService.GetOrderById(id);

            if (order == null)
            {
                return NotFound();
            }
            var response = new OrderAPIResponse
            {
                Id = order.Id,
                BookId = order.BookId,
                UserId = order.UserId,
                CreatedDate = order.CreatedDate,
                CanceledDate = order.CanceledDate,
                UserName = (await _userManager.FindByIdAsync(order.UserId)).UserName,
                BookName = _bookService.GetBookById(order.BookId).Name
            };

            return new JsonResult(response);
        }

        // POST api/<BookOrderController>
        [HttpPost]
        public ActionResult Post(OrderModel order)
        {
            try
            {
                var newOrder = _orderService.AddNewOrder(new OrderModel
                {
                    BookId = order.BookId,
                    UserId = order.UserId,
                    CreatedDate = DateTime.Now
                });

                return new JsonResult(newOrder);
            }
            catch (Exception ex)
            {
                return new JsonResult(new APIResponse
                {
                    Success = false,
                    Message = ex.Message,
                });
            }
        }

        // PUT api/<BookOrderController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id)
        {
            try
            {
                var order = _orderService.GetOrderById(id);

                if (order == null)
                {
                    return NotFound();
                }

                var updatedOrder = _orderService.EditOrder(order);

                var response = new OrderAPIResponse
                {
                    Id = updatedOrder.Id,
                    BookId = updatedOrder.BookId,
                    UserId = updatedOrder.UserId,
                    CreatedDate = updatedOrder.CreatedDate,
                    CanceledDate = updatedOrder.CanceledDate,
                    UserName = (await _userManager.FindByIdAsync(updatedOrder.UserId)).UserName,
                    BookName = _bookService.GetBookById(updatedOrder.BookId).Name
                };

                return new JsonResult(response);
            }
            catch (Exception ex)
            {
                return new JsonResult(new APIResponse
                {
                    Success = false,
                    Message = ex.Message,
                });
            }
        }

        // DELETE api/<BookOrderController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var order = _orderService.GetOrderById(id);

                if (order == null)
                {
                    return NotFound();
                }

                _orderService.DeleteOrder(id);

                return new JsonResult(new APIResponse() { Success = true });
            }
            catch (Exception ex)
            {
                return new JsonResult(new APIResponse
                {
                    Success = false,
                    Message = ex.Message,
                });
            }
        }
    }
}