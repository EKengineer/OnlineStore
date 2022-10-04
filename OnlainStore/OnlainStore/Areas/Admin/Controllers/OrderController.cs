using Microsoft.AspNetCore.Mvc;
using OlineStore;
using OlineStore.Models;
using OnlineStore.Areas.Admin.Modals;
using OnlineStore.Helpers;
using Store;
using Store_Memory;
using System.Xml.Serialization;

namespace OnlineStore.Areas.Admin.Controllers
{
    [Area("Admin")]
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
        public IActionResult Buy(OrderViewModel orderViewModel)
        {
            if (ModelState.IsValid)
            {
                var cart = cartRepository.GetByUserId(Constants.UserId);
                var order = Mapping.ToOrder(orderViewModel, cart);

                orderRepositoty.Add(order);
                cartRepository.Clear(Constants.UserId);

                var orders = orderRepositoty.GetByUseID(Constants.UserId);
                return View(orders);
            }
            return RedirectToAction("Index", "Cart");
        }
        public IActionResult Orders()
        {
            var order = orderRepositoty.GetAllOrder();

            return View(order);
        }

        

        public IActionResult EditOrder(int id, string status)
        {;
            orderRepositoty.EditOrder(id, status);

            return RedirectToAction("OrderViewModel", "Order");
        }


    }
}
