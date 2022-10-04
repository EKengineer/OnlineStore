using Microsoft.AspNetCore.Mvc;
using OnlineStore.Helpers;
using Store;

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

            var productCounts = Mapping.ToCatViewModel(cart).TotalCount;


            return View("OrderViewModel", productCounts);
        }
    }   
}
