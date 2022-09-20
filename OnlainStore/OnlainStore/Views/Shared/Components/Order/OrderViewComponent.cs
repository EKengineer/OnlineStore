using Microsoft.AspNetCore.Mvc;
using Store;

namespace OlineStore.Views.Shared.ViewComponents.CartViewComponents
{
    public class OrderViewComponent : ViewComponent
    {
        private readonly ICartRepositoty cartRepository;

        public OrderViewComponent(ICartRepositoty cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        public IViewComponentResult Invoke()
        {
            var cart = cartRepository.GetByUserId(Constants.UserId);
            var productCounts = cart?.TotalCount;


            return View("Order", productCounts);
        }
    }   
}
