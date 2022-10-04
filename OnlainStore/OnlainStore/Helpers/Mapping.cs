using OlineStore.Models;
using OnlineStore.Models;
using Store;
using Store.Model;
using Store_Memory;
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

        public static Order ToOrder(OrderViewModel order, Cart cart)
        {
            var Order = new Order
            {
                Id = order.Id,
                Address = order.Address,
                Status = order.Status,
                Cart = cart,
                Comment = order.Comment,
                DateTime = order.DateTime,
                Email = order.Email,
                Name = order.Name,
                Phone = order.Phone,
            };
            return Order;
        }


    }
}
