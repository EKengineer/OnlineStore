using Microsoft.AspNetCore.Mvc;
using OlineStore.Models;
using Store;
using Store_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlineStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly ProductRepository productRepository;
        private readonly IOrderRepositoty orderRepository;

        public OrderController(IOrderRepositoty orderRepository)
        {
            productRepository = new ProductRepository();
            this.orderRepository = orderRepository;
        }

        public IActionResult Index()
        {

            if (HttpContext.Session.TryGetCart(out Cart cart))
            {
               var order = orderRepository.GetById(cart.OrderId);
               OrderModel model = Map(order);

                return View(model);

            }

            return View("Empty");
        }

        private OrderModel Map(Order order)
        {
            var productIds = order.Items.Select(item => item.ProductId);
            var products = productRepository.GetAllbiIds(productIds);
            var itemModels = from item in order.Items
                             join product in products on item.ProductId equals product.Id
                             select new OrderItemModel
                             {
                                 ProductId = product.Id,
                                 Count = item.Count,
                                 ProductName = product.Name,
                                 Description = product.Description,
                                 Price = item.Price,
                             };
            return new OrderModel
            {
                Id = order.Id,
                Items = itemModels.ToArray(),
                TotalCount = order.TotalCount,
                TotalPrice = order.TotalPrice,
            };

        }

        public IActionResult AddItem(int id)
        {
            

            Order order;
            Cart cart;

            if (HttpContext.Session.TryGetCart(out cart))
            {
                order = orderRepository.GetById(cart.OrderId);
            }
            else
            {
                order = orderRepository.Create();
                cart = new Cart(order.Id);
            }

            var produc = productRepository.ReturnIdNameCostDescriptionProduct(id);

            order.AddItem(produc, 1);
            orderRepository.Update(order);

            cart.TotalPrice = order.TotalPrice;
            cart.TotalCount = order.TotalCount;
            
            HttpContext.Session.Set(cart);

            return RedirectToAction("Index", "Order");
        }

        public IActionResult ReduceItem(int id)
        {


            Order order;
            Cart cart;

            if (HttpContext.Session.TryGetCart(out cart))
            {
                order = orderRepository.GetById(cart.OrderId);
            }
            else
            {
                return RedirectToAction("Index", "Order");
            }

            var produc = productRepository.ReturnIdNameCostDescriptionProduct(id);

            order.ReduceItem(produc, 1);
            orderRepository.Update(order);

            cart.TotalPrice = order.TotalPrice;
            cart.TotalCount = order.TotalCount;

            HttpContext.Session.Set(cart);

            return RedirectToAction("Index", "Order");
        }

        public IActionResult RemoveItem(int id)
        {


            Order order;
            Cart cart;

            if (HttpContext.Session.TryGetCart(out cart))
            {
                order = orderRepository.GetById(cart.OrderId);
            }
            else
            {
                return RedirectToAction("Index", "Order");
            }

            var produc = productRepository.ReturnIdNameCostDescriptionProduct(id);

            order.RemoveItem(produc);
            orderRepository.Update(order);

            cart.TotalPrice = order.TotalPrice;
            cart.TotalCount = order.TotalCount;

            HttpContext.Session.Set(cart);

            return RedirectToAction("Index", "Order");
        }
        
    }
}
