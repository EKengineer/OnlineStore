using Microsoft.AspNetCore.Mvc;
using OnlineStore.Areas.Admin.Modals;
using Store;
using Store_Memory;
using System.Xml.Serialization;

namespace OnlineStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IOrderRepositoty orderRepositoty;

        public OrderController(IOrderRepositoty orderRepositoty)
        {
           
            this.orderRepositoty = orderRepositoty;
        }
        public IActionResult Orders()
        {
            var order = orderRepositoty.GetAllOrder();

            return View(order);
        }

        

        public IActionResult EditOrder(int id, string status)
        {
            var order = orderRepositoty.ReturnOrderById(id);
            orderRepositoty.RemuveOrderById(id);
            orderRepositoty.EditOrder(order.Id, order.Name, order.Phone, order.Email, order.Address, order.Comment, status, order.DateTime, order.Cart);

            return RedirectToAction("Orders", "Order");
        }


    }
}
