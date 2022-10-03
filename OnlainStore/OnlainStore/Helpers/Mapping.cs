using OnlineStore.Models;
using Store;
using System.Collections.Generic;

namespace OnlineStore.Helpers
{
    public class Mapping
    {

        public static CartViewModel ToCatViewModel(Cart cart)
        {
            return new CartViewModel(cart.Id, ToCatItemViewModel(cart.items), cart.UserId);
        }
        public static List<CartItemViewModel> ToCatItemViewModel(List<CartItem> cartDbItems)
        {
            var cartItems = new List<CartItemViewModel>();
            foreach (var cartDbItem in cartDbItems)
            {
                var cartItem = new CartItemViewModel(cartDbItem.Id, cartDbItem.Count, cartDbItem.Product);

                cartItems.Add(cartItem);
            }
            return cartItems;
        }

    }
}
