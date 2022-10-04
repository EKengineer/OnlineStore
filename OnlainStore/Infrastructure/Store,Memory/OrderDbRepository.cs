using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Xml.Linq;
using Store.Model;

namespace Store_Memory
{
    public class OrderDbRepository : IOrderRepositoty
    {
        private readonly DatabaseContext databaseContext;

        public OrderDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Order Add(Order order)
        {
            databaseContext.Orders.Add(order);
            databaseContext.SaveChanges();

            return order;
        }
        public void EditOrder(int id, string status)
        {
            var order = databaseContext.Orders.Single(order => order.Id == id);

            order.Status = status;

            databaseContext.SaveChanges();
        }
        public void RemuveOrderById(int orderId)
        {
            var order = databaseContext.Orders.Single(order => order.Id == orderId);
            databaseContext.Orders.Remove(order);

            databaseContext.SaveChanges();
        }
        public Order ReturnOrderById(int orderId)
        {
            var order = databaseContext.Orders.Single(order => order.Id == orderId);

            return order;
        }

        public Order GetByUseID(string userId)
        {
            
            return databaseContext.Orders.FirstOrDefault(order => order.Cart.UserId == userId);
        }

        public Order GetByName(string name)
        {

            return databaseContext.Orders.FirstOrDefault(order => order.Name == name);
        }

        public Order GetByPhone(string phone)
        {

            return databaseContext.Orders.FirstOrDefault(order => order.Phone == phone);
        }

        public List<Order> GetAllOrder()
        {
            return databaseContext.Orders.ToList();
        }
    }
}
