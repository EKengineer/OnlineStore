using OlineStore.Models;
using OnlineStore.Models;
using Store_Memory;
using Store_Memory;
using System.Collections.Generic;

namespace OnlineStore.Helpers
{
    public class Mapping
    {

        public static CartViewModel ToCatViewModel(Cart cart)
        {
            if (cart == null)
            {
                return null;
            }
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

        public static Order ToOrder(OrderViewModel order, List<CartItem> cartDbItems)
        {
            var Order = new Order
            {
                Id = order.Id,
                Status = order.Status,
                Comment = order.Comment,
                DateTime = order.DateTime,
                CartItem = cartDbItems,
                User = new UserDeliveryInfo
                {
                    Email = order.Email,
                    Name = order.Name,
                    Phone = order.Phone,
                    Address = order.Address,
                }
                
                
            };
            return Order;
        }
        
        public static OrderViewModel ToOrderViewModel(Order order)
        {
            OrderViewModel orderViewModel = new OrderViewModel(order.Id, order.User.Name, order.User.Phone, order.User.Email, order.User.Address, order.Comment, order.DateTime, order.Status, ToCatItemViewModel(order.CartItem));

            return orderViewModel;
        }
        public static List<OrderViewModel> ToListOrderViewModel(List<Order> order)
        {
            var listOrder = new List<OrderViewModel>();
            foreach (var orderItem in order)
            {
                var orderViewModel = new OrderViewModel(orderItem.Id, orderItem.User.Name, orderItem.User.Phone, orderItem.User.Email, orderItem.User.Address, orderItem.Comment, orderItem.DateTime, orderItem.Status, ToCatItemViewModel(orderItem.CartItem));

                listOrder.Add(orderViewModel);
            }

            return listOrder;
        }
    }
}
