using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Xml.Linq;
using Store;

namespace Store_Memory
{
    public class OrderRepository : IOrderRepositoty
    {
        private readonly List<Order> orders = new List<Order>();
        
        public Order Add(string name, string phone, string email, string address, string comment, Cart cart)
        {
            int nexrId = this.orders.Count + 1;
            Order order = new Order(nexrId,  name,  phone, email, address, comment, cart);

            orders.Add(order);

            return order;
        }
        public void EditOrder(int id, string name, string phone, string email, string address, string comment, string status, DateTime dateTime, Cart cart)
        {
            Order order = new Order(id, name, phone, email, address, comment, status, dateTime, cart);
            orders.Add(order);


        }
        public void RemuveOrderById(int orderId)
        {
            var order = orders.Single(order => order.Id == orderId);
            orders.Remove(order);
        }
        public Order ReturnOrderById(int orderId)
        {
            var order = orders.Single(order => order.Id == orderId);

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

        public List<Order> GetAllOrder()
        {
            return orders;
        }
    }
}
