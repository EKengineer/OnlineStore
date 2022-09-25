using Microsoft.AspNetCore.Mvc;
using OlineStore.Models;
using Store;
using Store_Memory;
using Orders = OlineStore.Models.Orders;

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


        [HttpPost]
            public IActionResult Buy(Orders order)
        {
            if (ModelState.IsValid)
            {
                var cart = cartRepository.GetByUserId(Constants.UserId);

                 orderRepositoty.Add(order.Name, order.Phone,order.Email, order.Address, order.Comment, cart);
                cartRepository.Clear(Constants.UserId);

                var orders = orderRepositoty.GetByUseID(Constants.UserId);
                return View(orders);
            }
            return RedirectToAction("Index", "Cart");
        }
    }
} 
