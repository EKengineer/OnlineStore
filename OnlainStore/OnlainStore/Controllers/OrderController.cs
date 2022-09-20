using Microsoft.AspNetCore.Mvc;
using OlineStore.Models;
using Store;
using Store_Memory;
using Order = OlineStore.Models.Order;

namespace OlineStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartRepositoty cartRepository;
        private readonly IOrderRepositoty orderRepositoty;

        public OrderController(ICartRepositoty cartRepository, IOrderRepositoty orderRepositoty)
        {
            this.cartRepository = cartRepository;
            this.orderRepositoty = orderRepositoty;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
            public IActionResult Buy(Order order)
        {
            var cart = cartRepository.GetByUserId(Constants.UserId);

            orderRepositoty.Add(order.Name,order.Phone, order.Address, cart);
            cartRepository.Clear(Constants.UserId);

             var orders = orderRepositoty.GetByUseID(Constants.UserId);
            return View(orders);
        }
    }
} 
