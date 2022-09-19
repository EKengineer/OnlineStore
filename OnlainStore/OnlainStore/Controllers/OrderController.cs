using Microsoft.AspNetCore.Mvc;
using Store;
using Store_Memory;

namespace OlineStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartRepositoty cartRepository;
        private readonly IOrderRepositoty orderRepositoty;

        public OrderController(ICartRepositoty cartRepository, IOrderRepositoty orderRepositoty)
        {
            this.cartRepository = cartRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
            public IActionResult Buy()
        {
            var cart = cartRepository.GetByUserId(Constants.UserId);
            orderRepositoty.Add(cart);
            cartRepository.Clear(Constants.UserId);
            return View(cart);
        }
    }
} 
