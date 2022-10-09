using Microsoft.AspNetCore.Mvc;
using OnlineStore.Helpers;
using Store_Memory;
using Store_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlineStore.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ICartRepositoty cartRepository;

        public CartController(ICartRepositoty cartRepository, IProductRepository productRepository)
        {
            this.productRepository = productRepository;
            this.cartRepository = cartRepository;
        }

        public IActionResult Index()
        {
            var cartCount = cartRepository.GetCount();
            
            if (cartCount)
            {
                var cart = cartRepository.GetByUserId(Constants.UserId);

                return View(Mapping.ToCatViewModel(cart));

            }

            return View("Empty");
        }



        public IActionResult AddItem(int id)
        {
            var produc = productRepository.GetProductById(id);

            cartRepository.AddItem(produc, Constants.UserId);
           
            return RedirectToAction("Index", "Cart");

        }


        public IActionResult ReduceItem(int id)
        {
            var cart = cartRepository.GetByUserId(Constants.UserId);
            if (cart != null)
            {
                var produc = productRepository.GetProductById(id);

                cartRepository.ReduceItem(produc, Constants.UserId);
            }


            return RedirectToAction("Index", "Cart");
        }

        public IActionResult RemoveItem(int id)
        {
            var cart = cartRepository.GetByUserId(Constants.UserId);
            if (cart != null)
            {
                var produc = productRepository.GetProductById(id);

                cartRepository.RemoveItem(produc, Constants.UserId);
            }

            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Clear()
        {
            cartRepository.Clear(Constants.UserId);

            return RedirectToAction("Index", "Cart");
        }


    }
}
