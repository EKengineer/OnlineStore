using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Store;

namespace Store_Memory
{
    public class OrderRepository : IOrderRepositoty
    {
        private readonly List<Order> orders = new List<Order>();
        
        public Order Add(string name, string phone, string address, Cart cart)
        {
            int nexrId = this.orders.Count + 1;
            Order order = new Order(nexrId,  name,  phone,  address, cart);

            orders.Add(order);

            return order;
        }

        public Order GetByUseID(string userId)
        {
            
            return orders.FirstOrDefault(order => order.GetUserID() == userId);
        }

        public Order GetByName(string name)
        {

            return orders.FirstOrDefault(order => order.Name == name);
        }

        public Order GetByPhone(string phone)
        {

            return orders.FirstOrDefault(order => order.Phone == phone);
        }

    }
}
