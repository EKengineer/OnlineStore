using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OlineStore;
using OlineStore.Models;
using OnlineStore.Areas.Admin.Modals;
using OnlineStore.Helpers;
using Store_Memory;
using Store_Memory.models;
using System.Xml.Serialization;

namespace OnlineStore.Areas.Admin.Controllers
{
    [Area(Constants.AdminRoleName)]
    [Authorize(Roles = Constants.AdminRoleName)]
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
                var order = Mapping.ToOrder(orderViewModel, cart.items);

                orderRepositoty.Add(order);
                cartRepository.Clear(Constants.UserId);

                return View(Mapping.ToOrderViewModel(order));
            }
            return RedirectToAction("Index", "Cart");
        }
        public IActionResult Orders()
        {
            var order = orderRepositoty.GetAllOrder();

            return View(Mapping.ToListOrderViewModel(order));
        }

        

        public IActionResult EditOrder(int id, string status)
        {;
            orderRepositoty.EditOrder(id, status);

            return RedirectToAction("Orders", "Order");
        }


    }
}
