using Microsoft.AspNetCore.Mvc;
using OnlineStore.Helpers;
using Store_Memory;

namespace OlineStore.Views.Shared.ViewComponents.CartViewComponents
{
    public class OrdersViewComponent : ViewComponent
    {
        private readonly ICartRepositoty cartRepository;

        public OrdersViewComponent(ICartRepositoty cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        public IViewComponentResult Invoke()
        {
            var cart = cartRepository.GetByUserId(Constants.UserId);
            if (cart == null)
            {
                return View("Orders", 0);
            }
            var productCounts = Mapping.ToCatViewModel(cart).TotalCount;


            return View("Orders", productCounts);
        }
    }   
}
